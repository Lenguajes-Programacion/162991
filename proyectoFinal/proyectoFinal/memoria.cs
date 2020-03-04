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
            JObject dbObject = JObject.Parse(dbJSON);
          
            foreach ((var key,var item) in dbObject)
            {
                Console.WriteLine("Dato de Memoria: \n");
                MemoriaData memoriaData01 = new MemoriaData(DateTime.Today, item["Operacion"].ToString(),(int) item["Resultado"]);
                DateTime convertir = DateTime.Parse(key);
                Console.WriteLine(convertir);//parse analiza cadenas y lo convierte a lo que se desea https://www.kyocode.com/2019/06/metodo-parse-clase-convert-c/

                Console.WriteLine("operacion realizada:");
                Console.WriteLine(memoriaData01.operacion.ToString());
                Console.WriteLine("resultado de la operacion : ");
                // Console.WriteLine(item.key.ToString());
                Console.WriteLine(memoriaData01.resultado.ToString());
            }
           
        }

      
    }


    class MemoriaData
    {
        public DateTime fecha;
        public String operacion;
        public double resultado;

        public MemoriaData(String date, String operation, String result)
        {
            fecha = DateTime.Parse(date);
            operacion = operation;
            resultado = int.Parse(result);

        }

    }
}