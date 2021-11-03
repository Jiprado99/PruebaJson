using Datos;
using Datos.Abstracciones;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Procesador : ICreaCancion
    {
        public Procesador(string nombre, string album, string[] artistas, string duracion, string fechaSalida)
        {
            Cancion = new Cancion(nombre, album, artistas, duracion, fechaSalida);
        }

        public void Crear()
        {
            var guardador = new Guardador(Cancion);
            guardador.Guardar();
        }

        public Cancion Cancion { get; }
    }
}
