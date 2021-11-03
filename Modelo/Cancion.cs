using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Cancion
    {
        public Cancion(string nombre, string album, string[] artistas, string duracion, string fechaSalida)
        {
            Nombre = nombre;
            Album = album;
            Artistas = artistas;
            Duracion = duracion;
            FechaSalida = fechaSalida;
        }

        public string Nombre { get; }
        public string Album { get; }
        public string[] Artistas { get; }
        public string Duracion { get; }
        public string FechaSalida { get; }

    }
}
