using System;

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DataStructures
{
  public class DynamicStack
  {
    public int _size = 100;
    private StackNode[] _arr;
    int[] ptrs = { -1, -1, -1 };
    int lastIndex = 0;

    public DynamicStack()
    {
      _arr = new StackNode[3 * _size];
    }

    public bool IsEmpty(int stackNum)
    {
      return ptrs[stackNum -1] < 0;
    }

    public void Push(int stackNum, int val)
    {
      var n = new StackNode(val);
      int index = ptrs[stackNum - 1];
      n.prev = index;
      index = lastIndex++;
      ptrs[stackNum - 1] = index;
      _arr[index] = n;
    }

    public int Pop(int stackNum)
    {
      if (IsEmpty(stackNum))
        throw new IndexOutOfRangeException();

      int top = ptrs[stackNum - 1];
      StackNode n = _arr[top];
      ptrs[stackNum - 1] = n.prev;
      _arr[top] = null;

      return n.data;
    }

    public int Peek(int stackNum)
    {
      if (IsEmpty(stackNum))
        throw new IndexOutOfRangeException();

      return _arr[ptrs[stackNum - 1]].data;
    }
    //Nested class for stack node, contains a pointer to the previous node
    class StackNode
    {
      public int prev = -1;
      public int data;

      public StackNode(int val)
      {
        data = val;
      }
    }
  }
}
