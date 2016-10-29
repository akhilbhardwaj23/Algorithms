using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DataStructures
{
  public class Queue
  {
    private Node first, last;
    private int _size;
    public int Size
    {
      get
      { return _size; }
      set
      {
        value = _size;
      }
    }

    public bool IsEmpty()
    {
      return first == null;
    }
    public void Enqueue(int val)
    {
      Node item = new Node(val);
      var oldLast = last;
      last = item;

      if (IsEmpty())
      {
        first = last = item;
      }
      else
      {
        oldLast.Next = last;
      }
      _size++;
    }

    public int Dequeue()
    {
      if (IsEmpty())
        throw new IndexOutOfRangeException();

      int val = first.Data;
      first = first.Next;

      _size--;
      return val;
    }
  }
}
