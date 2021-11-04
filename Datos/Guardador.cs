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
        public Guardador(List<Cancion> cancion)
        {
            Cancion = cancion;
        }

        public void Guardar()
        {
            var folderPath = Path.Combine(Environment
                .GetFolderPath(Environment.SpecialFolder.MyDocuments)
                , "CancionJson");
            var filePath = Path.Combine(folderPath, "CancionJson.json");
            File.Delete(filePath);
            CreadorCarpeta.Crear(folderPath);
            string cancionJson = JsonConvert.SerializeObject(Cancion.ToArray(), Formatting.Indented);
            File.AppendAllText(filePath, cancionJson);
        }

        public List<Cancion> Cancion { get; }
    }
}
