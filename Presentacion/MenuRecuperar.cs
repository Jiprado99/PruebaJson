using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    static public class MenuRecuperar
    {
        static public void Mostrar() 
        {
            Console.Clear();
            Console.WriteLine("Las canciones registradas son:");
            Console.WriteLine();
            var canciones = Recuperador.Recuperar();
            foreach (var cancion in canciones)
            {
                Console.WriteLine();
                Console.WriteLine($"Nombre: {cancion.Nombre}.");
                Console.WriteLine($"Artista: {cancion.Artistas}.");
                Console.WriteLine($"Album: {cancion.Album}.");
                Console.WriteLine($"Duracion: {cancion.Duracion}.");
                Console.WriteLine($"Fecha de salida: {cancion.FechaSalida}.");
            }
            Console.WriteLine();
            Console.WriteLine("Presione Enter para volver al menú principal");
            var tecla = Console.ReadKey(true).Key;
            while (tecla != ConsoleKey.Enter)
            {
                tecla = Console.ReadKey(true).Key;
            }
            Presentacion.Presentar();
        }
    }
}
