using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using Dalamud.Bindings.ImGui;
using Dalamud.Interface.Windowing;
using Dalamud.Interface.Utility;
using Dalamud.Interface.Utility.Raii;
using FFFeudPlugin.Models;

namespace FFFeudPlugin.Windows;

public class MainWindow : Window, IDisposable
{
    private readonly Plugin plugin;
    private Configuration Config => plugin.Configuration;
    private GameState State => Config.CurrentGame;

    private readonly Queue<string> messageQueue = new();
    private DateTime nextMessageTime = DateTime.MinValue;

    public MainWindow(Plugin plugin, string dummy)
        : base("Host Panel - FF Feud###FFFeudHostPanel", ImGuiWindowFlags.NoScrollbar | ImGuiWindowFlags.NoScrollWithMouse)
    {
        this.plugin = plugin;
        SizeConstraints = new WindowSizeConstraints
        {
            MinimumSize = new Vector2(500, 600),
            MaximumSize = new Vector2(float.MaxValue, float.MaxValue)
        };
    }

    public void Dispose() { }

    private Question? GetCurrentQuestion()
    {
        if (Config.Categories.Count > State.CurrentCategoryIndex)
        {
            var cat = Config.Categories[State.CurrentCategoryIndex];
            if (cat.Questions.Count > State.CurrentQuestionIndex)
                return cat.Questions[State.CurrentQuestionIndex];
        }
        return null;
    }

    public override void Draw()
    {
        // Process message queue safely on UI thread to prevent freezing and ban-triggering fast sending
        if (messageQueue.Count > 0 && DateTime.Now >= nextMessageTime)
        {
            FFFeudPlugin.GameFunctions.ChatSender.SendMessage(messageQueue.Dequeue());
            nextMessageTime = DateTime.Now.AddMilliseconds(Config.ChatDelayMs);
        }

        if (ImGui.Button("Go to Settings / Database"))
            plugin.ToggleConfigUi();

        ImGui.Separator();
        DrawGameArea();
        ImGui.Separator();
        DrawNavigationArea();
    }

