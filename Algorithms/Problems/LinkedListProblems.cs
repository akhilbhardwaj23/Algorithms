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

      if (curr == null)
        return null;

      bool[] items = new bool[head.Count()];

      while (curr.Next != null)
      {
        // Have been found before
        if (items[curr.Data])
        {
          //This will delete the first occurance of the duplicate node
          head.DeleteNode(head, curr.Data);
        }

        items[curr.Data] = true;
        curr = curr.Next;
      }

      //Do this again for last item
      if (curr.Next == null && items[curr.Data])
      {
        //This will delete the first occurance of the duplicate node
        head.DeleteNode(head, curr.Data);
      }


      return head;
    }
  }
}
