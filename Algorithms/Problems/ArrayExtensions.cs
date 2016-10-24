using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
  public static class ArrayExtensions
  {
    public static void PrintArray(this int[] arr)
    {
      for (int k = 0; k < arr.Length; k++)
      {
        Console.Write(arr[k]);
      }
      Console.WriteLine("");
      Console.WriteLine("-----");
    }
  }
}
