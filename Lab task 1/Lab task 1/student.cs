using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_task_1
{
    class student
    {
        private String name;
        private String id;
        private String department;
        private float cgpa;

        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string Id
        {
            set { id = value; }
            get { return id; }
        }
        public string Department
        {
            set { department = value; }
            get { return department; }
        }
        public float Cgpa
        {
            set { cgpa = value; }
            get { return cgpa; }
        }
        public student(string name, string id, string department, float cgpa)
        {
            this.name = name;
            this.id = id;
            this.department = department;
            this.cgpa = cgpa;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Student name: {0}", name);
            Console.WriteLine("Student id: {0}", id);
            Console.WriteLine("Student department: {0}", department);
            Console.WriteLine("Student cgpa: {0}", cgpa);
            Console.WriteLine("");
        }


    }
}
