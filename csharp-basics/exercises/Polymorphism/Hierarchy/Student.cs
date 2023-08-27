using System;

namespace InheritanceHierarchy
{
    public class Student : Person
    {
        public double GPA { get; set; }

        public Student(string firstName, string lastName, string address, int id, double gpa)
            : base(firstName, lastName, address, id)
        {
            GPA = gpa;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"GPA: {GPA:F2}");
        }
    }
}
