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
        private List<int> ratings;
        private List<Acteur> acteurs;

        public Serie(string titel, int aantalSeizoenen, int rating)
        {
            ratings = new List<int>();
            acteurs = new List<Acteur>();
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
                this.ratings.Add(rating);
            }
        }

        public void AddActor(Acteur actor)
        {
            if (actor != null)
            {
                this.acteurs.Add(actor);
            }
        }

        private double GemRating()
        {
            int totalRatings = 0;
            int aantal = ratings.Count;
            ratings.Sort();

            //1 hoogste en 1 laagste wegvallen
            // let op: volgorde van lijst 3 2 5 1 2
            if (aantal > 2)
            {
                for (int i = 1; i < aantal - 1; i++)
                {
                    totalRatings += ratings[i];
                }
            }
            else if (aantal < 2 && aantal > 0)
            {
                for (int i = 0; i < aantal; i++)
                {
                    totalRatings += ratings[i];
                }
            }
            else
            {
                throw new DivideByZeroException("Er zijn nog geen ratings");
            }
            return totalRatings / aantal;

        }

        public override string ToString()
        {
            return "Title: " + this.Titel + "\nSeasons: " + this.AantalSeizoenen + "\nRating: " + GemRating();
        }
    }
}
