using System;
using System.Security.Cryptography;

namespace _14.TallerCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Algoritmo que permita calcular el promedio de calificaciones, el algoritmo le permitirá al usuario, introducir tantas calificaciones como así desee, en el momento en que seleccione que no desea continuar capturando calificaciones, el algoritmo debe presentar el promedio de las calificaciones capturadas previamente. 
            
            //int calificacion = 0;
            //string opción = "s";
            //float acumulador = 0;
            //int contador = 0;

            //do
            //{

            //    Console.WriteLine("Ingrese una calificación:");
            //    calificacion = int.Parse (Console.ReadLine());
            //    acumulador = acumulador + calificacion;
            //    contador++;
            //    Console.WriteLine("¿añadir otra calificación? s/sí, cualquier otra letra para no");
            //    opción = Console.ReadLine();

            //} while (opción == "s");

            //Console.WriteLine($"el promedio de las calificaciones es: {acumulador / contador}");











            //3. Dados dos números enteros ingresados por teclado: b que es la base y 
            //     e que es el exponente, se requiere calcular el resultado de la
            //     potenciación.
            //     Ejemplo: b = 2, e = 5  25 = 2 * 2 * 2 * 2 * 2 = 32
            //     Mostrar por pantalla el resultado de la potenciación. 
            //     Seguir pidiendo por teclado la base y el exponente y realizar la
            //     potenciación correspondiente, hasta que el usuario ingrese por teclado
            //     el carácter de escape ‘n’

            int b = 0;
            int e = 0;
            string opcion = "s";
            do
            {

                Console.WriteLine("ingrese un número:");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese una potencia para el número:");
                e = int.Parse(Console.ReadLine());

                double resultado = Math.Pow(b, e);

                Console.WriteLine($"la potencia de número {b} es: {resultado}");

                Console.WriteLine("¿desea calcular otra potencia? s/sí, cualquier otra letra para no");
                opcion = Console.ReadLine();

            } while (opcion == "s");
            



        }
    }
}
