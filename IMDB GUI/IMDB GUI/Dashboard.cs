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
        //List<Media> mediabestanden = new List<Media>();
        bool isFilm;
        
        public Dashboard()
        {
            InitializeComponent();
            filmRadioButton.Checked = true;
            ratingComboBox.Enabled = false;
            serieFilmComboBox.Enabled = false;
            ratingButton.Enabled = false;
        }
        private void ToevoegenButton_Click(object sender, EventArgs e)
        {
            if (isFilm)
            {
                films.Add(new Film(naamTextBox.Text));
                RefreshFilms();
            }
            else
            {
                series.Add(new Serie(naamTextBox.Text));
                RefreshSeries();
            }
        }

        private void RatingButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (isFilm)
                {
                    Film geselecteerde = (Film)serieFilmComboBox.SelectedItem;
                    geselecteerde.AddRating(int.Parse(ratingComboBox.SelectedItem.ToString()));
                    RefreshFilms();
                }
                else
                {
                    Serie geselecteerde = (Serie)serieFilmComboBox.SelectedItem;
                    geselecteerde.AddRating(int.Parse(ratingComboBox.SelectedItem.ToString()));
                    RefreshSeries();
                }
                //Media geselecteerde = (Media)serieFilmComboBox.SelectedItem;
                //geselecteerde.AddRating(int.Parse(ratingComboBox.SelectedItem.ToString()));
                //if (isFilm)
                //{
                //    RefreshFilms();
                //}
                //else
                //{
                //    RefreshSeries();
                //}
            }
            catch
            {

            }

        }
        private void RefreshFilms()
        {
            serieFilmComboBox.DataSource = null;
            serieFilmComboBox.DataSource = films;
            if (films.Count > 0)
            {
                ratingComboBox.Enabled = true;
                serieFilmComboBox.Enabled = true;
                ratingButton.Enabled = true;
                serieFilmComboBox.SelectedIndex = 0;
            }
            else
            {
                ratingComboBox.Enabled = false;
                serieFilmComboBox.Enabled = false;
                ratingButton.Enabled = false;
            }
        }
        private void RefreshSeries()
        {
            serieFilmComboBox.DataSource = null;
            serieFilmComboBox.DataSource = series;
            if (series.Count > 0)
            {
                ratingComboBox.Enabled = true;
                serieFilmComboBox.Enabled = true;
                ratingButton.Enabled = true;
                serieFilmComboBox.SelectedIndex = 0;
            }
            else
            {
                ratingComboBox.Enabled = false;
                serieFilmComboBox.Enabled = false;
                ratingButton.Enabled = false;
            }
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            isFilm = filmRadioButton.Checked;
            if (isFilm)
            {
                filmSerieLabel.Text = "Film toevoegen";
                RefreshFilms();
            }
            else
            {
                filmSerieLabel.Text = "Serie toevoegen";
                RefreshSeries();
            }
        }
    }
}
