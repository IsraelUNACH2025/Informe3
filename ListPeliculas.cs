using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informe3
{
    public class ListPeliculas
    {
        public List<Peliculas> Lista { get; set; }
        public ListPeliculas()
        {
            Lista = new List<Peliculas>();
        }
        public void Agregar(Peliculas pelicula)
        {
            Lista.Add(pelicula);
        }
        public List<Peliculas> TituloEmpieza(string cadena)
        {

            List<Peliculas> listaAux = new List<Peliculas>();
            for (int i = 0; i < Lista.Count; i++)
            {
                if (Lista[i].Titulo.StartsWith(cadena))
                {
                    listaAux.Add(Lista[i]);
                }
            }
            return listaAux;
        }

        public List<Peliculas> IgualDirector(string cadena)
        {
            List<Peliculas> listAux = new List<Peliculas>();
            foreach (Peliculas persona in Lista)
            {
                if (persona.Director.Equals(cadena))
                {
                    listAux.Add(persona);
                }
            }
            return listAux;
        }

    }
}
