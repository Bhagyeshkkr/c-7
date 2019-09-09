using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp7
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintStudentMarks(101, new Subject
            {
                SubjectName = "Math",
                Marks = 96
            }, new Subject
            {
                SubjectName = "physics",
                Marks = 88
            }, new Subject
            {
                SubjectName = "Chem",
                Marks = 91
            });
        }
        public static void PrintStudentMarks(int studentId, params Subject[] subjects)
        {
            Console.WriteLine( "Student Id {studentId} Total Marks: {CalculateMarks()}");
            Console.ReadLine();
            Console.WriteLine( "Subject wise marks");
            Console.ReadLine();
            foreach (var subject in subjects)
            {


                Console.WriteLine( "Subject Name: {subject.SubjectName} \t Marks: {subject.Marks}");
                Console.ReadLine();
            }
            decimal CalculateMarks()
            {
                decimal totalMarks = 0;
                foreach (var subject in subjects)
                {
                    totalMarks += subject.Marks;
                }
                return totalMarks;
            }
        }

       
        public class Subject
        {
            public string SubjectName
            {
                get;
                set;
            }
            public decimal Marks
            {
                get;
                set;
            }
        }
    }
}
