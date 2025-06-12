using System;
using System.Linq;

namespace StudentGradeArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] student1 = { 85, 90, 78 };
            int[] student2 = { 88, 73, 80 };
            int[] student3 = { 90, 85, 88 };
            int[] student4 = { 92, 90, 95 };
            int[] student5 = { 85, 80, 85 };

            Console.WriteLine("Student 1 Grades: " + student1[0] + ", " + student1[1] + ", " + student1[2]);
            Console.WriteLine("Student 2 Grades: " + student2[0] + ", " + student2[1] + ", " + student2[2]);
            Console.WriteLine("Student 3 Grades: " + student3[0] + ", " + student3[1] + ", " + student3[2]);
            Console.WriteLine("Student 4 Grades: " + student4[0] + ", " + student4[1] + ", " + student4[2]);
            Console.WriteLine("Student 5 Grades: " + student5[0] + ", " + student5[1] + ", " + student5[2]);
            Console.WriteLine("----------------------------------------------------------------------------");

            int avg1 = (int)student1.Average();
            int avg2 = (int)student2.Average();
            int avg3 = (int)student3.Average();
            int avg4 = (int)student4.Average();
            int avg5 = (int)student5.Average();

            Console.WriteLine("Student 1 Average: " + avg1);
            Console.WriteLine("Student 2 Average: " + avg2);
            Console.WriteLine("Student 3 Average: " + avg3);
            Console.WriteLine("Student 4 Average: " + avg4);
            Console.WriteLine("Student 5 Average: " + avg5);
            Console.WriteLine("----------------------------------------------------------------------------");

            int highestAverage = new int[] { avg1, avg2, avg3, avg4, avg5 }.Max();
            Console.WriteLine("Highest Average Grade: " + highestAverage);
            Console.WriteLine("----------------------------------------------------------------------------");

            int lowestGrade = new int[] {
                student1.Min(), student2.Min(), student3.Min(), student4.Min(), student5.Min()
            }.Min();
            Console.WriteLine("Lowest Grade Across All Students: " + lowestGrade);
            Console.WriteLine("----------------------------------------------------------------------------");

            Console.WriteLine("Median Grade Per Subject:");
            for (int subject = 0; subject < 3; subject++)
            {
                int[] subjectGrades = { student1[subject], student2[subject], student3[subject], student4[subject], student5[subject] };
                Array.Sort(subjectGrades);
                int median;

                if (subjectGrades.Length % 2 == 0)
                {
                    median = (subjectGrades[subjectGrades.Length / 2 - 1] + subjectGrades[subjectGrades.Length / 2]) / 2;
                }
                else
                {
                    median = subjectGrades[subjectGrades.Length / 2];
                }

                Console.WriteLine($"Subject {subject + 1}: {median}");
            }

            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}