    private void DrawGameArea()
    {
        ImGui.TextColored(new Vector4(1, 0.8f, 0, 1), "TEAMS");

        // Teams
        string tA = State.TeamAName;
        ImGui.SetNextItemWidth(150);
        if (ImGui.InputText("##TeamA", ref tA, 100)) { State.TeamAName = tA; Config.Save(); }
        
        ImGui.SameLine();
        ImGui.SetNextItemWidth(80);
        int sA = State.TeamAScore;
        if (ImGui.InputInt("Score A", ref sA)) { State.TeamAScore = sA; Config.Save(); }

        string tB = State.TeamBName;
        ImGui.SetNextItemWidth(150);
        if (ImGui.InputText("##TeamB", ref tB, 100)) { State.TeamBName = tB; Config.Save(); }
        
        ImGui.SameLine();
        ImGui.SetNextItemWidth(80);
        int sB = State.TeamBScore;
        if (ImGui.InputInt("Score B", ref sB)) { State.TeamBScore = sB; Config.Save(); }

        ImGui.SameLine();
        if (ImGui.Button("Reset Game"))
        {
            ImGui.OpenPopup("ConfirmReset");
        }

        bool popupOpen = true;
        if (ImGui.BeginPopupModal("ConfirmReset", ref popupOpen, ImGuiWindowFlags.AlwaysAutoResize))
        {
            ImGui.Text("Are you sure you want to reset the entire game? This clears names, scores and the board!");
            ImGui.Separator();
            
            float buttonWidth = 120f;
            float totalWidth = (buttonWidth * 2) + ImGui.GetStyle().ItemSpacing.X;
            ImGui.SetCursorPosX((ImGui.GetWindowSize().X - totalWidth) * 0.5f);
            
            if (ImGui.Button("Yes", new Vector2(buttonWidth, 0)))
            {
                State.TeamAScore = 0;
                State.TeamBScore = 0;
                State.TeamAName = "Team A";
                State.TeamBName = "Team B";
                State.ActiveTeam = "none";
                State.Strikes = 0;
                State.ResetQuestionState();
                Config.Save();
                ImGui.CloseCurrentPopup();
            }
            ImGui.SameLine();
            if (ImGui.Button("No", new Vector2(buttonWidth, 0)))
            {
                ImGui.CloseCurrentPopup();
            }
            ImGui.EndPopup();
        }

        ImGui.Spacing();
        ImGui.Separator();
        ImGui.TextColored(new Vector4(0, 1, 1, 1), "CURRENT BOARD");

        // Split Category and Question Dropdowns
        if (Config.Categories.Count > 0)
        {
            if (State.CurrentCategoryIndex >= Config.Categories.Count) State.CurrentCategoryIndex = 0;
            var cat = Config.Categories[State.CurrentCategoryIndex];
            
            ImGui.SetNextItemWidth(300);
            if (ImGui.BeginCombo("##Category", cat.Name))
            {
                for (int c = 0; c < Config.Categories.Count; c++)
                {
                    bool isSelected = (State.CurrentCategoryIndex == c);
                    if (ImGui.Selectable(Config.Categories[c].Name, isSelected))
                    {
                        State.CurrentCategoryIndex = c;
                        State.CurrentQuestionIndex = 0;
                        State.ResetQuestionState();
                        Config.Save();
                    }
                }
                ImGui.EndCombo();
            }

            ImGui.SameLine();
            ImGui.SetNextItemWidth(300);
            var qTitle = "None";
            if (cat.Questions.Count > State.CurrentQuestionIndex)
                qTitle = cat.Questions[State.CurrentQuestionIndex].Title;

            if (ImGui.BeginCombo("##Question", qTitle))
            {
                for (int qIdx = 0; qIdx < cat.Questions.Count; qIdx++)
                {
                    bool isSelected = (State.CurrentQuestionIndex == qIdx);
                    if (ImGui.Selectable($"{qIdx + 1}. {cat.Questions[qIdx].Title}", isSelected))
                    {
                        State.CurrentQuestionIndex = qIdx;
                        State.ResetQuestionState();
                        Config.Save();
                    }
                }
                ImGui.EndCombo();
            }
        }
        
        ImGui.Spacing();
        if (ImGui.Button("Send Question only to Chat"))
        {
            var qRef = GetCurrentQuestion();
            if (qRef != null)
            {
                string txt = Config.MsgSendQuestion.Replace("[QUESTION]", qRef.Title);
                SendToChat(txt);
            }
        }

        var q = GetCurrentQuestion();
        if (q == null)
        {
            ImGui.Text("No question selected.");
            return;
        }
        
        State.BoardTotalPoints = 0;
        
        if (ImGui.BeginTable("BoardTable", 4, ImGuiTableFlags.Borders | ImGuiTableFlags.RowBg))
        {
            ImGui.TableSetupColumn("Action", ImGuiTableColumnFlags.WidthFixed, 60);
            ImGui.TableSetupColumn("Status", ImGuiTableColumnFlags.WidthFixed, 60);
            ImGui.TableSetupColumn("Points", ImGuiTableColumnFlags.WidthFixed, 50);
            ImGui.TableSetupColumn("Answer & Note");
            ImGui.TableHeadersRow();

            for (int i = 0; i < 8; i++)
            {
                if (i >= q.Answers.Count) continue;
                var ans = q.Answers[i];
                if (string.IsNullOrWhiteSpace(ans.Text)) continue;

                ImGui.TableNextRow();
                
                ImGui.TableNextColumn();
                bool revealed = State.RevealedAnswers[i];
                ImGui.PushID($"btn_rev_{i}");
                if (ImGui.Button(revealed ? " Hide " : "Reveal", new Vector2(60, 0)))
                {
                    State.RevealedAnswers[i] = !revealed;
                    Config.Save();
                }
                ImGui.PopID();

                ImGui.TableNextColumn();
                if (revealed)
                {
                    ImGui.TextColored(new Vector4(0.2f, 1, 0.2f, 1), "VISIBLE");
                    State.BoardTotalPoints += ans.Points;
                }
                else
                {
                    ImGui.TextColored(new Vector4(0.5f, 0.5f, 0.5f, 1), "HIDDEN");
                }

                ImGui.TableNextColumn();
                ImGui.Text(ans.Points.ToString());

                ImGui.TableNextColumn();
                ImGui.Text(ans.Text);
                if (!string.IsNullOrWhiteSpace(ans.Description))
                {
                    ImGui.SameLine();
                    ImGui.TextColored(new Vector4(0.7f, 0.7f, 0.7f, 1), $"({ans.Description})");
                }
            }
            ImGui.EndTable();
        }
        
        ImGui.Spacing();
        ImGui.Text($"Board Total Points: {State.BoardTotalPoints}");
        ImGui.Text($"Strikes: {State.Strikes}/3");
    }

