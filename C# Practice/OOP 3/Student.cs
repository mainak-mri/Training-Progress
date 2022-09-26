using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    internal class Student: Person, IJob
    {
        public Student(string name): base(name)
        {
            //Name = name;
        }

        public void Job()
        {
            Console.WriteLine("I am studying");
        }
        public void DisplayJob()
        {
            Console.WriteLine("I am a student");
        }
    }
}
