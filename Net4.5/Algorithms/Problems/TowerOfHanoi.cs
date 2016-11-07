using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems
{
  public class TowerOfHanoi
  {
    public Stack<string> Tower1 { get; set; }
    public Stack<string> Tower2 { get; set; }
    public Stack<string> Tower3 { get; set; }
    public TowerOfHanoi()
    {
      Tower1 = new Stack<string>();
      Tower2 = new Stack<string>();
      Tower3 = new Stack<string>();

      Tower1.Push("Disk1");
      Tower1.Push("Disk2");
      Tower1.Push("Disk3");
      Tower1.Push("Disk4");
      Tower1.Push("Disk5");
      Tower1.Push("Disk6");
      Tower1.Push("Disk7");
    }

    public void Move()
    {
      Move(Tower1, Tower2, Tower3, Tower1.Count);
    }
    public void Move(Stack<string> source, Stack<string> intermediate, Stack<string> target, int n)
    {
      if (n > 0)
      {
        Move(source, target,intermediate, n - 1);
        MoveTop(source, target);
        Move(intermediate, source, target, n-1);
      }
    }

    public void MoveTop(Stack<string> source, Stack<string> target)
    {
      target.Push(source.Pop());

      //if (target.Count == 0)
      //{
      //  target.Push(source.Pop());
      //}
      //else
      //{
      //  if (source.Peek() > target.Peek())
      //    throw new Exception();
      //}
    }
  }
}
