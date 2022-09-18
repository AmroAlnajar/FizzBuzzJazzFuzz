using JazzFuzz.RuleSettings;

namespace JazzFuzz.Game;

public class GameRunner : IGameRunner
{
    public void Run()
    {
        new GameBody(new FizzBuzzRuleSettings()).RunGame();
        new GameBody(new JazzFuzzRuleSettings()).RunGame();
    }

}
