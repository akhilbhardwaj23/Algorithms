using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DataStructures
{
  public class StackListImpl
  {
    private Node top;
    public int Pop()
    {
      if(top == null)
      {
        throw new IndexOutOfRangeException();
      }

      Node item = top;
      top = top.Next;
      return item.Data;
    }

    public void Push(int t)
    {
      Node item = new Node(t);
      item.Next = top;
      top = item;
    }
  }
}
