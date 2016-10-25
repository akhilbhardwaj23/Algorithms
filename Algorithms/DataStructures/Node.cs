﻿using System;

namespace Algorithms.DataStructures
{

  /// <summary>
  /// This is a specific node class represents a linked lists
  /// The generic version should be used to create trees and other data sturctures
  /// </summary>
  public class Node
  {
    Node _next = null;
    int _data;

    //Todo: Ideally, this should start with zero and constructor should be private
    //would come back to this later.
    int _size = 1;

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

    public int Size
    {
      get
      {
        return _size;
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
        _size++;
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

      while (curr.Next != null)
      {
        if (curr.Next.Data == val)
        {
          curr.Next = curr.Next.Next;
        }

        curr = curr.Next;
      }

      return head;
    }
  }
}
