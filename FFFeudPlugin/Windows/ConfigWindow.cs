using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using Dalamud.Bindings.ImGui;
using Dalamud.Interface.Windowing;
using Dalamud.Interface.Utility.Raii;
using FFFeudPlugin.Models;

namespace FFFeudPlugin.Windows;

public class ConfigWindow : Window, IDisposable
{
    private readonly Configuration configuration;
    
    // Active selection
    private Question? activeQuestion = null;
    private Category? activeCategory = null;

    // Drag and Drop state
    private Question? draggedQuestion = null;
    private Category? draggedSourceCategory = null;

    // Deletion state
    private Category? categoryToDelete = null;

    public ConfigWindow(Plugin plugin) : base("FF Feud Configuration###FFFeudConfigWindow")
    {
        Flags = ImGuiWindowFlags.NoCollapse;
        Size = new Vector2(900, 600);
        SizeCondition = ImGuiCond.FirstUseEver;
        configuration = plugin.Configuration;
        
        // Setup initial default category if empty
        if (configuration.Categories == null) {
            configuration.Categories = new();
        }

        if (configuration.Categories.Count == 0)
        {
            configuration.Categories.Add(DefaultQuestions.GetDefaultCategory());
            configuration.Categories.Add(ClassicQuestions.GetClassicCategory());
            configuration.Save();
        }
    }

    public void Dispose() { }

    public override void Draw()
    {
        if (ImGui.BeginTabBar("FFFeudTabs"))
        {
            if (ImGui.BeginTabItem("Settings"))
            {
                DrawSettingsTab();
                ImGui.EndTabItem();
            }

            if (ImGui.BeginTabItem("Questions Database"))
            {
                DrawQuestionsTab();
                ImGui.EndTabItem();
            }

            if (ImGui.BeginTabItem("Help"))
            {
                DrawHelpTab();
                ImGui.EndTabItem();
            }

            ImGui.EndTabBar();
        }
    }

    private unsafe void DrawQuestionsTab()
    {
        // Split window into left and right pane
        ImGui.Columns(2, "QuestionColumns", true);
        ImGui.SetColumnWidth(0, 300f);

        // --- Header Row ---
        // Column 0: Add Category
        if (ImGui.Button("+ Add Category"))
        {
            configuration.Categories.Add(new Category { Name = "New Category" });
            configuration.Save();
        }

        ImGui.NextColumn();

        // --- Separators ---
        ImGui.NextColumn();
        ImGui.Separator();
        ImGui.NextColumn();
        ImGui.Separator();

        // --- Body Row ---
        ImGui.NextColumn();
        if (ImGui.BeginChild("ExplorerPaneChild", new Vector2(0, 0), false))
        {
            DrawExplorerPane();
            ImGui.EndChild();
        }

        ImGui.NextColumn();
        if (ImGui.BeginChild("EditorPaneChild", new Vector2(0, 0), false))
        {
            DrawEditorPane();
            ImGui.EndChild();
        }

        ImGui.Columns(1);
    }

