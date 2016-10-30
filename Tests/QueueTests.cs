using System;
using Algorithms.DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  [TestClass]
  public class QueueTests
  {
    [TestMethod]
    public void TestQueueOfStacks()
    {
      QueueOfStacks q = new QueueOfStacks();
      q.Enqueue(1);
      q.Enqueue(2);
      q.Enqueue(3);
      q.Enqueue(4);
      q.Enqueue(5);

      Assert.AreEqual(1, q.Dequeue());

    }
  }
}
