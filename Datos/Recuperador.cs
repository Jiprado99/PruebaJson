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
    static public class Recuperador
    {
        static public Cancion[] Recuperar()
        {
            return JsonConvert.DeserializeObject<Cancion[]>(Read());
        }

        static private string Read()
        {
            var filePath = Path.Combine(Environment
                .GetFolderPath(Environment.SpecialFolder.MyDocuments)
                , "CancionJson/CancionJson.json");
            string cancionJson;
            using (var reader = new StreamReader(filePath))
            {
                cancionJson = reader.ReadToEnd();
            }
            return cancionJson;
        }
    }
}
