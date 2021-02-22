using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_task_account
{
    class Fixed:Account
    {
        int tenureYear = 4, year;

        public Fixed() { }
        public Fixed(string accName, string accid, int balance, int year)
            : base(accName, accid, balance)
        {
            this.year = year;
        }

        new public void Withdraw(int amount)
        {
            if (tenureYear <= this.year)
            {
                base.Withdraw(amount);
            }

            else
            {
                Console.WriteLine("your account is not matured yet"); 
            }
                
        }

        new public void transfer(int amount, Account acc)
        {
            if (tenureYear <= this.year)
            {
                base.transfer(amount, acc);
            }

            else
            {
                Console.WriteLine("your account is not matured yet");
                Console.WriteLine();
            }

        }
    }
}
