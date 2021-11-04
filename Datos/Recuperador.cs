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
        static public List<Cancion> Recuperar()
        {
            var canciones = Read();
            var deserializeCanciones = new List<Cancion>();
            if (canciones != null)
            {
                deserializeCanciones = JsonConvert.DeserializeObject<List<Cancion>>(canciones);
            }
            return deserializeCanciones;
        }

        static private string Read()
        {
            var folderPath = Path.Combine(Environment
                .GetFolderPath(Environment.SpecialFolder.MyDocuments)
                , "CancionJson");
            var filePath = Path.Combine(folderPath, "CancionJson.json");
            if (File.Exists(filePath) && Directory.Exists(folderPath))
            {
                string cancionJson;
                using (var reader = new StreamReader(filePath))
                {
                    cancionJson = reader.ReadToEnd();
                }
                return cancionJson;
            }
            else return null;
        }
    }
}
