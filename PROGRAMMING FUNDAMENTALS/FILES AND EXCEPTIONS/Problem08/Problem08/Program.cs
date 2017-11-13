using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem08
{
    class Program
    {
        class Student
        {
            public string name { get; set; }
            public List<double> grades { get; set; }
            public double averageGrade { get; set; }
        }
        static void Main(string[] args)
        {
            string[] inputLines = File.ReadAllLines("input.txt").ToArray();
            List<string> outputLines = new List<string>();

            List<Student> allStudents = new List<Student>();
            Student currStudent;

            foreach(string line in inputLines.Skip(1))
            {
                currStudent = new Student()
                {
                    name = line.Split()[0],
                    grades = line.Split().Skip(1).Select(double.Parse).ToList<double>()
                };
                currStudent.averageGrade = currStudent.grades.Sum() / currStudent.grades.Count;
                allStudents.Add(currStudent);
            }

            outputLines = allStudents.Where(x => x.averageGrade >= 5.00).OrderBy(x => x.name).ThenByDescending(x => x.averageGrade).
                Select(x => String.Format("{0} -> {1:F2}", x.name, x.averageGrade)).ToList();

            File.WriteAllLines("output.txt", outputLines);
        }
    }
}
