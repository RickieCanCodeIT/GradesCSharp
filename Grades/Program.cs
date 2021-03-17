using System;
using System.Collections.Generic;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            List<int> grades = new List<int>();
            names.Add("Sam");
            grades.Add(70);
            names.Add("Chris");
            grades.Add(95);
            names.Add("Casey");
            grades.Add(85);
            names.Add("Rufio");
            grades.Add(30);
            Console.WriteLine("Student grades:");
            double sum = 0.0;

            for (int counter = 0; counter < grades.Count; counter++)
            {
                Console.WriteLine(names[counter] + " received a grade of " + grades[counter]);
                sum = grades[counter];
            }
            double average = sum / grades.Count;
            Console.WriteLine("Average grade: " + average);
        }
    }
}
