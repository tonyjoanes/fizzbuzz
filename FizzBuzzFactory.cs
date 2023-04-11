using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzFactory : IFizzBuzzFactory
    {
        public IFizzBuzz Create()
        {
            return new FizzBuzzLogic();
        }
    }
}
