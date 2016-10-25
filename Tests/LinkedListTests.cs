using System;
using Algorithms;
using Algorithms.DataStructures;
using Algorithms.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  /// <summary>
  /// Class for testing the linked list problems
  /// </summary>
  [TestClass]
  public class LinkedListTests
  {
    [TestMethod]
    public void TestListEquality()
    {
      var list1 = BuildLinkedList();
      var list2 = BuildLinkedList();

      Assert.AreEqual(0, list1.CompareTo(list2));
    }

    [TestMethod]
    public void TestRemoveDuplicates()
    {
      var list1 = BuildLinkedList();
      var list2 = BuildLinkedList();

      list2.AppendToTail(1);
      list2.AppendToTail(2);

      list2 = LinkedListProblems.RemoveDuplicates(list2);

      Assert.AreEqual(0, list1.CompareTo(list2));
    }

    [TestMethod]
    public void TestRemoveDuplicatesWithoutBuffer()
    {
      var list1 = BuildLinkedList();
      var list2 = BuildLinkedList();

      list2.AppendToTail(1);
      list2.AppendToTail(2);

      list2 = LinkedListProblems.RemoveDuplicatesWithoutBuffer(list2);

      Assert.AreEqual(0, list1.CompareTo(list2));
    }

    [TestMethod]
    public void TestFindNthNodeFromEnd()
    {
      var list1 = BuildLinkedList();
      var val = LinkedListProblems.FindNthNodeFromEnd(list1, 2).Data;
      Assert.AreEqual(8, val);

    }
    public Node BuildLinkedList()
    {
      Node head = new Node(0);

      for (int i = 1; i < 10; i++)
      {
        head.AppendToTail(i);
      }
      return head;
    }

    public void PrintList(Node head)
    {
      if (head == null)
      {
        Console.WriteLine("Empty List");
        return;
      }

      var curr = head;
      while (curr != null)
      {
        Console.Write(curr.Data.ToString() + " ");
        curr = curr.Next;
      }

    }

    public void Simulate()
    {
      var list = BuildLinkedList();
      PrintList(list);
    }
  }
}
