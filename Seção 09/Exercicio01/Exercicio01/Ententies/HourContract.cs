using System;

namespace Course.Ententies
{
    class HourContract
    {
        public DateTime Date { get; set; }

        public Double ValuePerHour { get; set; }

        public Int32 Hours { get; set; }

        public HourContract()
        {
        }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            this.Date = date;
            this.ValuePerHour = valuePerHour;
            this.Hours = hours;
        }

        public double TotalValue()
        {
            return ValuePerHour * Hours;
        }
    }
}
