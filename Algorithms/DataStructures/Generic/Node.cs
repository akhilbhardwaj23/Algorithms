using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DataStructures
{
  public class Node<T>
  {
    #region Private Members
    private T _data;
    private NodeList<T> _neighbors = null;
    #endregion

    #region Public Constructors
    public Node() {}
    public Node(T data) : this(data, null) { }
    public Node(T data, NodeList<T> neighbors)
    {
      this._data = data;
      this._neighbors = neighbors;
    }

    #endregion
    #region Public Properties
    public T Value
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
    #endregion

  }
}
