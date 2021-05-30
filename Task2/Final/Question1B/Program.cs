using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1B
{

    class Program
    {
        static void Main(string[] args)
        {
            SemesterResult.Run();
        }
    }
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int InSem1Marks { get; set; }
        public int InSem2Marks { get; set; }
        public int FinalExamMarks { get; set; }
        public double Percent { get; set; }
    }
    class SemesterResult
    {
        private List<Student> _students;
        public static void Run()
        {
            Student[] elective1 = new Student[10];
            elective1[0] = new Student
            {
                Id = 201712001,
                Name = "ARCHAN",
                InSem1Marks = 9,
                InSem2Marks = 15,
                FinalExamMarks = 23
            };
            elective1[1] = new Student
            {
                Id = 201712002,
                Name = "DHRUVIL",
                InSem1Marks = 8,
                InSem2Marks = 17,
                FinalExamMarks = 26
            };
            elective1[2] = new Student
            {
                Id = 201712003,
                Name = "SAHIL",
                InSem1Marks = 4,
                InSem2Marks = 14,
                FinalExamMarks = 3
            };
            elective1[3] = new Student
            {
                Id = 201712004,
                Name = "NILESHKUMAR",
                InSem1Marks = 11,
                InSem2Marks = 16,
                FinalExamMarks = 35
            };
            elective1[4] = new Student
            {
                Id = 201712005,
                Name = "DHRUV",
                InSem1Marks = 10,
                InSem2Marks = 17,
                FinalExamMarks = 33
            };
            elective1[5] = new Student
            {
                Id = 201712006,
                Name = "HIMANSHU",
                InSem1Marks = 10,
                InSem2Marks = 17,
                FinalExamMarks = 24
            };
            elective1[6] = new Student
            {
                Id = 201712007,
                Name = "KISHAN",
                InSem1Marks = 9,
                InSem2Marks = 15,
                FinalExamMarks = 30
            };
            elective1[7] = new Student
            {
                Id = 201712008,
                Name = "YASH",
                InSem1Marks = 7,
                InSem2Marks = 16,
                FinalExamMarks = 17
            };
            elective1[8] = new Student
            {
                Id = 201712009,
                Name = "RASHMI",
                InSem1Marks = 8,
                InSem2Marks = 18,
                FinalExamMarks = 27
            };
            elective1[9] = new Student
            {
                Id = 201712010,
                Name = "SHASHANK",
                InSem1Marks = 14,
                InSem2Marks = 16,
                FinalExamMarks = 25
            };

            SemesterResult e1Result = new SemesterResult(elective1.ToList());
            Console.WriteLine("Elective 1 Topper:");
            var topper = e1Result.HighestMarks();
            Console.Write($"Id={topper.id}, Name={topper.name}\n\n");
            Console.WriteLine("------Elective 1 Percentage wise list-----------");
            var all = e1Result.PercentDescending();
            all.ForEach(one => Console.Write($"{one.Name} - {one.Percent}\n"));
            Student[] elective2 = new Student[10];
            elective2[0] = new Student
            {
                Id = 201712001,
                Name = "ARCHAN",
                InSem1Marks = 10,
                InSem2Marks = 14,
                FinalExamMarks = 27
            };
            elective2[1] = new Student
            {
                Id = 201712012,
                Name = "SONAL",
                InSem1Marks = 6,
                InSem2Marks = 15,
                FinalExamMarks = 29
            };
            elective2[2] = new Student
            {
                Id = 201712003,
                Name = "SAHIL",
                InSem1Marks = 9,
                InSem2Marks = 12,
                FinalExamMarks = 13
            };
            elective2[3] = new Student
            {
                Id = 201712004,
                Name = "NILESHKUMAR",
                InSem1Marks = 17,
                InSem2Marks = 15,
                FinalExamMarks = 33
            };
            elective2[4] = new Student
            {
                Id = 201712005,
                Name = "DHRUV",
                InSem1Marks = 14,
                InSem2Marks = 13,
                FinalExamMarks = 34
            };
            elective2[5] = new Student
            {
                Id = 201712016,
                Name = "MOHAN",
                InSem1Marks = 8,
                InSem2Marks = 14,
                FinalExamMarks = 30
            };
            elective2[6] = new Student
            {
                Id = 201712017,
                Name = "BRIJESH",
                InSem1Marks = 14,
                InSem2Marks = 13,
                FinalExamMarks = 30
            };
            elective2[7] = new Student
            {
                Id = 201712018,
                Name = "SIMON",
                InSem1Marks = 12,
                InSem2Marks = 16,
                FinalExamMarks = 23
            };
            elective2[8] = new Student
            {
                Id = 201712009,
                Name = "RASHMI",
                InSem1Marks = 11,
                InSem2Marks = 15,
                FinalExamMarks = 32
            };
            elective2[9] = new Student
            {
                Id = 201712019,
                Name = "VINOD",
                InSem1Marks = 13,
                InSem2Marks = 11,
                FinalExamMarks = 28
            };

            // prepare list of students who took both electives
            var common = elective1.Select(p => p.Name).Intersect(elective2.Select(p => p.Name)).ToList();
            Console.WriteLine("\nName of students in both subjects:");
            // the common variable is a list coming as output of the LINQ code you write above
            common.ForEach(one => Console.Write($"{one}\n"));


            // prepare list of students who took only elective 1
            var onlyElective1 = elective1.Select(p => p.Name).Except(elective2.Select(p => p.Name)).ToList();
            Console.WriteLine("\nStudents in only elective1:");
            onlyElective1.ForEach(one => Console.Write($"{one}\n"));


            // find total number of students who took either elective1 or elective2 or both
            var allStudents = elective1.Select(p => p.Name).Union(elective2.Select(p => p.Name)).Count();
            Console.WriteLine($"\nTotal Students: {allStudents}");
            Console.ReadLine();
        }
        public SemesterResult(List<Student> students)
        {
            _students = students;
        }
        public (int id, string name) HighestMarks()
        {
            // return id and name as tuple of a student who scored
            // highest aggregate marks (InSem1Marks + InSem2Marks + FinalExamMarks)
            int max = _students.Max(p => p.FinalExamMarks + p.InSem1Marks + p.InSem2Marks);
            var st = _students.Find(p => p.FinalExamMarks + p.InSem1Marks + p.InSem2Marks == max);
            return (st.Id, st.Name);
        }
        public List<Student> PercentDescending()
        {
            //assuming the every exam was of 50 marks
            _students.ForEach(
                p => p.Percent = (p.FinalExamMarks + p.InSem1Marks + p.InSem2Marks) * 100 / 150
            );
            return _students.OrderByDescending(p => p.Percent).ToList();
        }
    }
}
