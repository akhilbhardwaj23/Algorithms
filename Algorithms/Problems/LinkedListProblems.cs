using System;
using Algorithms.DataStructures;

namespace Algorithms.Problems
{
  /// <summary>
  /// Class with a set of Linked list problems
  /// </summary>
  public class LinkedListProblems
  {
    /// <summary>
    /// Remove duplicates from an unsorted linked list
    /// </summary>
    /// <param name="head"></param>
    public static Node RemoveDuplicates(Node head)
    {
      var curr = head;
      var prev = head;

      if (curr == null)
        return null;

      bool[] items = new bool[head.Count()];

      while (curr.Next != null)
      {
        // Have been found before
        if (items[curr.Data])
        {
          //This will delete the current node
          prev.Next = curr.Next;
        }
        else
        {
          items[curr.Data] = true;
          prev = curr;
        }
        curr = curr.Next;
      }

      //Do this again for last item
      if (curr.Next == null && items[curr.Data])
      {
        //This will delete the first occurance of the duplicate node
        prev.Next = null;
      }

      return head;
    }

    /// <summary>
    /// removes all duplicates without using any extra buffer
    /// </summary>
    /// <param name="head"></param>
    /// <returns></returns>
    public static Node RemoveDuplicatesWithoutBuffer(Node head)
    {
      var current = head;
      var previous = head;

      if (current == null)
        return null;

      while (current.Next != null)
      {
        var runner = head;

        while (runner != current)
        {
          if (runner.Data == current.Data)
          {
            var temp = current.Next;
            previous.Next = temp;
            current = temp;
            break;
          }

          runner = runner.Next;
        }

        if (runner == current)
        {
          previous = current;
          current = current.Next;
        }
      }

      return head;
    }

    /// <summary>
    /// Finds the nth node from end of the list
    /// </summary>
    /// <param name="head"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public static Node FindNthNodeFromEnd(Node head, int n)
    {
      if (head == null)
        throw new ArgumentNullException();

      if (n <= 0)
        throw new ArgumentOutOfRangeException();

      var current = head;
      var runner = head;

      int i = 0;

      while (current.Next != null)
      {
        if (i >= n - 1)
        {
          runner = runner.Next;
        }

        current = current.Next;
        i++;
      }

      return runner;
    }

    /// <summary>
    /// Deletes the input node
    /// </summary>
    /// <param name="n"></param>
    public static void DeleteNode(Node n)
    {
      if (n == null || n.Next == null)
        throw new ArgumentOutOfRangeException();

      n.Data = n.Next.Data;
      n.Next = n.Next.Next;
    }

    /// <summary>
    /// FInd the sum of two numbers represented as lists
    /// </summary>
    /// <param name="node1"></param>
    /// <param name="node2"></param>
    /// <param name="carry"></param>
    /// <returns></returns>
    public static Node ListSum(Node node1, Node node2, int carry)
    {
      if (node1 == null && node2 == null)
      {
        if (carry > 0)
        {
          new Node(carry);
        }

        return null;
      }

      var sum = new Node();

      int val = carry;
      int x1 = node1 != null ? node1.Data : 0;
      int x2 = node2 != null ? node2.Data : 0;

      sum.Data = (carry + x1 + x2) % 10 ;
      carry = (carry + x1 + x2 >= 10) ? 1 : 0;

      sum.Next = (ListSum(node1.Next, node2.Next, carry));

      return sum;
    }

    /// <summary>
    /// find the start of a cycle in circular linked list
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public static Node FindStartNodeOfCircularList(Node n)
    {
      if (n.Next == null)
      {
        return null;
      }

      //circular list with just one node
      if (n.Next == n)
      {
        return n;
      }

      var r = n;
      var h = n;

      while (h.Next != null)
      {
        if (h.Next.Next == null)
        {
          return null; //No cycle
        }

        r = r.Next;
        h = h.Next.Next;

        if (r == h)
          break;
      }

      if (h.Next == null)
        return null; // No cycle

      //if we are here then r and h have met and we have a circular linked list
      //Now reset r to head and move them together, they will meet at start of 
      //the cylce

      r = n;
      while (r != h)
      {
        r = r.Next;
        h = h.Next;
      }

      return r;
    }
  }
}
