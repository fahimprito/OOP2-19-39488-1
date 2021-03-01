using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_task_association
{
    class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student("fahim", "39488", 2.6f);
            student s2 = new student("ahmmed", "12345", 3.5f);
            student s3 = new student("mojumder", "54321", 3.3f);

            department d1 = new department("computer science", "cs");
            department d2 = new department("Electrical engineering", "EEE");

            s1.Dept=d1;
            //d1.Addstudent(s1);
            s2.Dept = d1;
            s3.Dept = d2;
            //d2.Addstudent(s3);
            s1.showDepartment();
            //s2.showDepartment();
            s3.showDepartment();

            d1.Name = "computer science & engineering";
            d1.Id = "cse";
            s1.showDepartment();








        }
    }
}
