
using System;

namespace Lab2
{
    public class Student
    {
        public string Name { get; set; }
        public int Mark { get; set; }

        public string Grade
        {
            get
            {
                if (Mark >= 90)
                    return "A";
                else if (Mark >= 80)
                    return "B";
                else if (Mark >= 70)
                    return "C";
                else if (Mark >= 60)
                    return "D";
                else
                    return "F";
            }
        }
    }

    public class StudentTest
    {
        public static void Run()
        {
            Console.Write("How many students? ");
            int count = Convert.ToInt32(Console.ReadLine());

            Student[] students = new Student[count];

            for (int i = 0; i < count; i++)
            {
                students[i] = new Student();

                Console.Write($"Enter student {i + 1} name: ");
                students[i].Name = Console.ReadLine();

                Console.Write($"Enter student {i + 1} mark: ");
                students[i].Mark = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }

            Console.WriteLine("Student results:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{students[i].Name}: {students[i].Mark} -> Grade {students[i].Grade}");
            }
        }
    }
}
