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
            int i,n=100,sum=0;
            for (i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }

                 
            }
            Console.WriteLine("sum of even num {0}", sum);
            sum = 0;
            for (i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
                
            }
            Console.WriteLine("sum of odd num {0}", sum);


        }
    }
}

