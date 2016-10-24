using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
  class Singleton
  {
    public class A
    {
      private A[] _a;
      private int index = 2;
      private A()
      {

      }

      public A Instance
      {
        get
        {
          lock (new object())
          {
            if (index == 0)
            {
              throw new Exception();
            }

            _a[index--] = new A();
          }
          return _a[index];
        }
      }
    }
  }
}
