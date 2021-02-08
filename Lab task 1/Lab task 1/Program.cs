using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            student s = new student("FAHIM AHMMED MOJUMDER", "19-39488-1","CSE",3.3f);
            s.ShowInfo();

            Triangle t = new Triangle(4,8,8);
            t.showInfo();
            t.TestTriangle();

            Account a = new Account("FAHIM", "48884", 10000);
            a.Deposit(5000);
            a.Withdraw(2000);


            Course c = new Course("OOP2", "CSC2210", 3);
            c.ShowCourseInfo();

        }
    }

}
