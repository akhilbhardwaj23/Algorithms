using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DataStructures.Generics
{
  public class NodeList<T> : Collection<GenericNode<T>>
  {
    #region Public Constructors
    public NodeList() : base() { }

    public NodeList(int initialSize)
    {
      for (int i = 0; i < initialSize; i++)
      {
        base.Items.Add(default(GenericNode<T>));
      }
    }
    #endregion

    #region Public Methods
    public GenericNode<T> FindByValue(T value)
    {
      foreach(GenericNode<T> node in Items)
      {
        if (node.Data.Equals(value))
          return node;
      }

      return null;
    }
    #endregion
  }
}
