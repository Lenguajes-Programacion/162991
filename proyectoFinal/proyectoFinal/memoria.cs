using Newtonsoft.Json.Linq;
using System.IO;
using System;

namespace entregaUno
{
    class memoria
    {
        public void leerMemoria()
        {
            string archivoDB = "../../../db.json";
            StreamReader reader = new StreamReader(archivoDB);
            var dbJSON = reader.ReadToEnd();
            var dbObject = JObject.Parse(dbJSON);
            var result = dbObject.ToString();
            foreach ((var key, var item) in dbObject)
            {
                Console.WriteLine("Dato de Memoria: \n");
                MemoriaData memoriaData01 = new MemoriaData(DateTime.Now, item.Value["operacion"].ToString(), (int) item.Value["resultado"]);
                Console.WriteLine(item.Key.ToString());
                Console.WriteLine(memoriaData01.resultado.ToString());
            }
            Console.WriteLine(result);
        }

      
    }


    class MemoriaData
    {
        public DateTime fecha;
        public string operacion;
        public int resultado;

        public MemoriaData(DateTime date, string operation, int result)
        {
            fecha = date;
            operacion = operation;
            resultado = result;

        }

    }
}