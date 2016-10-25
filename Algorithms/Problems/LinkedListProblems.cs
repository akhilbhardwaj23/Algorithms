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

    public static Node FindNthNodeFromEnd(Node head, int n)
    {
      if (head == null)
        throw new ArgumentNullException();

      if (n <= 0)
        throw new ArgumentOutOfRangeException();

      var current = head;
      var runner = head;

      int i = 0;

      while(current.Next != null)
      {
        if( i >= n-1)
        {
          runner = runner.Next;
        }

        current = current.Next;
        i++;
      }
    
      return runner;
    }
  }
}
