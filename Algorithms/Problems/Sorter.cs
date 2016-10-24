using System;

namespace Algorithms
{
  /// <summary>
  /// Utiltiy class for all the sorting algorithm
  /// </summary>
  public class Sorter<T> where T : IComparable
  {
    /// <summary>
    /// Generic insertion sort
    /// </summary>
    /// <param name="vals"></param>
    /// <returns></returns>
    public T[] InsertionSort(T[] vals)
    {
      for (int i = 1; i < vals.Length; i++)
      {
        T temp;

        for (int j = i; j > 0; j--)
        {
          if (vals[j].CompareTo(vals[j - 1]) < 0)
          {
            temp = vals[j - 1];
            vals[j - 1] = vals[j];
            vals[j] = temp;
          }
          else
            break;
        }
      }
      return vals;
    }

    /// <summary>
    /// Insertion sort of integers
    /// </summary>
    /// <param name="vals"></param>
    /// <returns></returns>
    public int[] InsertionSort(Int32[] vals)
    {
      for (int i = 1; i < vals.Length; i++)
      {
        int temp = 0;
        for (int j = i; j > 0; j--)
        {
          if (vals[j] < vals[j - 1])
          {
            temp = vals[j - 1];
            vals[j - 1] = vals[j];
            vals[j] = temp;
          }
          else
            break;
        }
      }
      return vals;
    }

    /// <summary>
    /// Merge sort
    /// </summary>
    /// <param name="vals"></param>
    /// <returns></returns>
    public int[] MergeSort(Int32[] vals)
    {
      if (vals.Length == 1)
      {
        return vals;
      }
      else
      {
        int n = (int)Math.Floor(vals.Length / 2.0);

        int[] n1 = new int[n];
        int[] n2 = new int[vals.Length - n];

        int ii = 0;
        int jj = 0;

        for (int i = 0; i < vals.Length; i++)
        {
          if (i < n)
          {
            n1[ii++] = vals[i];
          }
          else
          {
            n2[jj++] = vals[i];
          }

        }

        n1 = MergeSort(n1);
        n2 = MergeSort(n2);

        return Merge(n1, n2);
      }
    }
    public int[] Merge(int[] val1, int[] val2)
    {
      int[] n = new int[val1.Length + val2.Length];

      int i = 0; int j = 0; int k = 0;
      while (i < val1.Length || j < val2.Length)
      {
        if (i >= val1.Length)
        {
          n[k] = val2[j];
          j++;
          k++;
          continue;
        }
        if (j >= val2.Length)
        {
          n[k] = val1[i];
          i++;
          k++;
          continue;
        }

        if (val1[i] < val2[j])
        {
          n[k] = val1[i];
          i++;
        }
        else
        {
          n[k] = val2[j];
          j++;
        }
        k++;
      }

      return n;
    }
  }
}
