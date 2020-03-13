using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace entregaUno
{
    class Memoria
    {
        //lista de la clase MemoriaData de nombre db//
        public List<MemoriaData> db = new List<MemoriaData>();
        public Memoria()
        { //constructor de la clase Memoria//

            db = new List<MemoriaData>();
        }

    public void leerMemoria()
        {
            
            string archivoDB = "../../../db.json";
            StreamReader reader = new StreamReader(archivoDB);
            var dbJSON = reader.ReadToEnd();
            JObject dbObject = JObject.Parse(dbJSON);
            int i = 0;
            foreach (var item in dbObject)
            {
                Console.WriteLine("Dato en memoria: ", i); 
                MemoriaData memoriaData01 = new MemoriaData(item.Key.ToString(), item.Value["operacion"].ToString(), item.Value["resultado"].ToString());
                this.db.Add(memoriaData01);
                Console.WriteLine(memoriaData01.fecha.ToString());//parse analiza cadenas y lo convierte a lo que se desea https://www.kyocode.com/2019/06/metodo-parse-clase-convert-c/

                Console.WriteLine("operacion realizada:");
                Console.WriteLine(memoriaData01.operacion.ToString());
                Console.WriteLine("resultado de la operacion : ");
                // Console.WriteLine(item.key.ToString());
                Console.WriteLine(memoriaData01.resultado.ToString());

                i++;
            }
           
        }

        public void arreglo()
        {
            string[] colores00 = { "rojo", "blanco", "morado" };
            // List<string> Colores = ["rojo", "blanco", "morado"];

            Console.WriteLine(colores00);
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