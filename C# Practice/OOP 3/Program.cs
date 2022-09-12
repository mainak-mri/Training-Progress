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
            //Person[] persons = new Person[];
            var persons = new List<IJob>();
            bool finished = false;
            
            // User can keep on adding inputs and then press exit to stop.
            do
            {
                // prompt whether you are inputting a student or a teacher
                Console.WriteLine("Press\n1. for teacher\n2. for student\n3. to exit:");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        persons.Add(new Teacher(Console.ReadLine()));
                        break;

                    case 2:
                        persons.Add(new Student(Console.ReadLine()));
                        break;
                    case 3: finished = true;
                            break;
                    default:
                        Console.WriteLine("Please enter correct value");
                        break;
                }
            } while (!finished);
         
            for (int i = 0; i < persons.Count; i++)
            {
                persons[i].DisplayName();
                persons[i].DisplayJob();
                persons[i].Job();
                Console.ReadKey();
            }

        }
    }
}