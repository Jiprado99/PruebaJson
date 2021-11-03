using Datos.Abstracciones;
using Modelo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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
            var folderName = Path.Combine(Environment
                .GetFolderPath(Environment.SpecialFolder.MyDocuments)
                , "CancionJson");
            string alfajorJson = JsonConvert.SerializeObject(Cancion, Formatting.Indented);
            File.AppendAllText(folderName, alfajorJson);
        }

        public Cancion Cancion { get; }
    }
}
