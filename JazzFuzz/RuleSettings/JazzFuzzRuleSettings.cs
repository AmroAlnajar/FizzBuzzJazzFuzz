using JazzFuzz.Enums;
using JazzFuzz.Models;

namespace JazzFuzz.RuleSettings;

public class JazzFuzzRuleSettings : IGameRuleSettings
{
    public GameRuleModel GetRuleSettings()
    {
        var ruleRange = Enumerable.Range(1, 100).Reverse();
        var ruleWords = new List<WordsEnum> { WordsEnum.Jazz, WordsEnum.Fuzz };

        return new GameRuleModel { RuleRange = ruleRange, RuleWords = ruleWords };
    }
}
