using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Algorithms.DataStructures;
using Algorithms.Problems;
using System.Collections.Generic;

namespace Tests
{
  [TestClass]
  public class StackTests
  {
    [TestMethod]
    public void TestDynamicStack()
    {
      var stack = CreateSack();

      Assert.AreEqual(6, stack.Peek(3));
      Assert.AreEqual(5, stack.Peek(2));
      Assert.AreEqual(4, stack.Pop(1));
    }

    [TestMethod]
    public void TestTowerOfHanoi()
    {
      var t = new TowerOfHanoi();
      var x = t.Tower1.Peek();
      //Assert.AreNotEqual(x, t.Tower3.Peek());
      t.Move();
      Assert.AreEqual(x, t.Tower3.Peek());
    }

    [TestMethod]
    public void TestSortStack()
    {
      Stack<int> s2 = new Stack<int>(10);

      s2.Push(5);

      s2.Push(6);

      s2.Push(1);

      s2.Push(7);

      s2.Push(9);
      s2.Push(10);
      s2.Push(2);
      s2.Push(3);
      s2.Push(4);
      s2.Push(8);

      StackAndQueue s1 = new StackAndQueue();
      s2 = s1.SortStack(s2);
      Assert.AreEqual(10, s2.Count);
      Assert.AreEqual(10, s2.Peek());
    }

    public DynamicStack CreateSack()
    {
      //limiting total stacks to 3;
      var stack = new DynamicStack();

      //push some elements to each stacks
      stack.Push(1, 1);
      stack.Push(2, 2);
      stack.Push(3, 3);

      stack.Push(1, 10);
      stack.Push(2, 2);
      stack.Push(3, 3);

      stack.Push(1, 1);
      stack.Push(2, 2);
      stack.Push(3, 3);

      //4,5,6 are at the top
      stack.Push(1, 4);
      stack.Push(2, 5);
      stack.Push(3, 6);
      return stack;
    }
  }
}
