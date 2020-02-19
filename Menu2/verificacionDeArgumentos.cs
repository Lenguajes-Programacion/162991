using System;
namespace entregaUno
{
  class verificacionDeArgumentos
  {
    public void usuarioContrasena()

    {
            string usuario;
            int contrasena;
            string nombreUsuario = "Jesus Recendiz";
            int contrasenaUsuario = 1234;

            Console.WriteLine("Porfavor escriba el nombre de usuario\n");
            
            usuario = Console.ReadLine();

            if(nombreUsuario == usuario)
            {
              Console.WriteLine("Nombre de usuario correcto, porfavor escriba la contraseña\n");

              contrasena = Convert.ToInt32(Console.ReadLine());

              if(contrasenaUsuario == contrasena)
              {
                Console.WriteLine("La contraseña es correcta, bienvenido\n");
              }

              else
              {
                Console.WriteLine("La contraseña es incorrecta\n");
              }

            }
            else 
            {
              Console.WriteLine("El nombre de usuario es incorrecto\n");
            }
    }

  }


}