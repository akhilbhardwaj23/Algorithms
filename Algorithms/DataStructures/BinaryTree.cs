using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DataStructures
{
  public class BinaryTree
  {
    public TreeNode root;

    public BinaryTree(int val)
    {
      root = new TreeNode();
      root.value = val;
    }
  }

  public class TreeNode
  {
    public TreeNode leftNode;
    public TreeNode rightNode;

    public int value;
  }
}
