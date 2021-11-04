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
            
            var filePath = Path.Combine(Environment
                .GetFolderPath(Environment.SpecialFolder.MyDocuments)
                , "CancionJson/CancionJson.json");
            File.Delete(filePath);
            CreadorFile.Crear(Path.Combine(Environment
                .GetFolderPath(Environment.SpecialFolder.MyDocuments)
                , "CancionJson"), filePath);
            string cancionJson = JsonConvert.SerializeObject(Cancion.ToArray(), Formatting.Indented);
            File.AppendAllText(filePath, cancionJson);
        }

        public List<Cancion> Cancion { get; }
    }
}
