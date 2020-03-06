using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB
{
    class Film
    {
        const int DEFAULT_RATING = 5;

        public enum Gernes { Action, Drama, Horror, Family, Kids}
        public string Title { get; set; }
        public string Producer { get; set; }
        public string Director { get; set; }
        public Gernes Gerne { get; set; }
        private List<int> ratings;
        private List<Acteur> acteurs;

        public Film(string title, string producer, string director, Gernes gerne)
        {
            ratings = new List<int>();
            acteurs = new List<Acteur>();
            Title = title;
            Producer = producer;
            Director = director;
            Gerne = gerne;
        }

        //public Film(string title, string producer, string director, Gernes gerne) : this(title, producer, director, gerne)
        //{
        //}

        public void AddRating(int rating)
        {
            if (rating > 0 && rating <= 5)
            {
                ratings.Add(rating);
            }
            else
            {
                throw new Exception("Foute rating");
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
            else if (aantal <= 2 && aantal > 0)
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
            return "Title: " + this.Title + "\nGerne: " + this.Gerne + "\nProducer: " + this.Producer + "\nDirector: " + this.Director + "\nRating: " + GemRating();
        }
    }
}
