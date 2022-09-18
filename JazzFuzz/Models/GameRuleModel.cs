using JazzFuzz.Enums;

namespace JazzFuzz.Models;

public class GameRuleModel
{
    public IEnumerable<WordsEnum> RuleWords { get; set; }
    public IEnumerable<int> RuleRange { get; set; }
}