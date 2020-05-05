using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streaming_app
{
    public class Film : Media, InterfaceFilm
    {
        const int DEFAULT_RATING = 5;

        public enum Gernes { Action, Drama, Horror, Family, Kids}
        public Gernes Gerne { get; set; }

        public Film(string title, string producer, string director, Gernes gerne, int rating) : base(title,producer,director)
        {
            Gerne = gerne;
            AddRating(rating);
        }
        public Film(string title) : this(title, "test", "test", Gernes.Action, DEFAULT_RATING)
        {

        }
        public void FilmAfspelen()
        {
        }
        public void FilmStoppen()
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
