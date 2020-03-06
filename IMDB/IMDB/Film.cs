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
        public List<int> Rating;
        public List<Acteur> Acteurs;

        public Film(string title, string producer, string director, Gernes gerne, int rating)
        {
            Rating = new List<int>();
            Acteurs = new List<Acteur>();
            Title = title;
            Producer = producer;
            Director = director;
            Gerne = gerne;
            AddRating(rating);
        }

        public Film(string title, string producer, string director, Gernes gerne) : this(title, producer, director, gerne, DEFAULT_RATING)
        {
        }

        public void AddRating(int rating)
        {
            try
            {
                if (rating > 0 && rating <= 5)
                {
                    Rating.Add(rating);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Fout.");
            }

        }

        public void AddActor(Acteur actor)
        {
            try
            {
                if (actor != null)
                {
                    this.Acteurs.Add(actor);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Fout.");
            }

        }

        private int GemRating()
        {
            int result = 0;
            int aantal = 0;
            foreach (int rating in Rating)
            {
                if (rating != 5 || rating != 1)
                {
                    result += rating;
                    aantal++;
                }
            }
            return result / aantal;
        }

        public override string ToString()
        {
            return "Title: " + this.Title + "\nGerne: " + this.Gerne + "\nProducer: " + this.Producer + "\nDirector: " + this.Director + "\nRating: " + GemRating();
        }
    }
}
