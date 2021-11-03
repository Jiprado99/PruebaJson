using Infraestructura;
using System;
using Autofac;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Negocio;

namespace Presentacion
{
    class Presentacion
    {
        static void Main(string[] args)
        {
            AFac.AlRegistrarComponentes += AFac_AlRegistrarComponentes;
            AFac.Registrar();
            Presentar();
        }

        static void AFac_AlRegistrarComponentes(object sender
            , ContainerBuilder builder)
        {
        }

            static void Presentar()
        {
            Console.WriteLine("Ingrese el nombre de la canción:");
            var nombre = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Ingrese los nombres de las Bandas o Artistas intérpretes, presione ESC para finalizar");
            var artistas = Artistas();
            Console.WriteLine();
            Console.WriteLine("Ingrese la duración de la cancion en formato minutos:segundos:");
            var duracion = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Ingrese el nombre del album:");
            var album = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Ingrese la fecha de salida en formato dia/mes/año:");
            var fechaSalida = Console.ReadLine();

            
            var procesador = new Procesador(nombre, album, artistas, duracion, fechaSalida);
            procesador.Crear();
        }

        static string[] Artistas()
        {
            var artistas = new List<string>();

            return artistas.ToArray();
        }
    }
}
