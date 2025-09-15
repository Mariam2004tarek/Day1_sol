using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Day4
{
    #region
    public class Company
    {
        public string Name { get; set; }
        public List<Department> d1 { get; set; }
        public Company(string name, List<Department> dept)
        {
            Name = name;
            d1 = dept;
        }
        public void print()
        {
            Console.WriteLine($"{Name}");
            foreach (var item in d1)
            {
                Console.WriteLine(item);
            }
        }
    }
    public class Department
    {
        public string Name { get; set; }
        public List<Employee> e1 { get; set; }
        public Department(string name)
        {
            Name = name;
        }
        public Department(string name, List<Employee> emp)
        {
            Name = name;
            e1 = emp;
        }
        public void print()
        {
            Console.WriteLine($"{Name}");
            foreach (var item in e1)
            {
                Console.WriteLine(item);
            }
        }
    }
    public class Employee
    {//and each employee being enrolled in courses 
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public List<Courses> c1 { set; get; } = new List<Courses>();
        public Employee(int id, string name, int salary, List<Courses> course)
        {
            Id = id;
            Name = name;
            Salary = salary;
            c1 = course;
        }
        public void print()
        {
            Console.WriteLine($"{Id}:{Name}:{Salary}");
            for (int i = 0; i < c1.Count; i++)
            {
                Console.WriteLine($"{c1[i].Name} : {c1[i].Hours}");
            }
            //foreach (var item in c1)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
    public class Courses
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public Courses(string name, int hours)
        {
            Name = name;
            Hours = hours;
        }
        public void print()
        {
            Console.WriteLine($"{Name}:{Hours}");
        }
    }
    public class Engin
    {
        public string Model { get; set; }
        public void Move()
        {
            Console.WriteLine("Engine Moved");
        }
    }
    public class Car
    {
        public string name { get; set; }
        public string Model { get; set; }
        public Engin Engine = new Engin();
        public void Move()
        {
            Engine.Move();
        }
    }
    #endregion

    #region
    public class Person
    {
        protected string Name { get; set; }
        protected int Age { get; set; }
        public virtual void Introduce()
        {
            Console.WriteLine($"My Name is{Name} ,My Age is{Age}");
        }
    }
    public class Instructor:Person
    {
        public string[] NameCourse { get; set; }
        public int Id { get; set; }
        public Instructor()
        {
            Id = IdGenerator.GenerateId();
        }
        public void TeachCourse()
        {
            foreach (var item in NameCourse)
            {
                Console.WriteLine(item);
            }
        }
        public override void Introduce()
        {
            Console.WriteLine("Hi I am Instructor");
        }
        
    }
    public class Student : Person
    {
        public string[] RegistCourse { get; set; }
        public int Id { get; set; }

        public List<Grade> grades;
        public void AddGrade(Grade g)
        {
            grades.Add(g);
        }
        
        public Student()
        {
            Id = IdGenerator.GenerateId();
        }
        public void RegisterCourse()
        {
            foreach (var item in RegistCourse)
            {
                Console.WriteLine(item);
            }
        }
        public override void Introduce()
        {
            Console.WriteLine("Hi I am Student");
        }

        /////////////////
        public void RegisterCourse(Course c)
        {
            switch (c.Level)
            {
                case CourseLevel.Beginner:
                    Console.WriteLine("Good Luck");
                    break;
                case CourseLevel.Intermediate:
                    Console.WriteLine("Keep Going");
                    break;
                case CourseLevel.Advanced:
                    Console.WriteLine("Excellent");
                    break;

            }
        }
    }
    public class Course
    {
        public string Name { get; set; }
        public CourseLevel Level { get; set; }
        public Course(string name, CourseLevel level)
        {
            Name = name;
            Level = level;
        }
    }
    #endregion

    #region
    public abstract class Shape
    {
        public abstract double Area();
    }
    public class Circle : Shape, IDrawable
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return 3.14 * 3.14 * Radius;
        }

        public void Draw()
        {
            Console.WriteLine("from class Circle");
        }
    }
    public class Rectangle : Shape,IDrawable
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override double Area()
        {
            return Length * Width;
        }

        public void Draw()
        {
            Console.WriteLine("from class Rectangle");
        }
    }
    public interface IDrawable
    {
        void Draw();
    }
    #endregion

    public enum CourseLevel
    {
        Beginner, Intermediate, Advanced

    }
    public static class IdGenerator
    {
        private static int id = 0;
        public static int GenerateId()
        {
            return ++id;
        }
    }

    public class Grade
    {
        
        public int Value { get; set; }
        public Grade(int v)
        {
            Value = v;
        }
        public static Grade operator +(Grade g1, Grade g2)
        {
            return new Grade(g1.Value + g2.Value);
        }
        public static bool operator ==(Grade g1, Grade g2)
        {
            return g1.Value == g2.Value;
        }
        public static bool operator !=(Grade g1, Grade g2)
        {
            return !(g1.Value == g2.Value);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region point1
            Courses c1 = new Courses("C#", 30);
            Courses c2 = new Courses("Sql", 24);
            List<Courses> c3 = new List<Courses>() { c1,c2};
            
            Employee e1 = new Employee(1, "Samy", 50000,c3);
            e1.print();
            Console.WriteLine("============================");
            Department d1 = new Department("Dp1");
            Department d2 = new Department("Dp2");
            Department d3 = new Department("Dp3");
            Console.WriteLine(d1.Name);
            Console.WriteLine(d2.Name);
            Console.WriteLine(d3.Name);
            #endregion

            #region
            List<Shape> s1 = new List<Shape>()
            {
                new Circle(5),
                new Circle(3.5),
                new Rectangle(2,8),
                new Rectangle(7,4)
            };
            foreach (Shape s in s1)
            {
                Console.WriteLine(s.Area());
                if(s is IDrawable idrawable)
                {
                    idrawable.Draw();
                }
            }
        #endregion




        }
    }
}
