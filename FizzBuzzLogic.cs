using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzLogic : IFizzBuzz
    {
        public FizzBuzzResult Calculate(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return new FizzBuzz();
            }
            if (number % 3 == 0)
            {
                return new Fizz();
            }
            if (number % 5 == 0)
            {
                return new Buzz();
            }
            return new Number(number);
        }
    }
}
