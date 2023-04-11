using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public abstract record FizzBuzzResult;

    public record Fizz : FizzBuzzResult;

    public record Buzz : FizzBuzzResult;

    public record FizzBuzz : FizzBuzzResult;

    public record Number(int Value) : FizzBuzzResult;

}
