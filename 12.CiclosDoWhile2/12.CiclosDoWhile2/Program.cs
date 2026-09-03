using System;

namespace _12.CiclosDoWhile2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int saldo = 0;
            string nombre = "";
            int cuenta = 0;
            int contador = 0;
            string opción = "s";
            int acumulador = 0;
            do
            {
                contador++;
                 Console.WriteLine($"Usuario {contador}, ingrese su nombre:");
                 nombre = Console.ReadLine();
                 Console.WriteLine($"Usuario {contador}, ingrese su número de cuenta:");
                 cuenta =int.Parse( Console.ReadLine());
                 Console.WriteLine($"Usuario {contador}, ingrese su saldo:");
                 saldo = int.Parse(Console.ReadLine());
                acumulador = acumulador + saldo;

                if (saldo >= 3000000)
                {

                  Console.WriteLine(nombre);
                  Console.WriteLine(cuenta);
                  Console.WriteLine(saldo);
                  Console.WriteLine("Es apto para el crédito");

                } 

              if (saldo < 3000000)
              {
                Console.WriteLine(nombre);
                Console.WriteLine(cuenta);
                Console.WriteLine(saldo);
                Console.WriteLine("no es apto para el crédito");
              }

                 Console.WriteLine("¿añadir otro usuario? s/sí, cualquier otra letra para no");
                    opción = Console.ReadLine();
                 

            }while(opción == "s");

            Console.WriteLine($"El número de usuarios a los que se les preguntó es: {contador}");
            Console.WriteLine($"El promedio de los saldos es: {acumulador / contador}");
        }
    }
}
