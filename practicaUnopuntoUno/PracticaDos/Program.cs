using System;

namespace PracticaDos
{
    class Program
    {
        static void Main(string[] args)

        {
            int ninten;
            int numeroUno;
            int numeroDos;
            int resultado;
            do
            {

               
                Console.WriteLine("Buenas Tardes, porfavor escriba la operacion que desea realizar\n" +
                    "Opocion 1: Suma\n" +
                    "Opcion 2: Resta\n" +
                    "Opcion 3: Multipilcacion\n" +
                    "Opcion 4: Division\n" +
                    "Salir");
                ninten = Convert.ToInt32(Console.ReadLine());

                switch (ninten)
                {
                    case 1:

                        Console.WriteLine("es una suma\n");
                        Console.WriteLine("Porfavor escriba el primer numero a sumar: ");
                        numeroUno = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Porfavor escriba el segundo numero a sumar: ");
                        numeroDos = Convert.ToInt32(Console.ReadLine());
                        resultado = numeroUno + numeroDos;

                        Console.WriteLine("el resultado es: " + resultado); 

                        break;

                    case 2:
                        Console.WriteLine("es una resta");
                        break;

                    case 3:
                        Console.WriteLine("es una multiplicación");
                        break;

                    case 4:
                        Console.WriteLine("es una division");
                        break;

                    case 5:
                        Console.WriteLine("Hasta Luego");
                        break;


                    default:
                        Console.WriteLine("Los argumentos no cuentan como operador valido" + ninten);
                        break;
                }


            } while (ninten != 5);
        }
    }
}
