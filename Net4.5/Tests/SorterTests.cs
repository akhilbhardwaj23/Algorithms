using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;

namespace Tests
{
  [TestClass]
  public class SorterTests
  {
    [TestMethod]
    public void TestMergeArrays()
    {
      var sort = new Sorter<int>();
      int[] a1 = { 2, 4, 6, 8, 9, -1, -1, -1, -1 };
      int[] a2 = { 1, 3, 5, 7 };

      //int[] x = sort.MergeBtoA(a1, a2);
      int[] x = sort.MergeBackwards(a1, a2);
      Assert.AreEqual(9, x[x.Length -1]);
    }
  }
}