    private unsafe void DrawExplorerPane()
    {
        bool openDeleteModal = false;
        for (int cIndex = 0; cIndex < configuration.Categories.Count; cIndex++)
        {
            var category = configuration.Categories[cIndex];

            // Category Header
            ImGui.SetNextItemOpen(true, ImGuiCond.FirstUseEver); // default open
            bool opened = ImGui.TreeNodeEx($"[{category.Questions.Count}] {category.Name}###cat_{cIndex}", ImGuiTreeNodeFlags.DefaultOpen);

            // Drop target for dragging a question into an EMPTY category or onto the category header
            if (ImGui.BeginDragDropTarget())
            {
                var payload = ImGui.AcceptDragDropPayload("QUESTION_DRAG");
                if (payload.DataSize > 0 && draggedQuestion != null && draggedSourceCategory != null)
                {
                    if (draggedSourceCategory != category)
                    {
                        draggedSourceCategory.Questions.Remove(draggedQuestion);
                        category.Questions.Add(draggedQuestion);
                        configuration.Save();
                    }
                }
                ImGui.EndDragDropTarget();
            }

            // --- Context Menu for Category ---
            if (ImGui.BeginPopupContextItem($"##catMenu_{cIndex}"))
            {
                if (ImGui.Selectable("Delete Category"))
                {
                    categoryToDelete = category;
                    openDeleteModal = true;
                }
                ImGui.EndPopup();
            }

            if (opened)
            {
                if (ImGui.Button($"+ Question##addq_{cIndex}"))
                {
                    var newQ = new Question { Title = "New Question" };
                    category.Questions.Add(newQ);
                    activeQuestion = newQ;
                    activeCategory = category;
                    configuration.Save();
                }

                for (int qIndex = 0; qIndex < category.Questions.Count; qIndex++)
                {
                    var question = category.Questions[qIndex];
                    
                    bool isSelected = (activeQuestion == question);
                    string label = $"{qIndex + 1}: {(string.IsNullOrEmpty(question.Id) ? "" : $"[{question.Id}] ")}{question.Title}##q_{cIndex}_{qIndex}";
                    if (ImGui.Selectable(label, isSelected))
                    {
                        activeQuestion = question;
                        activeCategory = category;
                    }

                    // Drag Source
                    if (ImGui.BeginDragDropSource())
                    {
                        draggedQuestion = question;
                        draggedSourceCategory = category;
                        
                        // We must set a payload to validate the drop, even if it's empty data
                        ImGui.SetDragDropPayload("QUESTION_DRAG", new byte[1] { 1 });
                        ImGui.Text($"Moving {question.Title}...");
                        ImGui.EndDragDropSource();
                    }

                    // Drag Target (reordering)
                    if (ImGui.BeginDragDropTarget())
                    {
                        var payload = ImGui.AcceptDragDropPayload("QUESTION_DRAG");
                        if (payload.DataSize > 0 && draggedQuestion != null && draggedSourceCategory != null)
                        {
                            // Remove from old
                            draggedSourceCategory.Questions.Remove(draggedQuestion);
                            
                            // Insert at the dragged element position
                            int insertIndex = qIndex;
                            category.Questions.Insert(Math.Min(insertIndex, category.Questions.Count), draggedQuestion);
                            configuration.Save();
                            draggedQuestion = null;
                            draggedSourceCategory = null;
                        }
                        ImGui.EndDragDropTarget();
                    }
                }
                ImGui.TreePop();
            }
        }

        if (openDeleteModal)
        {
            ImGui.OpenPopup("ConfirmDeleteCategory");
        }

        // --- Category Deletion Confirmation Modal ---
        bool confirmDeleteCatOpen = true;
        if (ImGui.BeginPopupModal("ConfirmDeleteCategory", ref confirmDeleteCatOpen, ImGuiWindowFlags.AlwaysAutoResize))
        {
            if (categoryToDelete == null)
            {
                ImGui.CloseCurrentPopup();
            }
            else
            {
                ImGui.Text($"Are you sure you want to delete the category '{categoryToDelete.Name}'?");
                if (categoryToDelete.Questions.Count > 0)
                {
                    ImGui.TextColored(new Vector4(1f, 0.2f, 0.2f, 1f), $"WARNING: This will also delete {categoryToDelete.Questions.Count} questions!");
                }
                ImGui.Separator();

                float btnWidth = 120f;
                float totalWidth = (btnWidth * 2) + ImGui.GetStyle().ItemSpacing.X;
                ImGui.SetCursorPosX((ImGui.GetWindowSize().X - totalWidth) * 0.5f);

                if (ImGui.Button("Yes", new Vector2(btnWidth, 0)))
                {
                    if (activeCategory == categoryToDelete)
                    {
                        activeCategory = null;
                        activeQuestion = null;
                    }
                    configuration.Categories.Remove(categoryToDelete);
                    categoryToDelete = null;
                    configuration.Save();
                    ImGui.CloseCurrentPopup();
                }
                ImGui.SameLine();
                if (ImGui.Button("No", new Vector2(btnWidth, 0)))
                {
                    categoryToDelete = null;
                    ImGui.CloseCurrentPopup();
                }
            }
            ImGui.EndPopup();
        }
    }

