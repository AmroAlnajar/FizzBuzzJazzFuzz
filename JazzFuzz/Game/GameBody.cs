using JazzFuzz.Rules;
using JazzFuzz.RuleSettings;

namespace JazzFuzz.Game;

public class GameBody : IGameBody
{
    private readonly IGameRuleSettings _ruleSettings;

    private readonly IEnumerable<int> rangeToRunOn;

    public GameBody(IGameRuleSettings ruleSettings)
    {
        _ruleSettings = ruleSettings;
        rangeToRunOn = _ruleSettings.GetRuleSettings().RuleRange;
    }

    public void RunGame()
    { 
        GetWordsForAllNumbers()
            .ToList()
            .ForEach(x => Console.WriteLine(x));

        Console.ReadKey();
    }

    public IEnumerable<string> GetWordsForAllNumbers()
    {
        return rangeToRunOn.Select(x => RunOnSingleNumber(x));
    }

    public string RunOnSingleNumber(int number)
    {
        var correspondingWord = string.Empty;

        var gameRules = _ruleSettings.GetRuleSettings().RuleWords.Select(x => new GameRules(x));

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