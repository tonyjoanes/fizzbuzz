using FizzBuzz;

IFizzBuzzFactory factory = new FizzBuzzFactory();
FizzBuzzDependencyInjection fizzBuzz = new FizzBuzzDependencyInjection(factory);

fizzBuzz.RunFizzBuzz(100);

Console.ReadKey();