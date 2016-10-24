using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
  class Random
  {
    public static void FizzBuzz()
    {
      for (int i = 1; i <= 100; i++)
      {
        var x = i % 15 == 0 ? "i =" + i.ToString() + " FizzBuzz" : (i % 3 == 0 ? "i =" + i.ToString() + " Fizz" : i % 5 == 0 ? "i =" + i.ToString() + " Buzz" : "");
        Console.WriteLine(x);
      }
    }
  }
}
