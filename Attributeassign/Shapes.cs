using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributeassign
{
    [MethodInfo(methodname ="some method name",returntype ="it depends",parameters ="some parameters",message ="it contains overloading of method")]
    class Shapes
    {
      
        public int Area(int len, int brd)
        {
            return len * brd;

        }
        public double Area(double bas, double height)
        {

            return 0.5 * bas * height;

        }

        public int Area(int side)
        {

            return side * side;

        }

        public double Area(double radius)
        {
            return 3.142 * radius * radius;
        }


    }
}
