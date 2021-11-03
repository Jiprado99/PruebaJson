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
                string artistas = "";
                foreach (var artista in cancion.Artistas)
                {
                    artistas = artistas + ", " + artista;
                    artistas = artistas.Remove(artistas.Length - 2);
                }
                Console.WriteLine($"Artista/s: {artistas}.");
            }
        }
    }
}
