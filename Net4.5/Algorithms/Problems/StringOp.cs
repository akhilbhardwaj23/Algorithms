using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
  public static class StringOp
  {
    public static bool AllUniques(this string str)
    {
      var x = new HashSet<char>();

      foreach (char s in str.ToCharArray())
      {
        if (x.Contains(s))
        {
          return false;
        }
        else
          x.Add(s);
      }

      return true;
    }
    public static bool IsUniqueCharSet(this string str)
    {
      //Considering only ASCII char set
      bool[] char_set = new bool[256];

      foreach (char c in str)
      {
        if (char_set[c])
        {
          return false;
        }

        char_set[c] = true;
      }

      return true;
    }
    public static string RemoveDuplicateChars(this string str)
    {



      return string.Empty;
    }
    public static void AreAnagrams(string str1, string str2)
    {
      if (str1.Length != str2.Length) return;

      for(int i=0; i< str1.Length; i++)
      {
        if (str1[i] != str2[str2.Length - 1 - i])
        {
          Console.Write( "Not anagrams");
          return;
        }
      }

      Console.Write("Anagrams !");
    }
    public static void removeDuplicates(this char[] str)
    {
      if (str == null) return;
      int len = str.Length;

      if (len < 2) return;
      int tail = 1;

      for (int i = 1; i < len; ++i)
      {
        int j;
        for (j = 0; j < tail; ++j)
        {
          if (str[i] == str[j]) break;
        }

        if (j == tail)
        {
          str[tail] = str[i];
          ++tail;
        }
      }
      str[tail] = '0';

      foreach(char c in str)
      {
        Console.Write(c);
      }

    }

    //This will be a o(n*n) algorithm due the additional step of creating another string by copying the contents 
    //of previous string
    public static string ReverseString(this string str)
    {
      string s = "";
      for (int i = str.Length - 1; i >= 0; i--)
      {
        s += str[i];
      }
      return s;
    }
    public static string ReverseUsingCharArray(this string s)
    {
      char[] str = new char[s.Length];

      int currIndex = 0;
      foreach (char c in s)
      {
        str[s.Length - 1 - currIndex] = c;
        currIndex++;
      }

      return new string(str);
    }

    //To check if a string is rotation of another string
  }
}
