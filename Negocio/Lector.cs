using Datos;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class Lector
    {
        public static List<Cancion> Leer()
        {
            if (Recuperador.Recuperar() != null)
                return Recuperador.Recuperar();
            else
                return new List<Cancion>();
        }
    }
}
