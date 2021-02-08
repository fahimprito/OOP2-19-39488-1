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

        public int X
        {
            set { x = value; }
            get { return x; }
        }
        public int Y
        {
            set { y = value; }
            get { return y; }
        }
        public int Z
        {
            set { z = value; }
            get { return z; }
        }

        public Triangle(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }


        public void showInfo()
        {
            Console.WriteLine("1st edge {0}", x);
            Console.WriteLine("1st edge {0}", y);
            Console.WriteLine("1st edge {0}", z);
        }
        public void TestTriangle()
        {
            if (x == y && y == z)
            {
                Console.WriteLine("the triangle is equilateral");
                Console.WriteLine("");
            }

            else if ((x == y) || (y == z) || (z == x))
            {
                Console.WriteLine("the triangle is isosceles");
                Console.WriteLine("");
            }


            else
            {
                Console.WriteLine("the triangle is scalene");
                Console.WriteLine("");
            }
        }
    }
}
