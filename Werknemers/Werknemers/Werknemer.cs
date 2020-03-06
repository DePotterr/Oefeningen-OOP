using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Werknemers
{
    class Werknemer
    {
        const int STANDARDSALARY = 200;
        const int BASIS_ANCTIENNITEIT = 1;
        private static int employeeNumber = 0;
        public Persoon Employee { get; set; }
        public int Anciënniteit { get; set; }
        public double TotalSalary { get; private set; }

        public Werknemer(Persoon employee, int anciënniteit)
        {
            this.Employee = employee;
            this.Anciënniteit = anciënniteit;
            employeeNumber += employeeNumber + 1;
            CalculateSalary();
        }
        public Werknemer(Persoon employee) : this(employee, BASIS_ANCTIENNITEIT)
        {
        }

        private double CalculateSalary(DateTime testMoment)
        {
            int totalYears = testMoment.Year - DateTime.Today.Year;
            return STANDARDSALARY * (Anciënniteit + totalYears);
        }

        private void CalculateSalary()
        {
            double result = CalculateSalary(DateTime.Today);
            TotalSalary = result;
        }


        public override string ToString()
        {
            string str = String.Format("F{0}",employeeNumber);
            return "Employee " + str + ": \n\t" + this.Employee;
        }
    }
}
