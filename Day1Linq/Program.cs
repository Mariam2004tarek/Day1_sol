// q.1
List<int> numbers = new List<int>() { 2, 4, 6, 7, 1, 4, 2, 9, 1 };
var uniqueSortNumbers = numbers.Distinct().OrderBy(n => n).ToList();
foreach (var item in uniqueSortNumbers)
{
    Console.WriteLine(item);
}

// q.2
for (int i=0;i<uniqueSortNumbers.Count;i++)
{
    Console.WriteLine($"number {uniqueSortNumbers[i]} : Multiply {uniqueSortNumbers[i]* uniqueSortNumbers[i]}");
}
Console.WriteLine("=================");
string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };
var res = names.Where(a => a.Length == 3);
foreach (var item in res)
{
    Console.WriteLine(item);
}
Console.WriteLine("==================");
var res1 = names.Where(a => a.Contains('a')||a.Contains('A'));
foreach (var item in res1)
{
    Console.WriteLine(item);
}


/// //////////////////////////////////////////////







using System;
using System.Collections.Generic;
namespace Day1Linq {

    public class Student
    {
        public Subjcet[] subjects;

        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Subject[] Subjects { get; set; }
    }

    public class Subject
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public Subject(int _code, string _name)
        {
            Code = _code;
            Name = _name;
        }
    }
    class Program
    {
        static void Main()
        {
            // قائمة الطلاب مع البيانات المعبأة
            List<Student> students = new List<Student>()
        {
            new Student()
            {
                ID = 1,
                FirstName = "Ali",
                LastName = "Mohammed",
                Subjects = new Subject[] { new Subject() { Code = 22, Name = "EF" }, new Subject() { Code = 33, Name = "UML" } }
            },
            new Student()
            {
                ID = 2,
                FirstName = "Mona",
                LastName = "Gala",
                Subjects = new Subject[] { new Subject() { Code = 22, Name = "EF" }, new Subject() { Code = 34, Name = "XML" }, new Subject() { Code = 25, Name = "JS" } }
            },
            new Student()
            {
                ID = 3,
                FirstName = "Yara",
                LastName = "Yousf",
                Subjects = new Subject[] { new Subject() { Code = 22, Name = "EF" }, new Subject() { Code = 25, Name = "JS" } }
            },
            new Student()
            {
                ID = 1,
                FirstName = "Ali",
                LastName = "Ali",
                Subjects = new Subject[] { new Subject() { Code = 33, Name = "UML" } }
            }
        };
            var studentSummary = students.Select(s => new
            {
                FullName = s.FirstName + " " + s.LastName,
                NumberOfSubjects = s.Subjects.Length
            });

            foreach (var summary in studentSummary)
            {
                Console.WriteLine($"Full Name: {summary.FullName}, Number of Subjects: {summary.NumberOfSubjects}");
            }
            Console.WriteLine("==================================");
            var sortedStudents = students
            .OrderByDescending(s => s.FirstName)
            .ThenBy(s => s.LastName)
            .Select(s => new { s.FirstName, s.LastName });

            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"FirstName: {student.FirstName}, LastName: {student.LastName}");
            }
            var studentSubjects = students.SelectMany(s => s.Subjects,
                                               (student, subject) => new
                                               {
                                                   FirstName = student.FirstName,
                                                   LastName = student.LastName,
                                                   SubjectName = subject.Name
                                               });

            foreach (var item in studentSubjects)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} has subject {item.SubjectName}");
            }
        }
    }
}