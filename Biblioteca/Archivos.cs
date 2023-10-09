using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Biblioteca
{
   public class Archivos
    {
    
        public static void WriteStreamJson(string file, List<Estudiante> listaEstudiante)
        {
            using (var writer = new StreamWriter(Combine(file)))
            {
                var options = new JsonSerializerOptions();
                options.WriteIndented = true;
                var json = JsonSerializer.Serialize(listaEstudiante, options);

                writer.Write(json);
            }
        }

        public static void WriteStreamJson(string file, List<Curso> listaCursos)
        {
            using (var writer = new StreamWriter(Combine(file)))
            {
                var options = new JsonSerializerOptions();
                options.WriteIndented = true;
                var json = JsonSerializer.Serialize(listaCursos, options);

                writer.Write(json);
            }
        }
         public static List<T> ReadStreamJson<T>(string file)
        {
            var path = Combine(file);
            var lista = new List<T>();

            if (File.Exists(path))
            {
                using (var reader = new StreamReader(path))
                {
                    var json = reader.ReadToEnd();
                    var listaAux = JsonSerializer.Deserialize<List<T>>(json);

                    if (listaAux != null)
                    {
                        lista = listaAux;
                    }
                 }
            }

            return lista;
        }

       
        private static string Combine(string path1)
        {
            Environment.SpecialFolder escritorio = Environment.SpecialFolder.DesktopDirectory;
            var desktop = Environment.GetFolderPath(escritorio);
            var path = Path.Combine(desktop, "listado estudiantes", path1);

            return path;

        }

      
    }
}
