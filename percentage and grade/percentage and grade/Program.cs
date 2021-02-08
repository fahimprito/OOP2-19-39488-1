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

            if(percentage>=90)
                Console.WriteLine("Grade A+");
            else if (percentage <= 89 && percentage >= 85)
                Console.WriteLine("Grade A");
            else if (percentage <= 84 && percentage >= 80)
                Console.WriteLine("Grade B+");
            else if (percentage <= 79 && percentage >= 75)
                Console.WriteLine("Grade B");
            else if (percentage <= 74 && percentage >= 50)
                Console.WriteLine("Grade C+");
            else if (percentage >= 49)
                Console.WriteLine("Grade F");


        }
    }
}
