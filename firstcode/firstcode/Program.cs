using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstcode
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 44, y = 4;
            Console.WriteLine("hello world  "+x+" "+y);
            Console.WriteLine("hello world  {0} {1} ",x,y);
            int add = x + y;
            Console.WriteLine("Addition of " + x + " and " + y+" is "+add );
            int sub = x - y;
            Console.WriteLine("Subtraction of " + x + " and " + y + " is "+sub);
            int mul = x * y;
            Console.WriteLine("multiplication of " + x + " and " + y + " is "+mul);
            int div = x / y;
            Console.WriteLine("division of " + x + " and " + y + " is "+div);
        }
    }
}
