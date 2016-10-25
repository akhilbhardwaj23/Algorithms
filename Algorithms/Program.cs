using System;
using Algorithms.Tests;

namespace Algorithms
{
  class Program
  {
    static void Main(string[] args)
    {
      LinkedListTests test = new LinkedListTests();
      test.Simulate();

      Console.Read();
    }
  }
}
