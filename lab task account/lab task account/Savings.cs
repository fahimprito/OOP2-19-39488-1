using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_task_account
{
    class Savings:Account
    {
        public Savings(string accName, string accid, int balance)
            : base(accName, accid, balance)
        {
            maximumTransaction = 100;
        }


        public int maximumTransaction { get; set; }
    }
}
