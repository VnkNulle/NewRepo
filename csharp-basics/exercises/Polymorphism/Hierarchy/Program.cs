using System;

namespace InheritanceHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("John", "Doe", "123 Main St", 123, 3.75);
            Employee employee = new Employee("Jane", "Smith", "456 Elm St", 456, "Manager");

            Console.WriteLine("Student Information:");
            student.Display();
            Console.WriteLine();

            Console.WriteLine("Employee Information:");
            employee.Display();
        }
    }
}
