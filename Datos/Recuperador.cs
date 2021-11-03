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
    public class Recuperador
    {
        public Cancion[] Recuperar()
        {
            return JsonConvert.DeserializeObject<Cancion[]>(Read());
        }

        private string Read()
        {
            string cancionJson;
            using (var reader = new StreamReader($"C:/Jprado/JsonAlfajor/Alfajores.json"))
            {
                cancionJson = reader.ReadToEnd();
            }
            return cancionJson;
        }
    }
}
