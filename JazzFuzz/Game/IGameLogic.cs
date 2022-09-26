namespace JazzFuzz.Game;

public interface IGameLogic
{
    string RunOnSingleNumber(int number);
    IEnumerable<string> GetWordsForAllNumbers();
}
