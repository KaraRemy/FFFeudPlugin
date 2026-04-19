using System;
using System.Collections.Generic;

namespace FFFeudPlugin.Models;

[Serializable]
public class Answer
{
    public string Text { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int Points { get; set; } = 0;
}

[Serializable]
public class Question
{
    public string Title { get; set; } = "New Question";
    public List<Answer> Answers { get; set; } = new();

    public Question()
    {
        for (int i = 0; i < 8; i++)
        {
            Answers.Add(new Answer());
        }
    }
}

[Serializable]
public class Category
{
    public string Name { get; set; } = "New Category";
    public List<Question> Questions { get; set; } = new();
}
