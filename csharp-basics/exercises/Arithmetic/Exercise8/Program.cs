namespace FooCorporation
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateAndPrintPay("Employee 1", 7.50, 35);

            CalculateAndPrintPay("Employee 2", 8.20, 47);

            CalculateAndPrintPay("Employee 3", 10.00, 73);
        }

        static void CalculateAndPrintPay(string employeeName, double basePay, int hoursWorked)
        {
            const double minimumWage = 8.00;
            const int maxHoursPerWeek = 60;

            if (basePay < minimumWage)
            {
                Console.WriteLine($"{employeeName} is paid below the minimum wage.");
                return;
            }

            if (hoursWorked > maxHoursPerWeek)
            {
                Console.WriteLine($"{employeeName} has worked more than 60 hours in a week.");
                return;
            }

            double totalPay;

            if (hoursWorked <= 40)
            {
                totalPay = basePay * hoursWorked;
            }
            else
            {
                int overtimeHours = hoursWorked - 40;
                double overtimePay = basePay * 1.5 * overtimeHours;
                double regularPay = basePay * 40;
                totalPay = regularPay + overtimePay;
            }

            Console.WriteLine($"{employeeName}'s total pay: ${totalPay:F2}");
        }
    }
}
