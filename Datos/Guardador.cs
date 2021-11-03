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
            var filePath = Path.Combine(Environment
                .GetFolderPath(Environment.SpecialFolder.MyDocuments)
                , "CancionJson/CancionJson.json");
            string cancionJson = JsonConvert.SerializeObject(Cancion, Formatting.Indented);
            File.AppendAllText(filePath, cancionJson);
        }

        public Cancion Cancion { get; }
    }
}
