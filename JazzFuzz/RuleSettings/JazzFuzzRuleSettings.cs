using JazzFuzz.Enums;

namespace JazzFuzz.RuleSettings;

public class JazzFuzzRuleSettings : IGameRuleSettings
{
    public IEnumerable<int> RuleRange => Enumerable.Range(1, 100).Reverse();
    public IEnumerable<WordsEnum> RuleWords => new List<WordsEnum> { WordsEnum.Jazz, WordsEnum.Fuzz };
}
