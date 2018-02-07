using System;
using System.Collections.Generic;
using System.Linq;


namespace StudentIds
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            int newId = 1;
            Console.WriteLine("Enter your students ID or (0 to finish):");
            do
            {
                Console.Write("Enter student ID:");
                newId = int.Parse(Console.ReadLine());
                if (newId != 0)
                {
                    Console.Write("Enter student name:");
                    string newStudent = Console.ReadLine();
                    students.Add(newId, newStudent);
                }
            }
            while (newId != 0);
            
            Console.WriteLine("Class Roster:");
            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine(student.Key + " (" + student.Value + ")");
                Console.ReadLine();
            }
        }
    }
}
