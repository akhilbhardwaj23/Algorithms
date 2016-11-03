using System.Collections;
using System.Collections.Generic;

namespace Algorithms.Problems
{
  public class StackAndQueue
  {
    Stack<int> s2 = new Stack<int>(10);
    public Stack<int> SortStack(Stack<int> s1)
    {
      //Assuming s1 is of max size 10, can be made dynamic as well
      if (s1.Count == 0)
        return s2;

      if (s2.Count == 0)
      {
        s2.Push(s1.Pop());
      }
      else
      {
        var temp = s1.Pop();
        while(s2.Count > 0 && temp < s2.Peek())
        {
          s1.Push(s2.Pop());
        }
        s2.Push(temp);
      }

      SortStack(s1);
      return s2;
    }

    public bool AreParenthesisBalanced(string str)
    {
      Stack<char> stack = new Stack<char>();

      char[] c = str.ToCharArray();

      Dictionary<char, int> h = new Dictionary<char, int>();

      h.Add('[', 1);
      h.Add('{', 2);
      h.Add('(', 3);

      Dictionary<char, int> j = new Dictionary<char, int>();
      j.Add('[', ']');
      j.Add('{', '}');
      j.Add('(', ')');

      for (int i= 0; i < c.Length; i++)
      {
        if(c[i] == '[' || c[i] == '{' || c[i] == '(')
        {
          if (stack.Count > 0)
          {
            if (h[stack.Peek()] > h[c[i]])
            {
              //incorrect order
              return false;
            }
          }

          stack.Push(c[i]);
        }
        if (c[i] == ']' || c[i] == '}' || c[i] == ')')
        {
          if (j[stack.Peek()] == c[i])
          {
            stack.Pop();
          }
          else
          {
            return false;
          }
        }
      }

      return stack.Count == 0;
    }
  }
}
