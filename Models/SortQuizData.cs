using System.Text.Json.Serialization;

namespace pub_quiz.Models;

public class SortQuizData
{
    [JsonPropertyName("title")]
    public string Title { get; set; } = string.Empty;

    [JsonPropertyName("upperLabel")]
    public string UpperLabel { get; set; } = string.Empty;

    [JsonPropertyName("lowerLabel")]
    public string LowerLabel { get; set; } = string.Empty;

    [JsonPropertyName("_hint")]
    public string Hint { get; set; } = string.Empty;

    [JsonPropertyName("items")]
    public List<string> Items { get; set; } = new();
}

public class GameState
{
    public List<string> RemainingItems { get; set; } = new();
    public List<TimelineSlot> Timeline { get; set; } = new();
    public bool GameEnded { get; set; }
    public bool GameWon { get; set; }
    public List<string> CorrectOrder { get; set; } = new();
    public List<string> PlayerOrder { get; set; } = new();
}

public class TimelineSlot
{
    public int Position { get; set; }
    public string? Item { get; set; }
    public bool IsCorrect { get; set; }
}