    private void DrawEditorPane()
    {
        if (activeQuestion == null || activeCategory == null || !configuration.Categories.Contains(activeCategory) || !activeCategory.Questions.Contains(activeQuestion))
        {
            ImGui.TextDisabled("Select a question from the left panel to edit.");
            return;
        }

        // Category Editor
        string catName = activeCategory.Name;
        ImGui.SetNextItemWidth(200);
        if (ImGui.InputText("Category Name", ref catName, 100))
        {
            activeCategory.Name = catName;
            configuration.Save();
        }

        int index = activeCategory.Questions.IndexOf(activeQuestion) + 1;
        string displayId = string.IsNullOrEmpty(activeQuestion.Id) ? $"{activeCategory.Name}-{index} (Auto)" : activeQuestion.Id;
        ImGui.TextColored(new Vector4(0f, 1f, 1f, 1f), $"Question ID: {displayId}");

        ImGui.Spacing();

        string qTitle = activeQuestion.Title;
        ImGui.SetNextItemWidth(ImGui.GetContentRegionAvail().X - 100);
        if (ImGui.InputText("Question", ref qTitle, 200))
        {
            activeQuestion.Title = qTitle;
            configuration.Save();
        }

        ImGui.Separator();
        ImGui.Text("Answers");

        int totalPoints = 0;
        for (int i = 0; i < 8; i++)
        {
            // Ensure we have 8 answers
            if (activeQuestion.Answers.Count <= i)
                activeQuestion.Answers.Add(new Answer());

            var answer = activeQuestion.Answers[i];

            ImGui.PushID($"ans_{i}");
            
            string ansText = answer.Text;
            float availWidth = ImGui.GetContentRegionAvail().X;
            float ptsWidth = 40f;
            float labelWidth = 30f;
            float spacing = ImGui.GetStyle().ItemSpacing.X;
            
            ImGui.SetNextItemWidth(availWidth - ptsWidth - labelWidth - (spacing * 2));
            if (ImGui.InputTextWithHint("##Text", "Answer", ref ansText, 100))
            {
                answer.Text = ansText;
                configuration.Save();
            }

            ImGui.SameLine();
            ImGui.Text("Pts");
            ImGui.SameLine();
            ImGui.SetNextItemWidth(ptsWidth);
            int pts = answer.Points;
            if (ImGui.InputInt("##Pts", ref pts, 0, 0))
            {
                if (pts < 0) pts = 0;
                answer.Points = pts;
                configuration.Save();
            }

            string descText = answer.Description;
            ImGui.SetNextItemWidth(ImGui.GetContentRegionAvail().X);
            if (ImGui.InputTextWithHint("##Desc", "Host Note / Description", ref descText, 255))
            {
                answer.Description = descText;
                configuration.Save();
            }

            ImGui.Spacing();
            totalPoints += answer.Points;
            
            ImGui.PopID();
        }

        ImGui.Spacing();
        if (totalPoints != 100)
        {
            ImGui.TextColored(new Vector4(1f, 0.2f, 0.2f, 1f), $"WARNING: Total points sum to {totalPoints}, but should be exactly 100!");
        }
        else
        {
            ImGui.TextColored(new Vector4(0.2f, 1f, 0.2f, 1f), "PERFECT: Total points sum to 100!");
        }
        
        ImGui.Spacing();
        ImGui.Spacing();
        if (ImGui.Button("Delete Question"))
        {
            ImGui.OpenPopup("ConfirmDelete");
        }

        bool popupOpen = true;
        if (ImGui.BeginPopupModal("ConfirmDelete", ref popupOpen, ImGuiWindowFlags.AlwaysAutoResize))
        {
            ImGui.Text("Are you sure you want to delete this question?");
            ImGui.Separator();
            
            float buttonWidth = 120f;
            float totalWidth = (buttonWidth * 2) + ImGui.GetStyle().ItemSpacing.X;
            ImGui.SetCursorPosX((ImGui.GetWindowSize().X - totalWidth) * 0.5f);

            if (ImGui.Button("Yes", new Vector2(buttonWidth, 0)))
            {
                activeCategory.Questions.Remove(activeQuestion);
                activeQuestion = null;
                configuration.Save();
                ImGui.CloseCurrentPopup();
            }
            ImGui.SameLine();
            if (ImGui.Button("No", new Vector2(buttonWidth, 0)))
            {
                ImGui.CloseCurrentPopup();
            }
            ImGui.EndPopup();
        }
    }

