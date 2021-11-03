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

            public static void Presentar()
        {
            Console.Clear();
            Console.WriteLine("Bienvenido al registro de canciones!");
            Console.WriteLine();
            Console.WriteLine("-Menu principal-");
            Console.WriteLine();
            Console.WriteLine("Comandos disponibles:");
            Console.WriteLine("- Registrar");
            Console.WriteLine("          Permite registrar una nueva canción en el sistema.");
            Console.WriteLine("- Ver");
            Console.WriteLine("          Permite ver las canciones cargadas en el sistema.");

            bool comandoIncorrecto = true;

            while (comandoIncorrecto != false)
            {
                switch (Console.ReadLine().ToLower())
                {
                    case "registrar":
                        MenuCrear.Mostrar();
                        break;
                    case "ver":
                        MenuRecuperar.Mostrar();
                        break;
                    case "salir":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("El Comando ingresado es incorrecto");
                        comandoIncorrecto = true;
                        break;
                }
            }
        }
    }
}
