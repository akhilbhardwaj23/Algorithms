using System;

namespace Algorithms.DataStructures
{

  /// <summary>
  /// This is a specific node class represents a linked lists
  /// The generic version should be used to create trees and other data sturctures
  /// </summary>
  public class Node : IComparable<Node>
  {
    Node _next = null;
    int _data;

    /// <summary>
    /// Default constructor
    /// </summary>
    public Node() { }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="val"></param>
    public Node(int val)
    {
      this._data = val;
    }

    public Node Next
    {
      get
      {
        return _next;
      }
      set
      {
        _next = value;
      }
    }

    public int Data
    {
      get
      {
        return _data;
      }
      set
      {
        _data = value;
      }
    }


    /// <summary>
    /// Appends a node to the list
    /// </summary>
    /// <param name="d"></param>
    public void AppendToTail(int d)
    {
      Node end = new Node(d);
      Node n = this;
      while (n.Next != null)
      {
        n = n.Next;
      }

      n.Next = end;
    }

    /// <summary>
    /// Deletes a node from the list
    /// </summary>
    /// <param name="head"></param>
    /// <param name="val"></param>
    public Node DeleteNode(Node head, int val)
    {
      Node curr = head;

      if (head.Data == val)
      {
        return head.Next;
      }

      while (curr != null && curr.Next != null)
      {
        if (curr.Next.Data == val)
        {
          curr.Next = curr.Next.Next;
        }

        curr = curr.Next;
      }

      return head;
    }

    public int Count()
    {
      int size = 0;
      Node curr = this;
      while (curr.Next != null)
      {
        size++;
        curr = curr.Next;
      }

      return size;
    }

    public int CompareTo(Node n2)
    {
      int retVal = 0;
      var curr = this;

      bool equal = true;

      if (curr.Next == null && n2.Next == null)
      {
        return retVal = (curr.Data == n2.Data) ? 0 : 1;
      }

      if (curr.Next == null && n2.Next != null)
      {
        return 1; //Not equal
      }

      if (curr.Next != null && n2.Next == null)
      {
        return 1; //Not equal
      }

      while (curr.Next != null)
      {
        if (curr.Data != n2.Data)
        {
          retVal = 1;
          break;
        }
        curr = curr.Next;
        n2 = n2.Next;
      }

      if (this.Next != null && curr.Next != null)
      {
        return 1;
      }

      return retVal;
    }
  }
}
