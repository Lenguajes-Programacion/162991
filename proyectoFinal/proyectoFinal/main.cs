using System;

//Entrega 100
namespace entregaUno
{
  class MainClass {
    public static void Main (string[] args) 
    {
      int opcion;
      do
      {
        Console.WriteLine("Bienvenido\n" +
        "Opcion 1: Verificación de argumentos.\n" +
        "opcion 2: Calculadora.\n" +
        "Opcion 3: Memoria\n" +
        "Opcion 4: Salida\n" );
        opcion = Convert.ToInt32(Console.ReadLine());
      
        switch(opcion)
        {
          case 1:
            verificacionDeArgumentos usuario1 = new verificacionDeArgumentos();
            usuario1.usuarioContrasena();
          break;

          case 2:
            Calculadora calculadora1 = new Calculadora();
            calculadora1.calcular();
          break;

          case 3:
            memoria memo01 = new memoria();
            memo01.leerMemoria();

            break;
             

          case 4:
            Console.WriteLine("Yare Yare Daze");
          break;

          default:
          Console.WriteLine("La opción es invalida");
          break;      
        }

      } while(opcion != 4);  
    }
  }
}