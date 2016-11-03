using System;
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

    [TestMethod]
    public void TestDeleteNode()
    {
      var list = BuildLinkedList();

      var nodeTobeDeleted = list.Next.Next.Next; //the node with value 4

      Assert.AreEqual(2, list.Next.Next.Data);
      Assert.AreEqual(3, list.Next.Next.Next.Data);

      LinkedListProblems.DeleteNode(nodeTobeDeleted);

      Assert.AreEqual(2, list.Next.Next.Data);
      Assert.AreEqual(4, list.Next.Next.Next.Data);
    }

    [TestMethod]
    public void TestCycleStartNode()
    {
      var list = BuildLinkedList();

      var curr = list;
      var start = list;

      //Find the last node
      while (curr.Next != null)
      {
        curr = curr.Next;
      }

      //Find an arbitary node
      for (int i = 0; i < 9; i++)
      {
        start = start.Next;
        if (start.Data == 5)
          break;
      }

      // Create a cycle
      curr.Next = start;

      var node = LinkedListProblems.FindStartNodeOfCircularList(list);
      Assert.AreEqual(start.Data, node.Data);
    }

    [TestMethod]
    public void TestNoCycle()
    {
      var list = BuildLinkedList();
      var node = LinkedListProblems.FindStartNodeOfCircularList(list);
      Assert.AreEqual(null, node);
    }

    [TestMethod]
    public void TestListSum()
    {
      var list1 = new Node(9).Append(9).Append(9);
      var list2 = new Node(9).Append(9).Append(9);

      var sum = new Node(8).Append(9).Append(9).Append(1);
      var calcsum = LinkedListProblems.ListSum(list1, list2, 0);
      Assert.AreEqual(0, calcsum.CompareTo(sum));
    }

    [TestMethod]

    public void TestSeggregateOddEven()
    {
      var list = new Node(5).Append(1).Append(2).Append(3).Append(4).Append(6);
      var list1 = new Node(2).Append(4).Append(6).Append(5).Append(1).Append(3);
      var list2 = LinkedListProblems.SeggregateOddEven(list);
      Assert.AreEqual(0, list1.CompareTo(list2));
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
