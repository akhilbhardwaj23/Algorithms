using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DataStructures
{
  public class StackStore
  {
    int _stackSize = 100;
    int[] _arr;
    private int[] _ptr = { 0, 0, 0 };

    public StackStore()
    {
      int[] _arr = new int[3*_stackSize];
    }

    public void Push(int stack, int val)
    {
      int index = stack*_stackSize + _ptr[stack - 1]  + 1;

      _arr[index] = val;
      _ptr[stack - 1]++;
    }

    public int Pop(int stack)
    {
      int index = stack * _stackSize + _ptr[stack - 1];
      _ptr[stack - 1]--;
      int val = _arr[index];
      _arr[index] = 0;
      return val;
    }

    public int Peek(int stack)
    {
      int top = _ptr[stack - 1];
      return _arr[top];
    }

  }
}