    private void DrawNavigationArea()
    {
        ImGui.TextColored(new Vector4(1, 0.5f, 1, 1), "ACTIONS & CHAT");

        ImGui.Spacing();
        ImGui.Text("Active Team:");
        ImGui.SameLine();
        if (ImGui.RadioButton($"A ({State.TeamAName})", State.ActiveTeam == "a")) 
        { 
            State.ActiveTeam = "a"; 
            Config.Save(); 
            SendToChat(Config.MsgActiveTeam.Replace("[TEAM_NAME]", State.TeamAName));
        }
        ImGui.SameLine();
        if (ImGui.RadioButton($"B ({State.TeamBName})", State.ActiveTeam == "b")) 
        { 
            State.ActiveTeam = "b"; 
            Config.Save(); 
            SendToChat(Config.MsgActiveTeam.Replace("[TEAM_NAME]", State.TeamBName));
        }
        ImGui.SameLine();
        if (ImGui.RadioButton("None", State.ActiveTeam == "none")) { State.ActiveTeam = "none"; Config.Save(); }

        ImGui.Spacing();
        if (ImGui.Button("Show Board in Chat"))
        {
            FormatOutputBoard();
        }
        ImGui.SameLine();
        ImGui.TextColored(new Vector4(0, 1, 1, 1), $"Current points on the Board: {State.BoardTotalPoints}");
        
        ImGui.SameLine();
        if (ImGui.Button($"Strike! ({State.Strikes})"))
        {
            State.Strikes++;
            if (State.Strikes > 3) State.Strikes = 3;
            Config.Save();

            string team = State.ActiveTeam == "a" ? State.TeamAName : (State.ActiveTeam == "b" ? State.TeamBName : "Nobody");
            string otherTeam = State.ActiveTeam == "a" ? State.TeamBName : (State.ActiveTeam == "b" ? State.TeamAName : "Nobody");
            
            string template = State.Strikes == 3 ? Config.MsgStrikeThree : Config.MsgStrike;
            string txt = template.Replace("[STRIKES]", new string('X', State.Strikes))
                                 .Replace("[TEAM_NAME]", team)
                                 .Replace("[OTHER_TEAM]", otherTeam);
            SendToChat(txt);
        }
        
        ImGui.SameLine();
        if (ImGui.Button("Clear Strikes"))
        {
            State.Strikes = 0;
            Config.Save();
        }

        ImGui.Spacing();
        ImGui.Separator();

        if (ImGui.Button("Award Board to Team A"))
        {
            State.TeamAScore += State.BoardTotalPoints;
            State.BoardTotalPoints = 0;
            Config.Save();
            FormatEndRound();
        }
        ImGui.SameLine();
        if (ImGui.Button("Award Board to Team B"))
        {
            State.TeamBScore += State.BoardTotalPoints;
            State.BoardTotalPoints = 0;
            Config.Save();
            FormatEndRound();
        }
    }

    private void SendToChat(string text)
    {
        string[] lines = text.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
        foreach (var line in lines)
        {
            if (string.IsNullOrWhiteSpace(line)) continue;
            string fullMsg = $"{Config.ChatPrefix} {line}";
            messageQueue.Enqueue(fullMsg);
        }
    }

    private void FormatOutputBoard()
    {
        var q = GetCurrentQuestion();
        if (q == null) return;

        string board = Config.MsgShowBoard;
        board = board.Replace("[QUESTION]", q.Title);
        board = board.Replace("[STRIKES]", new string('X', State.Strikes));
        board = board.Replace("[POINTSONBOARD]", State.BoardTotalPoints.ToString());

        for (int i = 0; i < 8; i++)
        {
            string pAnswer = $"[A{i + 1}]";
            string pPoints = $"[P{i + 1}]";
            
            if (i < q.Answers.Count && !string.IsNullOrWhiteSpace(q.Answers[i].Text))
            {
                if (State.RevealedAnswers[i])
                {
                    board = board.Replace(pAnswer, q.Answers[i].Text).Replace(pPoints, q.Answers[i].Points.ToString() + " Pts");
                }
                else
                {
                    board = board.Replace(pAnswer, "???").Replace(pPoints, "??");
                }
            }
            else
            {   // If the question doesn't have an answer, remove the placeholder entirely
                board = board.Replace(pAnswer, "").Replace(pPoints, "");
            }
        }
        SendToChat(board);
    }

    private void FormatEndRound()
    {
        string txt = Config.MsgEndQuestion
            .Replace("[TEAM_A]", State.TeamAName)
            .Replace("[SCORE_A]", State.TeamAScore.ToString())
            .Replace("[TEAM_B]", State.TeamBName)
            .Replace("[SCORE_B]", State.TeamBScore.ToString());
        SendToChat(txt);
    }
}
