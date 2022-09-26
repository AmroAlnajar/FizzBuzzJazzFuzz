using JazzFuzz.Rules;
using JazzFuzz.RuleSettings;

namespace JazzFuzz.Game;

public class GameLogic : IGameLogic
{
    private readonly IGameRuleSettings _ruleSettings;

    private readonly IEnumerable<int> rangeToRunOn;

    public GameLogic(IGameRuleSettings ruleSettings)
    {
        _ruleSettings = ruleSettings;
        rangeToRunOn = _ruleSettings.RuleRange;
    }

    public IEnumerable<string> GetWordsForAllNumbers()
    {
        return rangeToRunOn.Select(x => RunOnSingleNumber(x));
    }

    public string RunOnSingleNumber(int number)
    {
        var correspondingWord = string.Empty;

        var gameRules = _ruleSettings.RuleWords.Select(x => new GameRules(x));

        foreach (var rule in gameRules)
        {
            correspondingWord += rule.Initialize(number);
        }
        if (correspondingWord == string.Empty)
        {
            correspondingWord += number.ToString();
        }

        return correspondingWord;
    }
}