using FizzBuzz;

var fizzBuzzRunner = new FizzBuzzRunner();

var results = fizzBuzzRunner.Initialize();

results.ToList().ForEach(x => Console.WriteLine(x));

Console.ReadKey();