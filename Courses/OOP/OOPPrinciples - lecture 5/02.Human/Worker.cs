namespace Human
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Worker : Human
    {
        // to do filter
        public decimal WeekSalary { get; set; }

        public int WorkHoursPerDay { get; set; }

        public Worker(int workHoursPerDay, decimal weekSalary, string firstName, string secondName) : base (firstName, secondName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal MoneyPerHour()
        {
            decimal moneyPerHour;
            int workDays = 5;

            moneyPerHour = this.WeekSalary / (this.WorkHoursPerDay * workDays);

            return moneyPerHour;
        }
    }
}
