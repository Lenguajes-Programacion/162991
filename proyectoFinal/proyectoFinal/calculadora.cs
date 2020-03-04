using System;

namespace entregaUno
{
  class Calculadora
  {
            int ninten;
            double numeroUno;
            double numeroDos;
            double resultado;
            double resultadoDos;
            double resSumaAnt;
            
            public void calcular()
            {
            do
            {

                Console.WriteLine("Buenas Tardes, porfavor escriba la operacion que desea realizar\n" +
                    "Opcion 1: Suma\n" +
                    "Opcion 2: Resta\n" +
                    "Opcion 3: Multipilcacion\n" +
                    "Opcion 4: Division\n" +
                    "Opcion 5: Salir\n" + 
                    "Resultado Anterior: " + resultado);

                   


                ninten = Convert.ToInt32(Console.ReadLine());

                switch (ninten)
                {
                    case 1:

                        Console.WriteLine("es una suma\n");
                        Console.WriteLine("Porfavor escriba el primer numero a sumar: \n");
                        numeroUno = Convert.ToDouble(Console.ReadLine());


                        Console.WriteLine("Porfavor escriba el segundo numero a sumar: \n");
                        numeroDos = Convert.ToDouble(Console.ReadLine());

                        

                        Console.WriteLine("Presione 1 para realizar la operación \n" + "Presione 2 para realizar una nueva suma con el resultado de la opereación anterior"
                        );

                        resSumaAnt = Convert.ToDouble(Console.ReadLine());

                        if(resSumaAnt == 1)
                        {
                          resultado = numeroUno + numeroDos;
                          Console.WriteLine("el resultado es: \n" + resultado);
                        
                        }
                       else
                       {
                         Console.WriteLine("El resultado anterior es: " + resultado + "\n");

                        Console.WriteLine("Agregue el numero que desea sumar con el resultado anterior");
                        numeroUno = Convert.ToDouble(Console.ReadLine());

                        resultadoDos = resultado + numeroUno;

                        Console.WriteLine("El resultado es: " + resultadoDos);

                       }
                        break;

                    case 2:
                        Console.WriteLine("es una resta\n");
                        Console.WriteLine("Porfavor escriba el primer numero a restar: \n");
                        numeroUno = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Porfavor escriba el segundo numero a restar: \n");
                        numeroDos = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Presione 1 para realizar la operación \n" + "Presione 2 para realizar una nueva resta con el resultado de la opereación anterior"
                        );

                        resSumaAnt = Convert.ToDouble(Console.ReadLine());

                        if(resSumaAnt == 1)
                        {
                          resultado = numeroUno - numeroDos;
                          Console.WriteLine("el resultado es: \n" + resultado);
                        
                        }
                       else
                       {
                         Console.WriteLine("El resultado anterior es: " + resultado + "\n");

                        Console.WriteLine("Agregue el numero que desea restar con el resultado anterior");
                        numeroUno = Convert.ToDouble(Console.ReadLine());

                        resultadoDos = resultado - numeroUno;

                        Console.WriteLine("El resultado es: " + resultadoDos);

                       }

                        
                        break;

                    case 3:
                        Console.WriteLine("Es una multiplicación \n");
                        Console.WriteLine("Porfavor escriba el primer numero a multiplicar: \n");
                        numeroUno = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Porfavor escriba el segundo numero a multiplicar: \n");
                        numeroDos = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Presione 1 para realizar la operación \n" + "Presione 2 para realizar una nueva multiplicacion con el resultado de la opereación anterior"
                        );

                        resSumaAnt = Convert.ToDouble(Console.ReadLine());

                        if(resSumaAnt == 1)
                        {
                          resultado = numeroUno * numeroDos;
                          Console.WriteLine("el resultado es: \n" + resultado);
                        
                        }
                       else
                       {
                         Console.WriteLine("El resultado anterior es: " + resultado + "\n");

                        Console.WriteLine("Agregue el numero que desea multiplicar con el resultado anterior");
                        numeroUno = Convert.ToDouble(Console.ReadLine());

                        resultadoDos = resultado * numeroUno;

                        Console.WriteLine("El resultado es: " + resultadoDos);

                       }
                        

                        break;

                    case 4:
                        Console.WriteLine("es una division \n");
                        Console.WriteLine("Porfavor escriba el  numero dividendo: \n");
                        numeroUno = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Porfavor escriba el numero divisor: \n");
                        numeroDos = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Presione 1 para realizar la operación \n" + "Presione 2 para realizar una nueva division con el resultado de la opereación anterior"
                        );

                        resSumaAnt = Convert.ToDouble(Console.ReadLine());

                        if(resSumaAnt == 1)
                        {
                          resultado = numeroUno / numeroDos;
                          Console.WriteLine("el resultado es: \n" + resultado);
                        
                        }
                       else
                       {
                         Console.WriteLine("El resultado anterior es: " + resultado + "\n");

                        Console.WriteLine("Agregue el numero que desea dividir con el resultado anterior");
                        numeroUno = Convert.ToDouble(Console.ReadLine());

                        resultadoDos = numeroUno / resultado;

                        Console.WriteLine("El resultado es: " + resultadoDos);

                       }
                         break;

                    

                    case 5:

                        Console.WriteLine("¡Nos vemos Luego!");
                        break;



                    default:
                        Console.WriteLine("Los argumentos no cuentan como operador valido");
                        break;
                }


            } while (ninten != 5);
            }
  }
}