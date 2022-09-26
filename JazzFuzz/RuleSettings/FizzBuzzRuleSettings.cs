using JazzFuzz.Enums;

namespace JazzFuzz.RuleSettings;
public class FizzBuzzRuleSettings : IGameRuleSettings
{
    public IEnumerable<int> RuleRange => Enumerable.Range(1, 100);
    public IEnumerable<WordsEnum> RuleWords => new List<WordsEnum> { WordsEnum.Fizz, WordsEnum.Buzz };
}
