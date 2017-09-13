namespace _04.Average_Grades___Exercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AverageGrades
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').ToList();
                var grades = new List<double>();
                var name = input[0];
                for (int j = 1; j < input.Count; j++)
                {
                    grades.Add(double.Parse(input[j]));
                }
                var currentStudent = new Student { Name = name, Grades = grades };
                students.Add(currentStudent);
            }
            List<Student> finalListOfStudents = students.OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrade).ToList();

            foreach (var student in finalListOfStudents)
            {
                if (student.AverageGrade >= 5.00)
                {
                    Console.WriteLine($"{student.Name} -> {student.AverageGrade:F2}");
                }
            }
        }
    }
}
