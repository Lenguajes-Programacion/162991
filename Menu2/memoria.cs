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
            Console.WriteLine(result);
        }
    }
}