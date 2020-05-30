using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herhalingsoef_1
{
    public enum Geslachten { Man, Vrouw}
    public class Student
    {
        private static int studentennr = 0;
        private string voornaam;
        private string naam;
        private string adres;
        public int Studentennr { get; set; }
        public string Voornaam
        {
            get { return voornaam; }
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] == '@' || value[i] == '_' || value[i] == '\\')
                    {
                        throw new CustumExceptionStudentNaam();
                    }
                    else
                    {
                        voornaam = value;
                    }
                }
            }
        }
        public string Naam
        {
            get { return naam; }
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] == '@' || value[i] == '_' || value[i] == '\\')
                    {
                        throw new CustumExceptionStudentNaam();
                    }
                    else
                    {
                        naam = value;
                    }
                }
            }
        }
        public string Adres
        {
            get { return adres; }
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] == '@' || value[i] == '_' || value[i] == '\\')
                    {
                        throw new CustumExceptionStudentAdres();
                    }
                    else
                    {
                        adres = value;
                    }
                }
            }
        }

        public Geslachten Geslacht { get; set; }
        public List<Examen> Examens { get; set; }
        public Student(string voornaam, string naam, string adres, Geslachten geslacht)
        {
            Studentennr = ++studentennr;
            Voornaam = voornaam;
            Naam = naam;
            Adres = adres;
            Geslacht = geslacht;
        }
        public override string ToString()
        {
            return Studentennr + " " + Voornaam;
        }
    }
}
