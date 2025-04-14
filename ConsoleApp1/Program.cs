using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static List<string> students = new List<string>();

        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string user = Console.ReadLine();

            Console.WriteLine($"\nHello {user}! 🎓 Welcome to your Student Manager CLI App.\n");

            bool running = true;

            while (running)
            {
                Console.WriteLine("\n--- MENU ---");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Remove Student");
                Console.WriteLine("3. Show All Students");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice (1-4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddStudent();
                        break;
                    case "2":
                        RemoveStudent();
                        break;
                    case "3":
                        ShowStudents();
                        break;
                    case "4":
                        Console.WriteLine($"\nThanks for using the Student Manager, {user}! 👋");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("⚠️ Invalid choice. Please pick between 1 and 4.");
                        break;
                }
            }
        }

        static void AddStudent()
        {
            Console.Write("Enter student name to add: ");
            string name = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(name))
            {
                students.Add(name.Trim());
                Console.WriteLine($"✅ {name} has been added.");
            }
            else
            {
                Console.WriteLine("❌ Name cannot be empty.");
            }
        }

        static void RemoveStudent()
        {
            Console.Write("Enter student name to remove: ");
            string name = Console.ReadLine();

            if (students.Remove(name))
            {
                Console.WriteLine($"🗑️ {name} has been removed.");
            }
            else
            {
                Console.WriteLine($"❌ {name} not found in the list.");
            }
        }

        static void ShowStudents()
        {
            Console.WriteLine("\n--- Current Student List ---");

            if (students.Count == 0)
            {
                Console.WriteLine("📭 No students added yet.");
            }
            else
            {
                int index = 1;
                foreach (string student in students)
                {
                    Console.WriteLine($"{index++}. {student}");
                }
            }
        }
    }
}
