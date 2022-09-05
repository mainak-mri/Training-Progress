using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    internal class Person: IJob
    {
        protected string Name;
        public Person(string name)
        {
            Name = name;
            //Console.WriteLine("Person");
        }
        public override string ToString()
        {
            return "Hello! My name is " + Name;
        }
        public virtual void Job()
        {
            Console.WriteLine("Studying");
        }
        public void DisplayName() 
        {
            Console.WriteLine("My name is " + Name);
        }
        public virtual void DisplayJob()
        {
            Console.WriteLine("Teacher");
        }

    }
}
