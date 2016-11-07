using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
  /// <summary>
  /// A class to work with 2D Matrix
  /// </summary>
  class Matrix
  {
    /// <summary>
    /// A 2D matrix
    /// </summary>
    /// <param name="m"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public static int[,] Build2dMatrix(int m, int n)
    {
      int[,] image = new int[m, n];

      for (int i = 0; i < m; i++)
      {
        for (int j = 0; j < n; j++)
        {
          image[i, j] = i * 2 + j;
        }
      }

      return image;
    }

    /// <summary>
    ///  A jagged 2D matrix, performs better in .net clr
    /// </summary>
    /// <param name="m"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public static int[][] Build2dMatrix2(int m, int n)
    {
      int[][] image = new int[m][];

      for (int i = 0; i < m; i++)
      {
        image[i] = new int[n];
        for (int j = 0; j < n; j++)
        {
          image[i][j] = i * 2 + j;
        }
      }

      return image;
    }

    /// <summary>
    /// prints the 2d matrix
    /// </summary>
    /// <param name="image"></param>
    public static void PrintMatrix(int[,] image)
    {
      for (int i = 0; i < image.GetLength(0); i++)
      {
        for (int j = 0; j < image.GetLength(1); j++)
        {
          int x = image[i, j].ToString().Length;
          string s = x == 2 ? " " : "  ";
          Console.Write(image[i, j] + s);
        }

        Console.WriteLine();
      }

    }

    /// <summary>
    /// prints a jagged 2d matrix
    /// </summary>
    /// <param name="image"></param>
    /// <param name="size"></param>
    public static void PrintMatrix2(int[][] image, int size)
    {
      for (int i = 0; i < 5; i++)
      {
        for (int j = 0; j < 5; j++)
        {
          int x = image[i][j].ToString().Length;
          string s = x == 2 ? " " : "  ";
          Console.Write(image[i][j] + s);
        }

        Console.WriteLine();
      }

    }

    /// <summary>
    /// Rotates a 2d matrix by 90, not optimal
    /// </summary>
    /// <param name="image"></param>
    /// <param name="row"></param>
    /// <param name="col"></param>
    /// <returns></returns>
    public static int[,] RotateBy90(int[,] image, int row, int col)
    {
      int[,] rotated = new int[col, row];
      for (int i = 0; i < image.GetLength(0); i++)
      {
        for (int j = 0; j < image.GetLength(0); j++)
        {
          rotated[j, image.GetLength(0) - 1 - i] = image[i, j];
        }
      }

      return rotated;
    }

    /// <summary>
    /// Rotates a jagged 2d matrix by 90, optimal
    /// </summary>
    /// <param name="matrix"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public static int[][] rotate(int[][] matrix, int n)
    {
      for (int layer = 0; layer < n / 2; ++layer)
      {
        int first = layer;
        int last = n - 1 - layer;
        for (int i = first; i < last; ++i)
        {
          int offset = i - first;
          int top = matrix[first][i]; // save top
                                      // left -> top
          matrix[first][i] = matrix[last - offset][first];

          // bottom -> left
          matrix[last - offset][first] = matrix[last][last - offset];

          // right -> bottom
          matrix[last][last - offset] = matrix[i][last];

          // top -> right
          matrix[i][last] = top; // right <- saved top
        }
      }

      return matrix;
    }

    /// <summary>
    /// Set zero at all elements for a given row/column if any element is zero
    /// </summary>
    /// <param name="matrix"></param>
    /// <param name="m"></param>
    /// <param name="n"></param>
    public static void SetZeros(int[][] matrix, int m, int n)
    {
      // Keep track of rows and cols which have zero elements
      bool[] rows = new bool[m];
      bool[] cols = new bool[n];


      for (int i = 0; i < 5; i++)
      {
        for (int j = 0; j < 5; j++)
        {
          if (matrix[i][j] == 0)
          {
            rows[i] = true;
            cols[j] = true;
          }
        }
      }

      //Set the all elements to zero for that row/col
      for (int i = 0; i < m; i++)
      {
        for (int j = 0; j < n; j++)
        {
          if (rows[i] || cols[j])
          {
            matrix[i][j] = 0;
          }
        }
      }

      Matrix.PrintMatrix2(matrix, m);
    }

    /// <summary>
    /// Test if we can set the rows and cols to zero
    /// </summary>
    public static void TestZeros()
    {
      Console.WriteLine();
      var y = Matrix.Build2dMatrix2(5, 5);
      Matrix.SetZeros(y, 5, 5);
    }

    /// <summary>
    /// Test Matrix rotations
    /// </summary>
    public static void TestMatrix()
    {
      var x = Matrix.Build2dMatrix(5, 5);
      PrintMatrix(x);
      Console.WriteLine();
      Matrix.PrintMatrix(Matrix.RotateBy90(x, x.GetLength(0), x.GetLength(1)));

      Console.WriteLine();
      var y = Matrix.Build2dMatrix2(5, 5);
      Matrix.PrintMatrix2(Matrix.rotate(y, y.GetLength(0)), 5);
    }


  }
}
