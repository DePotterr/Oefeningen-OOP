using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMDB_GUI
{
    public partial class Dashboard : Form
    {
        List<Film> films = new List<Film>();
        List<Serie> series = new List<Serie>();
        
        public Dashboard()
        {
            InitializeComponent();
            serieFilmComboBox.DataSource = films;
        }

        private void FilmButton_Click(object sender, EventArgs e)
        {
            films.Add(new Film(filmTextBoc.Text));
            RefreshFilms();
        }

        private void SerieButton_Click(object sender, EventArgs e)
        {

        }

        private void RatingButton_Click(object sender, EventArgs e)
        {

        }
        private void RefreshFilms()
        {
            serieFilmComboBox.DataSource = null;
            serieFilmComboBox.DataSource = films;
        }
    }
}
