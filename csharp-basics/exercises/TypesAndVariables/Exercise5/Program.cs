using System;

namespace ClassSchedule
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] courses = {
                "English III", "Precalculus", "Music Theory", "Biotechnology",
                "Principles of Technology I", "Latin II", "AP US History",
                "Business Computer Infomation Systems"
            };

            string[] teachers = {
                "Ms. Lapan", "Mrs. Gideon", "Mr. Davis", "Ms. Palmer",
                "Ms. Garcia", "Mrs. Barnett", "Ms. Johannessen", "Mr. James"
            };

            Console.WriteLine("+------------------------------------------------------------+");
            Console.WriteLine("| 1 | " + courses[0].PadRight(26) + " | " + teachers[0].PadRight(15) + " |");
            Console.WriteLine("| 2 | " + courses[1].PadRight(26) + " | " + teachers[1].PadRight(15) + " |");
            Console.WriteLine("| 3 | " + courses[2].PadRight(26) + " | " + teachers[2].PadRight(15) + " |");
            Console.WriteLine("| 4 | " + courses[3].PadRight(26) + " | " + teachers[3].PadRight(15) + " |");
            Console.WriteLine("| 5 | " + courses[4].PadRight(26) + " | " + teachers[4].PadRight(15) + " |");
            Console.WriteLine("| 6 | " + courses[5].PadRight(26) + " | " + teachers[5].PadRight(15) + " |");
            Console.WriteLine("| 7 | " + courses[6].PadRight(26) + " | " + teachers[6].PadRight(15) + " |");
            Console.WriteLine("| 8 | " + courses[7].PadRight(26) + " | " + teachers[7].PadRight(15) + " |");
            Console.WriteLine("+------------------------------------------------------------+");

            Console.ReadKey();
        }
    }
}
