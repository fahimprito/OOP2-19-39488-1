using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_task_account
{
    class SpecialCurrent:Account
    {
        public SpecialCurrent()
        {

        }
        public SpecialCurrent(string accName, string accid, int balance)
            : base(accName, accid, balance)
        {

        }
        
        new public void Withdraw(int amount)
        {
            if (base.Balance - amount >= Balance * 10 / 100)
            {
                base.Withdraw(amount);
            }
            else
            {
                Console.WriteLine("Insaficient Balance.");
            }
        }
        new public void transfer(int amount, Account acc)
        {
            if ((base.Balance - amount) >= 430)
            {
                base.transfer(amount, acc);
            }

            else
            {
                Console.WriteLine("Insaficient Balance.");
                Console.WriteLine();
            }

        }
    }
}
