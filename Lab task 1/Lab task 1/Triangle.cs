using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_task_1
{
    class Triangle
    {
        private int x;
        private int y;
        private int z;

        public void showInfo()
        {
            Console.WriteLine("1st edge {0}", x);
            Console.WriteLine("1st edge {1}", y);
            Console.WriteLine("1st edge {2}", z);
        }
        public void TestTriangle()
        {
            if (x == y && y == z)
                Console.WriteLine("the triangle is equilateral");
            else if ((x==y) || (y==z) || (z==x))
                Console.WriteLine("the triangle is isosceles");
            else
                Console.WriteLine("the triangle is scalene");
        }

    }
}
