using System;

namespace TrabajoFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Autenticación();
        }

        static void Autenticación()
        {
            int contraseña = 0;
            string usuario = " ";
            int rol = 0;
            int contadorError = 0;
            while (contadorError <3)
            {
                Console.WriteLine("Ingrese el nombre de usuario:");
                usuario = Console.ReadLine();
                Console.WriteLine("Ingrese su contraseña:");
                contraseña = int.Parse (Console.ReadLine());
                Console.WriteLine("¿Cuál es su rol(1/Administrador, 2/Cajero)?");
                rol = int.Parse (Console.ReadLine());
                
                if (rol == 1 || rol == 2)
                {
                    
                    Console.WriteLine($"Bienvenido/a, {usuario}");
                
                    if (rol == 1)
                    {
                        string admin = "Administrador";
                       Console.WriteLine($"Rol: {admin}");
                
                    }
                    else
                    {
                        string cajero = "Cajero";
                        Console.WriteLine($"Rol: {cajero}");
                    }
                
                
                }
                else
                {
                    Console.WriteLine("Error al ingresar el rol, vuelva a intentar");
                    contadorError++;
                    Console.ReadKey();          
                    Console.Clear();
                }

            }
            
            if (contadorError == 3)
            {
                Console.WriteLine("ERROR");
                Console.WriteLine("Contacte a soporte técnico");
            }
            
        }
    }
}
