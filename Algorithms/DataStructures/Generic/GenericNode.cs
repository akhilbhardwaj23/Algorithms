using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DataStructures.Generics
{
  public class GenericNode<T> : IComparable<T>
  {
    #region Private Members
    private T _data;
    private NodeList<T> _neighbors = null;
    #endregion

    #region Public Constructors
    public GenericNode() { }
    public GenericNode(T data) : this(data, null) { }
    public GenericNode(T data, NodeList<T> neighbors)
    {
      this._data = data;
      this._neighbors = neighbors;
    }

    #endregion
    #region Public Properties
    public T Data
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

    public int CompareTo(T t)
    {
      var comparer = Comparer<T>.Default;

      if (t.GetType() != GetType())
        return -1;

      return comparer.Compare(this._data, t);
    }
  }
}
