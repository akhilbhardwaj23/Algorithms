namespace Algorithms.DataStructures.Generic
{
  public class BinaryTreeNode<T> : Node<T>
  {
    public BinaryTreeNode() : base() { }
    public BinaryTreeNode(T data) : base(data, null) { }
    public BinaryTreeNode(T data, BinaryTreeNode<T> left, BinaryTreeNode<T> right)
    {
      base.Value = data;
      NodeList<T> children = new NodeList<T>();
      children[0] = left;
      children[1] = right;

      base.Neighbours = children;
    }

    public BinaryTreeNode<T> Left
    {
      get {
        if(base.Neighbours == null)
        {
          return null;
        }
        else
        {
          return (BinaryTreeNode<T>) base.Neighbours[0];
        }
      }
    }

    public BinaryTreeNode<T> Right
    {
      get
      {
        if (base.Neighbours == null)
        {
          return null;
        }
        else
        {
          return (BinaryTreeNode<T>)base.Neighbours[1];
        }
      }
    }
  }
}
