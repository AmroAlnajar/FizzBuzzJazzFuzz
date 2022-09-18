namespace FizzBuzz;

public class FizzBuzzRunner
{
    public IEnumerable<string> Initialize()
    {
        var numbers = Enumerable.Range(1, 100);

        foreach (var number in numbers)
            yield return AnalyzeSingleNumber(number);
    }

    public string AnalyzeSingleNumber(int number)
    {
        var result = string.Empty;

        if (number % 3 == 0)
            result += "Fizz";
        if (number % 5 == 0)
            result += "Buzz";

        return result.Equals(string.Empty) ? number.ToString() : result;
    }
}