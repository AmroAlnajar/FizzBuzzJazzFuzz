using JazzFuzz.Enums;

namespace JazzFuzz.Rules;
public class GameRules : IGameRules
{
    private readonly WordsEnum word;
    public GameRules(WordsEnum word)
    {
        this.word = word;
    }

    public string Initialize(int number)
    {
        if (number % (int)word == 0)
            return word.ToString();

        return string.Empty;
    }
}