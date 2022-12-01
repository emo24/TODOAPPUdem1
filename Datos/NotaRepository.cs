using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOAPPUdem1.Datos
{
    internal  class NotaRepository
    {

        public const string ruta = @"C:\Users\gabri\Desktop\TODOAPPUdem1\Datos\Notas.json";
        public static List<Notas> notas { get; set; } = new List<Notas>();


        public static void añadirnota(Notas nota)
        {

            notas.Add(nota);
            string json = JsonConvert.SerializeObject(notas, Formatting.Indented);
            File.WriteAllText(ruta, json);

        }

        public static List<Notas> ListarNota()
        {


            return notas;


        }
        public static void eliminarnota(int id)
        {
            notas.RemoveAll(n => n.ID.Equals(id));
            string json = JsonConvert.SerializeObject(notas, Formatting.Indented);
            File.WriteAllText(ruta, json);
        }

        public static void actualizarnota(int codorigen, Notas notamodificada)
        {
            int indicenotaoriginal = 0;
            notas.FindIndex(n => n.ID == indicenotaoriginal);
            if (indicenotaoriginal !=-1)
            {
                notas[indicenotaoriginal] = notamodificada;
            }
            string json = JsonConvert.SerializeObject(notas, Formatting.Indented);
            File.WriteAllText(ruta, json);


        }


    }
}
