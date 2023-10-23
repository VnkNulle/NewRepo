using System;

namespace InheritanceHierarchy
{
    public class Employee : Person
    {
        public string JobTitle { get; set; }

        public Employee(string firstName, string lastName, string address, int id, string jobTitle)
            : base(firstName, lastName, address, id)
        {
            JobTitle = jobTitle;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Job Title: {JobTitle}");
        }
    }
}
