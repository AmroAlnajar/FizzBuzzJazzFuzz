using JazzFuzz.Enums;

namespace JazzFuzz.RuleSettings;

public interface IGameRuleSettings
{
    public IEnumerable<int> RuleRange { get; }
    public IEnumerable<WordsEnum> RuleWords { get;  }
}

