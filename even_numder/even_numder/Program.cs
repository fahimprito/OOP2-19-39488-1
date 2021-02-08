using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_numder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            for (n = 1; n < 21; n++)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine("even numbers are {0}", n);
                }
            }
            

        }
    }
}
