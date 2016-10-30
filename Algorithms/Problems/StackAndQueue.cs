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
  }
}