    private void DrawSettingsTab()
    {
        ImGui.TextColored(new Vector4(1f, 1f, 0f, 1f), "Chat Settings");
        ImGui.Separator();

        string prefix = configuration.ChatPrefix;
        ImGui.SetNextItemWidth(200);
        if (ImGui.InputText("Chat Channel Prefix (e.g. /p, /a, /s)", ref prefix, 10))
        {
            configuration.ChatPrefix = prefix;
            configuration.Save();
        }

        int delay = configuration.ChatDelayMs;
        ImGui.SetNextItemWidth(200);
        if (ImGui.InputInt("Chat Delay in ms", ref delay, 50))
        {
            if (delay < 0) delay = 0;
            configuration.ChatDelayMs = delay;
            configuration.Save();
        }

        ImGui.Spacing();

        ImGui.Spacing();
        ImGui.TextColored(new Vector4(0f, 1f, 1f, 1f), "Chat Message Templates");
        ImGui.TextDisabled("Customize how messages appear in chat. Use the [BRACKETED] placeholders.");
        ImGui.Spacing();

        string msgSend = configuration.MsgSendQuestion;
        ImGui.Text("New Question");
        ImGui.TextDisabled("Announces the current question. Placeholder: [QUESTION]");
        ImGui.SetNextItemWidth(ImGui.GetContentRegionAvail().X);
        if (ImGui.InputText("##MsgSend", ref msgSend, 255))
        {
            configuration.MsgSendQuestion = msgSend;
            configuration.Save();
        }

        string msgReveal = configuration.MsgRevealAnswer;
        ImGui.Spacing();
        ImGui.Text("Reveal Answer");
        ImGui.TextDisabled("Sent when an answer is revealed. Placeholders: [ANSWER], [POINTS]");
        ImGui.SetNextItemWidth(ImGui.GetContentRegionAvail().X);
        if (ImGui.InputText("##MsgReveal", ref msgReveal, 255))
        {
            configuration.MsgRevealAnswer = msgReveal;
            configuration.Save();
        }

        string msgActive = configuration.MsgActiveTeam;
        ImGui.Spacing();
        ImGui.Text("Active Team");
        ImGui.TextDisabled("Sent when the active team is changed. Placeholder: [TEAM_NAME]");
        ImGui.SetNextItemWidth(ImGui.GetContentRegionAvail().X);
        if (ImGui.InputText("##MsgActive", ref msgActive, 255))
        {
            configuration.MsgActiveTeam = msgActive;
            configuration.Save();
        }

        string msgStrike = configuration.MsgStrike;
        ImGui.Spacing();
        ImGui.Text("Strike (1 or 2)");
        ImGui.TextDisabled("Placeholders: [STRIKES], [TEAM_NAME]");
        ImGui.SetNextItemWidth(ImGui.GetContentRegionAvail().X);
        if (ImGui.InputText("##MsgStrike", ref msgStrike, 255))
        {
            configuration.MsgStrike = msgStrike;
            configuration.Save();
        }

        string msgStrike3 = configuration.MsgStrikeThree;
        ImGui.Spacing();
        ImGui.Text("Third Strike (Steal Opportunity)");
        ImGui.TextDisabled("Placeholders: [STRIKES], [TEAM_NAME], [OTHER_TEAM]");
        ImGui.SetNextItemWidth(ImGui.GetContentRegionAvail().X);
        if (ImGui.InputText("##MsgStrike3", ref msgStrike3, 255))
        {
            configuration.MsgStrikeThree = msgStrike3;
            configuration.Save();
        }

        string msgEnd = configuration.MsgEndQuestion;
        ImGui.Spacing();
        ImGui.Text("Round End / Score Update");
        ImGui.TextDisabled("Placeholders: [TEAM_A], [SCORE_A], [TEAM_B], [SCORE_B]");
        ImGui.SetNextItemWidth(ImGui.GetContentRegionAvail().X);
        if (ImGui.InputText("##MsgEnd", ref msgEnd, 255))
        {
            configuration.MsgEndQuestion = msgEnd;
            configuration.Save();
        }

        string msgEndGame = configuration.MsgEndGame;
        ImGui.Spacing();
        ImGui.Text("Game Win / Final Result");
        ImGui.TextDisabled("Placeholders: [WINNER_TEAM], [WINNER_SCORE]");
        ImGui.SetNextItemWidth(ImGui.GetContentRegionAvail().X);
        if (ImGui.InputText("##MsgEndGame", ref msgEndGame, 255))
        {
            configuration.MsgEndGame = msgEndGame;
            configuration.Save();
        }

        string msgTeamScores = configuration.MsgTeamScores;
        ImGui.Spacing();
        ImGui.Text("Current Team Scores");
        ImGui.TextDisabled("Placeholders: [TEAM_A], [SCORE_A], [TEAM_B], [SCORE_B]");
        ImGui.SetNextItemWidth(ImGui.GetContentRegionAvail().X);
        if (ImGui.InputText("##MsgTeamScores", ref msgTeamScores, 255))
        {
            configuration.MsgTeamScores = msgTeamScores;
            configuration.Save();
        }

        string msgBoard = configuration.MsgShowBoard;
        ImGui.Spacing();
        ImGui.Text("Show Board (Multiline)");
        ImGui.TextDisabled("Starting a new Line will start a new message. Placeholders: [QUESTION], [STRIKES], [A1-A8], [P1-P8], [POINTSONBOARD]");
        if (ImGui.InputTextMultiline("##MsgBoard", ref msgBoard, 1000, new Vector2(ImGui.GetContentRegionAvail().X, ImGui.GetTextLineHeightWithSpacing() * 4.5f)))
        {
            configuration.MsgShowBoard = msgBoard;
            configuration.Save();
        }

        ImGui.Spacing();
        ImGui.Spacing();
        ImGui.TextColored(new Vector4(1f, 1f, 0f, 1f), "Question Database Settings");
        ImGui.Separator();

        if (ImGui.Button("Restore Default Questions"))
        {
            ImGui.OpenPopup("ConfirmRestore");
        }

        bool confirmRestoreOpen = true;
        if (ImGui.BeginPopupModal("ConfirmRestore", ref confirmRestoreOpen, ImGuiWindowFlags.AlwaysAutoResize))
        {
            ImGui.Text("Do you want to restore the Default and Classic questions to your database? This will overwrite any changes you made to them.");
            ImGui.Separator();

            float modalBtnWidth = 120f;
            float totalWidth = (modalBtnWidth * 2) + ImGui.GetStyle().ItemSpacing.X;
            ImGui.SetCursorPosX((ImGui.GetWindowSize().X - totalWidth) * 0.5f);

            if (ImGui.Button("Yes", new Vector2(modalBtnWidth, 0)))
            {
                var defaultCats = new List<Category> { 
                    Models.DefaultQuestions.GetDefaultCategory(), 
                    Models.ClassicQuestions.GetClassicCategory() 
                };

                foreach (var dCat in defaultCats)
                {
                    // Find or create category
                    var existingCat = configuration.Categories.FirstOrDefault(c => c.Name == dCat.Name);
                    if (existingCat == null)
                    {
                        existingCat = new Category { Name = dCat.Name };
                        configuration.Categories.Add(existingCat);
                    }

                    foreach (var dQuest in dCat.Questions)
                    {
                        // Look for Question with same ID in the whole database
                        Question? targetQuest = null;
                        foreach (var cat in configuration.Categories)
                        {
                            targetQuest = cat.Questions.FirstOrDefault(q => !string.IsNullOrEmpty(q.Id) && q.Id == dQuest.Id);
                            if (targetQuest != null) break;
                        }

                        if (targetQuest != null)
                        {
                            // Overwrite
                            targetQuest.Title = dQuest.Title;
                            targetQuest.Answers = dQuest.Answers;
                        }
                        else
                        {
                            // Add new
                            existingCat.Questions.Add(dQuest);
                        }
                    }
                }

                configuration.Save();
                ImGui.CloseCurrentPopup();
            }
            ImGui.SameLine();
            if (ImGui.Button("No", new Vector2(modalBtnWidth, 0)))
            {
                ImGui.CloseCurrentPopup();
            }
            ImGui.EndPopup();
        }
    }

