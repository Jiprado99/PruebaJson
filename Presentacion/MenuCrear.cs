using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    static public class MenuCrear
    {
        static public void Mostrar()
        {
            Console.Clear();
            Console.WriteLine("-Menu registrar Cancion-" + Environment.NewLine);
            Console.WriteLine("Ingrese el nombre de la canción:");
            var nombre = Console.ReadLine();
            Console.WriteLine(Environment.NewLine + "Ingrese el nombre del artista:");
            var artistas = Console.ReadLine();
            Console.WriteLine(Environment.NewLine + "Ingrese la duración de la cancion en formato minutos:segundos:");
            var duracion = Console.ReadLine();
            Console.WriteLine(Environment.NewLine + "Ingrese el nombre del album:");
            var album = Console.ReadLine();
            Console.WriteLine(Environment.NewLine + "Ingrese la fecha de salida en formato dia/mes/año:");
            var fechaSalida = Console.ReadLine();
            var procesador = new Procesador(nombre, album, artistas, duracion, fechaSalida);
            procesador.Crear();
            Presentacion.Presentar();
        }
    }
}
