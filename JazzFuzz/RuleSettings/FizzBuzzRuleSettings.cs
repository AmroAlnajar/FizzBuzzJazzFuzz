using JazzFuzz.Enums;
using JazzFuzz.Models;

namespace JazzFuzz.RuleSettings;
public class FizzBuzzRuleSettings : IGameRuleSettings
{
    public GameRuleModel GetRuleSettings()
    {
        var ruleRange = Enumerable.Range(1, 100);
        var ruleWords = new List<WordsEnum> { WordsEnum.Fizz, WordsEnum.Buzz };

        return new GameRuleModel { RuleRange = ruleRange, RuleWords = ruleWords };
    }
}