    private void DrawHelpTab()
    {
        ImGui.TextColored(new Vector4(0f, 1f, 1f, 1f), "FF Feud - Help & Plugin Info");
        ImGui.Separator();
        ImGui.Spacing();

        ImGui.TextWrapped(@"Thank you for trying out my Plugin! 

It is intended to be played by at least 3 people (2 players and 1 host) - but Teams make it alot more fun.

The Plugin is designed to mimic the original Family Feud game while using only in-Game Chat as playing board.
I included a set of Classic Family Feud Questions I found online and a set of FF:XIV related questions I composed myself and surveyed on reddit.

Before starting your first game with your friends, I recommend making a dry run in a private party.

Here is a quick guide on the rough structure I intended:


1. Find your players and split them into two teams. They can use a custom team name you can type into the Host Panel.
2. Select a Category and Question in the Host Panel and use the 'Send Question Only to Chat' button to announce the question.

Round Structure:

    3.1 Determine what team plays the round: Since we dont have buzzers ingame, I suggest to let the teams do a dice roll with  /random
        and the higher number can answer first.
    3.2 The first team to give an answer on the board (dont forget to reveal it) can choose to play the current round or pass and let the other team play. Choose the active team accordingly.
    3.3 The players on the active team give answers in sequence. If a provided answer is on the board, reveal it.
        If the answer is wrong, the active team gets a strike - up to a total of 3.
    3.4 If the active team reveals all answers without getting 3 strikes, they get all the points of the round. Use the 'Award Board to Team X' to update the scores. The round ends.
    3.5 If the active team gets 3 strikes, the other team gets a chance to steal the points by giving one answer (they can confer with each other).
    3.5.1 If they give an unrevealed answer, reveal it and award the points to them.
    3.5.2 If they fail to give a missing answer, the points go to the active team. The round ends.

    - The active team is traditionally prohibited from talking to each other, but this may be difficult to enforce ingame
    - During a round, you can show the complete board with the 'Show Board' button. This is not mandatory, but helps the players to remind what answers have already been revealed.
    - All messages are sent to the chat channel you set in the Plugin Settings.
    - The messages can be customized in the plugin settings

4. You can choose the next question and send it to your players or end the game. 

This plugin enables you to send semi-automated messages to the in-game chat. Use responsibly. 
Do not use it in public chat channels (say, yell, shout). Make parties or a private alliance.");

        ImGui.Spacing();
        ImGui.Separator();
        ImGui.Spacing();

        ImGui.TextColored(new Vector4(0.3f, 0.8f, 1f, 1f), "Support & Community");
        ImGui.Spacing();
        if (ImGui.Button("Join Support Discord"))
        {
            Dalamud.Utility.Util.OpenLink("https://discord.gg/PvxW4mXaWp");
        }
        ImGui.SameLine();
        if (ImGui.Button("Support on Ko-fi"))
        {
            Dalamud.Utility.Util.OpenLink("https://ko-fi.com/kararemy");
        }
        ImGui.Spacing();
    }
}
