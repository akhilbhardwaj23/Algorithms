using System;
using Algorithms.DataStructures;

namespace Algorithms.Tests
{
  class LinkedListTests
  {
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
