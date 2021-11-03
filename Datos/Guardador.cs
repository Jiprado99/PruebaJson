using Datos.Abstracciones;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Guardador : IGuardaCancion
    {
        public Guardador(Cancion cancion)
        {
            Cancion = cancion;
        }

        public void Guardar()
        {

        }

        public Cancion Cancion { get; }
    }
}
