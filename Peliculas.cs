using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informe3
{
    public class Peliculas
    {
        public string Titulo { get; set; }
        public int AnioEstreno { get; set; }
        public string Director { get; set; }
        public Peliculas() { }
        public Peliculas (string titulo, int anioEstreno, string director)
        {
            Titulo = titulo;
            AnioEstreno = anioEstreno;
            Director = director;
        }

    }
}

