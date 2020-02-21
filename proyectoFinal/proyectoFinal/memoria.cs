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
            foreach(var item in dbObject)
            {
                Console.WriteLine("Dato de Memoeria: \n");
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine(result);
        }
    }
}