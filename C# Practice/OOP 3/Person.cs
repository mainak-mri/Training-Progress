using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    internal class Person 
    {
        protected string Name;
        public Person(string name)
        {
            Name = name;
        }

        public void DisplayName()
        {
            Console.WriteLine("My name is " + Name);
        }
    }
}
