using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace percentage_and_grade
{
    class Program
    {
        static void Main(string[] args)
        {
            int phy=88, chem=85, bio=87, math=90, com=92, percentage;
            percentage = (phy + chem + bio + math + com) / 5;
            Console.WriteLine("percentage of grade {0}", percentage);



        }
    }
}
