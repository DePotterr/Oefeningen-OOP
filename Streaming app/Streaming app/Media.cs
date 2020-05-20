using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streaming_app
{
    public abstract class Media : IComparable
    {
        public string Title { get; set; }
        public string Producer { get; set; }
        public string Director { get; set; }
        private List<int> ratings;
        private List<Acteur> acteurs;
        public Media(string title, string producer, string director)
        {
            Title = title;
            Producer = producer;
            Director = director;
            this.ratings = new List<int>();
            this.acteurs = new List<Acteur>();
        }
        public Media(string title) : this(title, "test", "test")
        {
        }
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
        protected double GemRating()
        {
            double totalRatings = 0;
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
                aantal = aantal - 2;
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
                aantal = 1;
            }
            return Math.Ceiling(totalRatings / aantal);
        }
        public override string ToString()
        {
            return this.Title + " " + GemRating();
        }
        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1;
            Media media = obj as Media;
            if (media == null)
                return 1;
            return this.Title.CompareTo(media.Title);
        }
    }
}
