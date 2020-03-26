using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Werknemers
{
    class Departement
    {
        public List<Werknemer> ListEmployees { get; set; }
        public Departement(List<Werknemer> listEmployees)
        {
            this.ListEmployees = listEmployees;
        }
        public Departement() : this(new List<Werknemer>())
        {
        }

        private int TotalEmployees()
        {
            return ListEmployees.Count;
        }

        public double CalculateSalaries()
        {
            double total = 0;
            int totalEmployees = TotalEmployees();
            for (int i = 0; i < totalEmployees; i++)
            {
                total += ListEmployees[i].CalculateSalary();
            }
            return total;
        }
        public override string ToString()
        {
            string allEmployees = "";
            for (int i = 0; i < TotalEmployees(); i++)
            {
                allEmployees += ListEmployees[i].ToString() + "\n";
            }
            return "Departement\nWerknemers:\n" + allEmployees;
        }
    }
}
