 using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace studentlist
{
    class program
    {
        public static void Displaydata(List<student> students)
        {

            Dictionary<char, List<student>> display = new Dictionary<char, List<student>>()
             {
                {'F', students.Where(s => s.gender == "female").ToList()},
                {'M', students.Where(s => s.gender == "male").ToList()},
                {'S', students.OrderBy(s => s.standard).ToList()}
             };

            Console.WriteLine(" F. Enter F for Girls Record:");
            Console.WriteLine(" M. Enter M for Boys Record:");
            Console.WriteLine(" S. Enter S for Record Of Student in Sorted By Standard");
            Console.Write(" Enter Your choice:");
            char choice = Convert.ToChar(Console.ReadLine());
            foreach (var record in display)
            {
                if (record.Key == choice)
                {
                    foreach (var student in record.Value)
                    {
                      Console.WriteLine(student.Name + " " + student.age + " " + student.gender + " " + student.standard);
                    }
                }
            }
        }
        public static void Adddata(List<student> students)
        {
            Console.Write("Enter student name: ");
            string Name = Console.ReadLine();
            Console.Write("Enter student Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter student gender: ");
            string gender = Console.ReadLine();
            Console.Write("Enter student standard: ");
            int standard = Convert.ToInt32(Console.ReadLine());
            students.Add(new student(Name, age, gender, standard));  
            Console.Write("Students data added successfully!!");

        }

        static void Main()
        {
            int choice;
            List<student> students = new List<student>();
            do
            {
                Console.WriteLine("\n 1.Add student data:");
                Console.WriteLine(" 2.Display student data:");
                Console.WriteLine(" 3.Exit");
                Console.Write(" Enter your choice:");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Adddata(students);
                        break;
                    case 2:
                        Displaydata(students);
                        break;
                    case 3:
                        Console.WriteLine(" Thank you....!!!!");
                        break;
                    default:
                        Console.WriteLine(" Invalid Choice");
                        break;
                }
            } while (choice != 3);
        }
    }
}

 