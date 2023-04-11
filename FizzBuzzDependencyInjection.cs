using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzDependencyInjection
    {
        private readonly IFizzBuzzFactory _factory;

        public FizzBuzzDependencyInjection(IFizzBuzzFactory factory)
        {
            _factory = factory;
        }

        public void RunFizzBuzz(int maxNumber)
        {
            IFizzBuzz fizzBuzz = _factory.Create();

            for (int i = 1; i <= maxNumber; i++)
            {
                FizzBuzzResult result = fizzBuzz.Calculate(i);
                Console.WriteLine(result switch
                {
                    FizzBuzz => "FizzBuzz",
                    Fizz => "Fizz",
                    Buzz => "Buzz",
                    Number n => n.Value.ToString(),
                    _ => throw new InvalidOperationException("Invalid FizzBuzzResult")
                });
            }
        }
    }
}
