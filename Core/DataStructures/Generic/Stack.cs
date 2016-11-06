using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Algorithms.DataStructures.Generic
{
  public class Stack<T>
  {
    int _currIndex = 0;
    T[] _arr;

    public Stack(int n)
    {
      _arr = new T[n];
    }

    public void Push(T val)
    {
      if (_currIndex == _arr.Length)
      {
        Array.Resize(ref _arr, _arr.Length * 2);
      }
      _arr[_currIndex] = val;
      _currIndex++;

    }

    public T Pop()
    {
      if(_currIndex == 0)
      {
        throw new InvalidOperationException();
      }

      _currIndex--;
      T val = _arr[_currIndex];
      _arr[_currIndex] = default(T);
      return val;
    }

  }
}
