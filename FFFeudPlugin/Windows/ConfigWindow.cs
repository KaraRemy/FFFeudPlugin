using System;
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
            if (ImGui.BeginTabItem("Questions Database"))
            {
                DrawQuestionsTab();
                ImGui.EndTabItem();
            }

            if (ImGui.BeginTabItem("Settings"))
            {
                DrawSettingsTab();
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

        // Column 1: Restore Button
        float btnWidth = 240f;
        ImGui.SetCursorPosX(ImGui.GetCursorPosX() + ImGui.GetContentRegionAvail().X - btnWidth);
        if (ImGui.Button("Restore Default Questions", new Vector2(btnWidth, 0)))
        {
            ImGui.OpenPopup("ConfirmRestore");
        }

        bool confirmRestoreOpen = true;
        if (ImGui.BeginPopupModal("ConfirmRestore", ref confirmRestoreOpen, ImGuiWindowFlags.AlwaysAutoResize))
        {
            ImGui.Text("Do you want to add the Default and Classic questions to your database?");
            ImGui.Separator();
            
            float modalBtnWidth = 120f;
            float totalWidth = (modalBtnWidth * 2) + ImGui.GetStyle().ItemSpacing.X;
            ImGui.SetCursorPosX((ImGui.GetWindowSize().X - totalWidth) * 0.5f);
            
            if (ImGui.Button("Yes", new Vector2(modalBtnWidth, 0)))
            {
                configuration.Categories.Add(Models.DefaultQuestions.GetDefaultCategory());
                configuration.Categories.Add(Models.ClassicQuestions.GetClassicCategory());
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

        // --- Separators ---
        ImGui.NextColumn();
        ImGui.Separator();
        ImGui.NextColumn();
        ImGui.Separator();

        // --- Body Row ---
        ImGui.NextColumn();
        DrawExplorerPane(); // Now only draws the tree

        ImGui.NextColumn();
        DrawEditorPane();

        ImGui.Columns(1);
    }

    private unsafe void DrawExplorerPane()
    {
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
                    if (ImGui.Selectable($"{qIndex + 1}: {question.Title}##q_{cIndex}_{qIndex}", isSelected))
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
        ImGui.TextColored(new Vector4(0f, 1f, 1f, 1f), $"Question ID: {activeCategory.Name}-{index}");

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
            ImGui.SetNextItemWidth(ImGui.GetContentRegionAvail().X - 100);
            if (ImGui.InputTextWithHint("##Text", "Answer", ref ansText, 100))
            {
                answer.Text = ansText;
                configuration.Save();
            }

            ImGui.SameLine();
            ImGui.SetNextItemWidth(80);
            int pts = answer.Points;
            if (ImGui.InputInt("Pts", ref pts))
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

        string msgSend = configuration.MsgSendQuestion;
        ImGui.SetNextItemWidth(ImGui.GetContentRegionAvail().X);
        if (ImGui.InputTextWithHint("Send Question Template", "Use [QUESTION]", ref msgSend, 255))
        {
            configuration.MsgSendQuestion = msgSend;
            configuration.Save();
        }

        string msgActive = configuration.MsgActiveTeam;
        ImGui.SetNextItemWidth(ImGui.GetContentRegionAvail().X);
        if (ImGui.InputTextWithHint("Active Team Template", "Use [TEAM_NAME]", ref msgActive, 255))
        {
            configuration.MsgActiveTeam = msgActive;
            configuration.Save();
        }

        string msgStrike = configuration.MsgStrike;
        ImGui.SetNextItemWidth(ImGui.GetContentRegionAvail().X);
        if (ImGui.InputTextWithHint("Strike Template", "Use [STRIKES], [TEAM_NAME]", ref msgStrike, 255))
        {
            configuration.MsgStrike = msgStrike;
            configuration.Save();
        }

        string msgStrike3 = configuration.MsgStrikeThree;
        ImGui.SetNextItemWidth(ImGui.GetContentRegionAvail().X);
        if (ImGui.InputTextWithHint("3 Strikes Template", "Use [STRIKES], [TEAM_NAME], [OTHER_TEAM]", ref msgStrike3, 255))
        {
            configuration.MsgStrikeThree = msgStrike3;
            configuration.Save();
        }

        string msgEnd = configuration.MsgEndQuestion;
        ImGui.SetNextItemWidth(ImGui.GetContentRegionAvail().X);
        if (ImGui.InputTextWithHint("End Round Template", "Use [TEAM_A], [SCORE_A]", ref msgEnd, 255))
        {
            configuration.MsgEndQuestion = msgEnd;
            configuration.Save();
        }

        string msgBoard = configuration.MsgShowBoard;
        if (ImGui.InputTextMultiline("Show Board Template", ref msgBoard, 1000, new Vector2(ImGui.GetContentRegionAvail().X, ImGui.GetTextLineHeightWithSpacing() * 3.5f)))
        {
            configuration.MsgShowBoard = msgBoard;
            configuration.Save();
        }
    }

    private void DrawHelpTab()
    {
        ImGui.TextColored(new Vector4(0f, 1f, 1f, 1f), "FF Feud - Help & Plugin Info");
        ImGui.Separator();
        ImGui.Spacing();

        ImGui.TextWrapped("Hier kommt die Beschreibung hin - you can write a long markdown-like text here to explain how the plugin works.");
    }
}
