using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public static class CreadorFile
    {
        public static void Crear(string path, string file)
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            if (!File.Exists(file))
                File.Create(file);
        }
    }
}
