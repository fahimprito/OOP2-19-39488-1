using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_task_association
{
    class student
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private float cgpa;

        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
        private department dept;

        public department Dept
        {
            get { return dept; }
            set { dept = value; }
        }



        public student()
        {

        }
        public student(string name, string id, float cgpa)
        {
            this.name = name;
            this.id = id;
            this.cgpa = cgpa;
        }
        public void showinfo()
        {
            Console.WriteLine("name: {0}",name);
            Console.WriteLine("id: {0}",id);
            Console.WriteLine("cgpa: {0}",cgpa);
        }

        public void showDepartment()
        {
            showinfo();
            dept.showinfo();
        }

    }
}
