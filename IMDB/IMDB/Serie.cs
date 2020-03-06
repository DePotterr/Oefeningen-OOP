using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB
{
    class Serie
    {
        const int DEFAULT_RATING = 5;
        public string Titel { get; set; }
        public int AantalSeizoenen { get; set; }
        public List<int> Rating;
        public List<Acteur> Acteurs;

        public Serie(string titel, int aantalSeizoenen, int rating)
        {
            Rating = new List<int>();
            Acteurs = new List<Acteur>();
            Titel = titel;
            AantalSeizoenen = aantalSeizoenen;
            AddRating(rating);
        }

        public Serie(string titel, int aantalSeizoenen) : this(titel, aantalSeizoenen, DEFAULT_RATING)
        {}

        public void AddRating(int rating)
        {
            if (rating > 0 && rating <= 5)
            {
                this.Rating.Add(rating);
            }
        }

        public void AddActor(Acteur actor)
        {
            if (actor != null)
            {
                this.Acteurs.Add(actor);
            }
        }

        private int GemRating()
        {
            int result = 0;
            int aantal = 0;
            foreach(int rating in Rating)
            {
                if(rating != 5 || rating != 1)
                {
                    result += rating;
                    aantal++;
                }
            }
            return result / aantal;
        }

        public override string ToString()
        {
            return "Title: " + this.Titel + "\nSeasons: " + this.AantalSeizoenen + "\nRating: " + GemRating();
        }
    }
}
