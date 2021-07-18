using System;

namespace HW08.ITDEPARTMENT
{
    public class SalaryCalculator
    {
        const double baseSalary = 500;
        private double salary;
        private double bonus;
        private double multiplier;
        
        public double Salary { get; set; }
        public double Bonus { get; set; }

        public SalaryCalculator(double bonus, double multiplier)
        {
            this.multiplier = multiplier;
            this.bonus = bonus;
        }

        protected internal double GetSalary()
        {
            salary = baseSalary * multiplier + bonus;
            Console.WriteLine(salary);
            return salary;
        }
    }
}