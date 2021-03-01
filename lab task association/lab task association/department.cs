using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_task_association
{
    class department
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
        private student[] students;

        public void Addstudent(params student[] stu)
        {
            foreach (student s in stu)
            {
                students[studentcount] = s;
                //studentcount++;
                s.Dept = this;
            }
            
        }
        public void PrintStudent()
        {
            for (int i = 0; i < studentcount; i++)
            {
                students[i].showinfo();
            }
        }
        public student getstudent(string id)
        {
            return null;
        }

        public int studentcount
        {
            get { return studentcount; }
            set { studentcount = value; }
        }

        public department() { 
        students= new student[50];
        }
        public department(string name, string id)
        {
            this.name = name;
            this.id = id;
        }
        public void showinfo()
        {
            Console.WriteLine("name: {0}", name);
            Console.WriteLine("id: {0}", id);
        }

    }
}
