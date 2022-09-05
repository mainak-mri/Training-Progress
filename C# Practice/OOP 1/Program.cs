using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Greet();
            
            Student student = new Student();
            student.SetAge(21);
            student.Greet();
            student.ShowAge();
            student.Study();

            Teacher teacher = new Teacher();
            teacher.SetAge(45);
            teacher.Greet();
            teacher.Explain();
            Console.ReadKey();
        }
    }
}
