using System;

namespace FFFeudPlugin.Models;

[Serializable]
public class GameState
{
    public string TeamAName { get; set; } = "Team A";
    public string TeamBName { get; set; } = "Team B";
    public int TeamAScore { get; set; } = 0;
    public int TeamBScore { get; set; } = 0;
    
    public int Strikes { get; set; } = 0;
    
    public string ActiveTeam { get; set; } = "none";
    
    public int CurrentCategoryIndex { get; set; } = 0;
    public int CurrentQuestionIndex { get; set; } = 0;

    public bool[] RevealedAnswers { get; set; } = new bool[8];
    public int BoardTotalPoints { get; set; } = 0;

    public void ResetQuestionState()
    {
        Strikes = 0;
        BoardTotalPoints = 0;
        RevealedAnswers = new bool[8];
    }
}
