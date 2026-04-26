using Dalamud.Configuration;
using System;
using System.Collections.Generic;
using FFFeudPlugin.Models;

namespace FFFeudPlugin;

[Serializable]
public class Configuration : IPluginConfiguration
{
    public int Version { get; set; } = 0;

    public bool IsConfigWindowMovable { get; set; } = true;
    public bool SomePropertyToBeSavedAndWithADefault { get; set; } = true;

    public List<Category> Categories { get; set; } = new();
    
    public GameState CurrentGame { get; set; } = new();

    public string ChatPrefix { get; set; } = "/p";
    public int ChatDelayMs { get; set; } = 1000;
    public string MsgSendQuestion { get; set; } = "New Question: [QUESTION]";
    public string MsgActiveTeam { get; set; } = "[TEAM_NAME] is playing the current round!";
    public string MsgShowBoard { get; set; } = "--  [QUESTION]  --\n1. [A1]: [P1]    |    2. [A2]: [P2]    |    3. [A3]: [P3]    |    4. [A4]: [P4]    |    |5. [A5]: [P5]    |    6. [A6]: [P6]    |7. [A7]: [P7]    |    8. [A8]: [P8]\nStrikes: [STRIKES]";
    public string MsgStrike { get; set; } = "STRIKE [STRIKES] for [TEAM_NAME]!";
    public string MsgStrikeThree { get; set; } = "STRIKE [STRIKES] for [TEAM_NAME]! [OTHER_TEAM] has a chance to steal!";
    public string MsgEndQuestion { get; set; } = "This round is over! Scores:[TEAM_A]: [SCORE_A]    |    [TEAM_B]: [SCORE_B]";
    public string MsgRevealAnswer { get; set; } = "Answer revealed: [ANSWER] ([POINTS] points)";
    public string MsgEndGame { get; set; } = "[WINNER_TEAM] has won the game with [WINNER_SCORE] points! Congratulations!";
    public string MsgTeamScores { get; set; } = "Current Scores: [TEAM_A]: [SCORE_A] | [TEAM_B]: [SCORE_B]";

    // The below exists just to make saving less cumbersome
    public void Save()
    {
        Plugin.PluginInterface.SavePluginConfig(this);
    }
}
