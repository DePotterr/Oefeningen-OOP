using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streaming_app
{
    public enum PlaatsenWerkzaam { België, Nederland, Luxemburg }
    class StreamingApp
    {
        public string Naam { get; set; }
        public PlaatsenWerkzaam PlaatsWerkzaam { get; set; }
        public List<Media> Media { get; set; }

    }
}
