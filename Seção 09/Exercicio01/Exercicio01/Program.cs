using System;
using System.Globalization;
using Course.Ententies;
using Course.Ententies.Enums;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department´s name: ");
            string departmentName = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string workerName = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel workerLevel = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department department = new Department(departmentName);
            Worker worker = new Worker(workerName, baseSalary, workerLevel, department);

            Console.WriteLine("");
            Console.Write("How many contracts to this worker ?: ");
            int nroContracts = Int32.Parse(Console.ReadLine());
            Console.WriteLine(new string('-', 40));

            for (int i = 1; i <= nroContracts; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (dd/mm/yyyy): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration: ");
                int hours = Int32.Parse(Console.ReadLine());

                worker.addContract(new HourContract(date, valuePerHour, hours));
            }

            Console.WriteLine();
            Console.WriteLine(new string('-', 40));
            Console.Write("Enter month and year to calculate income (mm/yyyy): ");
            DateTime incomeDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Name: {workerName}");
            Console.WriteLine($"Department: {department.Name}");
            Console.WriteLine($"Income for {incomeDate.ToString("MM/yyyy")}: ${worker.Income(incomeDate.Year, incomeDate.Month)}");
        }
    }
}
