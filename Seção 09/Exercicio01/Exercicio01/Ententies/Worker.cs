using System.Collections.Generic;
using Course.Ententies.Enums;

namespace Course.Ententies
{
    class Worker
    {
        public string Name { get; set; }
        public double BaseSalary { get; set; }
        public WorkerLevel Level { get; set; }
        public Department Departament { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
        public Worker()
        {
        }
        public Worker(string name, double baseSalary, WorkerLevel level, Department department)
        {
            this.Name = name;
            this.BaseSalary = baseSalary;
            this.Level = level;
            this.Departament = department;
        }        

        public void addContract (HourContract hourContract)
        {
            this.Contracts.Add(hourContract);
        }

        public void removeContract (HourContract hourContract)
        {
            this.Contracts.Remove(hourContract);
        }

        public double Income (int year, int month)
        {
            double sum = BaseSalary;

            foreach (HourContract contract in this.Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }

            return sum;
        }
    }
}
