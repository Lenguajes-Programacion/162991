using System;

namespace practicaUnopuntoUno
{
    class Program
    {
        static string nombre = "Jesus";
        static void Main(string[] args)
        {
            if (args[0].Length >0 && args[0] == nombre)

            {
                Console.WriteLine($"Hello World! {args[0]} {args[1]}");
            } 
            else
            {
                Console.WriteLine("Usuario Desconocido");
            }
        }
    }
}
