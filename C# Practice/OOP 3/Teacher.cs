using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    internal class Teacher: Person, IJob
    {
        public Teacher(string name):base(name)
        {
            //Name = name;
        }

        public void Job()
        {
            Console.WriteLine("I am explaining");
        }
        public void DisplayJob()
        {
            Console.WriteLine("I am a teacher");
        }

    }
}
