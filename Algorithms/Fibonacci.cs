using System;

namespace Algorithms
{
  /// <summary>
  /// The Fibonacci encapsulator class
  /// </summary>
  class Fibonacci
  {
    int _maxTerms;
    int _maxValue;

    /// <summary>
    /// Constructor accpeting max terms or max value till print series
    /// </summary>
    /// <param name="terms"></param>
    /// <param name="maxVal"></param>
    public Fibonacci(int terms, int maxVal)
    {
      _maxTerms = terms;
      _maxValue = maxVal;
    }

    /// <summary>
    /// Compute the Nth term of series
    /// </summary>
    /// <param term="n"></param>
    /// <returns></returns>
    public int Compute(int n)
    {
      return n <= 2 ? n : Compute(n - 1) + Compute(n - 2);
    }

    public int Factorial(int n)
    {
      return n <= 1 ? n : n * Factorial(n - 1);
    }

    /// <summary>
    /// Generate the fibonacci series till N terms
    /// </summary>
    public void GenerateNTerms()
    {
      for (int i = 1; i <= _maxTerms; i++)
      {
        Console.Write(Compute(i) + " ");
      }

    }

    /// <summary>
    /// Generates the fibonacci series till the value is less than given max value
    /// </summary>
    public void GenerateTillValue()
    {
      int x = 1;

      for (int i = 1; x <= _maxValue; i++)
      {
        x = Compute(i);

        if (x < _maxValue)
          Console.Write(x + " ");
      }

    }
  }
}
