using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Werknemers
{
    class Werknemer
    {
        public enum Prestaties { Onvoldoende, Voldoende}
        const int STANDARDSALARY = 200;
        const int BASIS_ANCTIENNITEIT = 1;
        private static int employeeNumber = 0;
        public Persoon Employee { get; set; }
        public int Anciënniteit { get; set; }
        public double TotalSalary { get; private set; }
        public Prestaties Prestatie { get; set; }

        public Werknemer(Persoon employee, int anciënniteit, Prestaties prestatie)
        {
            this.Employee = employee;
            this.Anciënniteit = anciënniteit;
            this.Prestatie = prestatie;
            employeeNumber += employeeNumber + 1;
            TotalSalary = CalculateSalary();
        }
        public Werknemer(Persoon employee) : this(employee, BASIS_ANCTIENNITEIT, Prestaties.Voldoende)
        {
        }

        private double CalculateSalary(DateTime testMoment)
        {
            if (Prestaties.Voldoende == this.Prestatie)
            {
                int totalYears = testMoment.Year - DateTime.Today.Year;
                return STANDARDSALARY * (Anciënniteit + totalYears);
            }
            else
            {
                return STANDARDSALARY;
            }
        }

        private double CalculateSalary()
        {
            return CalculateSalary(DateTime.Today);
        }


        public override string ToString()
        {
            string str = String.Format("F{0}",employeeNumber);
            return "Employee " + str + ": \n\t" + this.Employee + "\n\tPrestatie: " + this.Prestatie + "\n\tSalary: " + CalculateSalary(); ;
        }
    }
}
