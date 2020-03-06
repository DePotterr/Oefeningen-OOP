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
    }
}
