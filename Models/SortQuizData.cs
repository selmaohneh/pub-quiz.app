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

    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;

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

// Year Quiz Models
public class YearQuizData
{
    [JsonPropertyName("title")]
    public string Title { get; set; } = string.Empty;

    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;

    [JsonPropertyName("items")]
    public List<YearQuizItem> Items { get; set; } = new();
}

public class YearQuizItem
{
    [JsonPropertyName("title")]
    public string Title { get; set; } = string.Empty;

    [JsonPropertyName("year")]
    public int Year { get; set; }
}

public class YearGameState
{
    public List<YearQuizItem> Items { get; set; } = new();
    public YearQuizItem? CurrentItem { get; set; }
    public int CurrentItemIndex { get; set; }
    public int CurrentRange { get; set; } = 0;
    public bool GameStarted { get; set; }
    public bool GameStopped { get; set; }
    public bool GameEnded { get; set; }
    public bool GameWon { get; set; }
    public int PlayerGuess { get; set; }
    public DateTime GameStartTime { get; set; }
    public DateTime LastRangeUpdateTime { get; set; }
    public double ProgressPercentage { get; set; }
    public int SecondsUntilRangeIncrease { get; set; } = 10;
    public bool RangeJustUpdated { get; set; }
}

// Lie Quiz Models
public class LieQuizData
{
    [JsonPropertyName("title")]
    public string Title { get; set; } = string.Empty;

    [JsonPropertyName("question")]
    public string Question { get; set; } = string.Empty;

    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;

    [JsonPropertyName("items")]
    public List<LieQuizItem> Items { get; set; } = new();
}

public class LieQuizItem
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("isLie")]
    public bool IsLie { get; set; }
}

public class LieGameState
{
    public List<LieQuizItem> Items { get; set; } = new();
    public LieQuizItem? CurrentItem { get; set; }
    public int CurrentItemIndex { get; set; }
    public bool GameStarted { get; set; }
    public bool GameEnded { get; set; }
    public bool ShowResult { get; set; }
    public bool PlayerGuessedLie { get; set; }
    public bool WasCorrectGuess { get; set; }
    public DateTime ItemStartTime { get; set; }
    public int LiesFound { get; set; }
    public int TotalLies { get; set; }
    public bool AllLiesFound { get; set; }
    public string Question { get; set; } = string.Empty;
    public int SecondsUntilNextItem { get; set; } = 10;
}

// Pair Quiz Models
public class PairQuizData
{
    [JsonPropertyName("title")]
    public string Title { get; set; } = string.Empty;

    [JsonPropertyName("leftLabel")]
    public string LeftLabel { get; set; } = string.Empty;

    [JsonPropertyName("rightLabel")]
    public string RightLabel { get; set; } = string.Empty;

    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;

    [JsonPropertyName("pairs")]
    public List<PairQuizPair> Pairs { get; set; } = new();

    [JsonPropertyName("additionalRightItem")]
    public string AdditionalRightItem { get; set; } = string.Empty;
}

public class PairQuizPair
{
    [JsonPropertyName("left")]
    public string Left { get; set; } = string.Empty;

    [JsonPropertyName("right")]
    public string Right { get; set; } = string.Empty;
}

public class PairGameState
{
    public List<string> LeftItems { get; set; } = new();
    public List<string> RightItems { get; set; } = new();
    public List<PairQuizPair> CorrectPairs { get; set; } = new();
    public List<PairQuizPair> MatchedPairs { get; set; } = new();
    public bool GameEnded { get; set; }
    public bool GameWon { get; set; }
    public string? SelectedLeftItem { get; set; }
    public string? SelectedRightItem { get; set; }
    public string? IncorrectLeftItem { get; set; }
    public string? IncorrectRightItem { get; set; }
}