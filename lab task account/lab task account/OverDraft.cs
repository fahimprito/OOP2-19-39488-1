using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_task_account
{
    class OverDraft:Account
    {
        int limit = 50000;

        public OverDraft() { }
        public OverDraft(string accName, string accid, int balance)
            : base(accName, accid, balance)
        {
            base.Balance = balance + limit;
        }

        new public void Withdraw(int amount)
        {
            if (base.Balance >= amount)
            {
                base.Withdraw(amount);
            }

            else
            {
                Console.WriteLine("Insaficient Balance.");
            }

        }

        new public void Deposit(int amount) { base.Deposit(amount); }

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
