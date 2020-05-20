using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Streaming_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Media> medias = new List<Media>();
            medias.Add(new Film("film1"));
            medias.Add(new Serie("serie1"));
            medias.Add(new Film("film2"));
            medias.Add(new Serie("serie2"));
            medias.Add(new Film("film3"));
            medias.Add(new Serie("serie3"));
            medias.Add(new Film("azertyfilm"));
            medias.Add(new Serie("azertyserie"));
            medias.Add(new Film("hf"));
            medias.Add(new Serie("us"));
            medias.Add(new Film("The Avengers"));
            medias.Add(new Serie("Breaking Bad"));
            medias.Sort();
            listBox1.DataSource = medias;
        }

    }
}
