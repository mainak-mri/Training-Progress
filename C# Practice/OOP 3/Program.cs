/*
Create a C# program that prompts the user for three names of people and stores them in an array of Person-type objects. There will be two people of the Student type and one person of the Teacher type.
To do this, create a Person class that has a Name property of type string, a constructor that receives the name as a parameter and overrides the ToString () method.

Then create two more classes that inherit from the Person class, they will be called Student and Teacher. Create one method Job and that method will display if they are studying or explaining. Remember to also create two constructors on the child classes that call the parent constructor of the Person class. 

Create a new method to print the user's name and the type whether they are a student or teacher. Create an interface called IJob and then implement that interface in the student and teacher classes.
End the program by reading the people (the teacher and the students) and execute the Explain and Study methods.


Input:
Press 1 for teacher and 2 for student:
2
Juan
Press 1 for teacher and 2 for student:
1
Sara
Press 1 for teacher and 2 for student:
2
Carlos

Output:
My name is Juan
I am a student
I am studying
My name is Sara
I am a teacher
I am explaining
My name is Carlos
I am a student
I am studying

Make different files for the classes.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3];
            List<int> ChoiceList = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                // prompt whether you are inputting a student or a teacher
                Console.WriteLine("Press 1 for teacher and 2 for student:");
                int choice = Convert.ToInt32(Console.ReadLine());
                ChoiceList.Add(choice);
                if (choice == 1)
                {
                    persons[i] = new Teacher(Console.ReadLine());
                }
                else
                {
                    persons[i] = new Student(Console.ReadLine());
                }
            }
            for (int i = 0; i < 3; i++)
            {
                //prompt teacher or student
                if (ChoiceList[i] == 1)
                {
                    ((Teacher)persons[i]).DisplayName();
                    ((Teacher)persons[i]).DisplayJob();
                    ((Teacher)persons[i]).Job();
                    
                    Console.ReadKey();

                }
                else
                {
                    ((Student)persons[i]).DisplayName();
                    ((Student)persons[i]).DisplayJob();
                    ((Student)persons[i]).Job();
                    
                    Console.ReadKey();
                }
            }

        }
    }
}