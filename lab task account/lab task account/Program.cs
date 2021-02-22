using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_task_account
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("///////");
            Savings a1 = new Savings("Forhad","34343",500);
            Console.WriteLine();
            Savings a2 = new Savings("Fahim", "39488", 4000);
            
            a2.Withdraw(3900);
            a2.Deposit(10000);
            a2.Withdraw(500);
            a2.transfer(2000,a1);

            Console.WriteLine();
            Console.WriteLine("///////");
            SpecialCurrent a3 = new SpecialCurrent("Fahim", "79936", 5000);

            a3.Deposit(1000);
            a3.Withdraw(5000);
            a3.Withdraw(990);

            Console.WriteLine();
            Console.WriteLine("///////");
            Fixed a4 = new Fixed("Ahmmed", "43774", 44000,2);

            a4.Withdraw(5000);
            a4.transfer(10000,a2);


            Console.WriteLine();
            Console.WriteLine("///////");
            OverDraft a10 = new OverDraft("Fahim", "55234", 3000);

            a10.Withdraw(53000);

        }
    }
}
