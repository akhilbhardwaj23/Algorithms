using System;
using Algorithms.DataStructures;

namespace Algorithms.Tests
{
  class LinkedListTests
  {
    public Node BuildLinkedList()
    {
      Node head = new Node(0);
      Node prev = head;

      for (int i = 1; i < 10; i++)
      {
        Node item = new Node(i);
        prev.Next = item;

        //Move to the next item
        prev = item;
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
