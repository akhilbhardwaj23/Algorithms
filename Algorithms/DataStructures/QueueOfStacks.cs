using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DataStructures
{
  public class QueueOfStacks
  {
    private Stack<int> _stack1;
    private Stack<int> _stack2;

    public QueueOfStacks()
    {
      _stack1 = new Stack<int>();
      _stack2 = new Stack<int>();
    }

    public void Enqueue(int val)
    {
      _stack1.Push(val);
    }

    public int Dequeue()
    {
      if(_stack2.Count == 0)
      {
        while(_stack1.Count > 0)
        {
          _stack2.Push(_stack1.Pop());
        }
      }

      return _stack2.Pop();
    }


  }
}
