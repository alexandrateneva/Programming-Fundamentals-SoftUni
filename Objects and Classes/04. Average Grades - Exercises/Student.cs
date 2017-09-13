namespace _04.Average_Grades___Exercises
{
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        public string Name { get; set; }

        public List<double> Grades { get; set; }

        public double AverageGrade => Grades.Average();
    }
}
