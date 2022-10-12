using JazzFuzz.Game;
using JazzFuzz.RuleSettings;

var allGames = new List<GameLogic> { 
    new GameLogic(new FizzBuzzRuleSettings()), 
    new GameLogic(new JazzFuzzRuleSettings())
};

allGames.ForEach(
    x => x.GetWordsForAllNumbers()
    .ToList()
    .ForEach(c => 
    Console.WriteLine(c)));

Console.ReadLine();