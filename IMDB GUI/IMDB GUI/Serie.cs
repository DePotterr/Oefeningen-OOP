using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB_GUI
{
    class Serie : Media
    {
        const int DEFAULT_RATING = 5;
        public int AantalSeizoenen { get; set; }

        public Serie(string titel, int aantalSeizoenen, string producer, string director, int rating) : base(titel,producer,director)
        {
            AantalSeizoenen = aantalSeizoenen;
            AddRating(rating);
        }

        public Serie(string titel, int aantalSeizoenen) : this(titel, aantalSeizoenen,"test","test", DEFAULT_RATING)
        {
        }
        public Serie(string titel) : this(titel, 6)
        {
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
