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


            //2.

            //int numero = 0;

            //Console.WriteLine("Ingrese un número:");
            //numero = int.Parse(Console.ReadLine());

            //for (int v = 1; v <= numero; v++)
            //{

            //    if (numero % v == 0)
            //    {
            //        Console.WriteLine(v);
            //    }

            //}

            //3. 

            //    int b = 0;
            //int e = 0;
            //string opcion = "s";
            //do
            //{

            //    Console.WriteLine("ingrese un número:");
            //    b = int.Parse(Console.ReadLine());
            //    Console.WriteLine("ingrese una potencia para el número:");
            //    e = int.Parse(Console.ReadLine());

            //    double resultado = Math.Pow(b, e);

            //    Console.WriteLine($"la potencia del número {b} es: {resultado}");

            //    Console.WriteLine("¿desea calcular otra potencia? s/sí, cualquier otra letra para no");
            //    opcion = Console.ReadLine();

            //} while (opcion == "s");


            //4.

            int tiempoPrueba = 0;
            int tiempoTotal = 0;
            int cantidadPruebas = 1;
            float promedio = 0;
            bool apto = true;
            bool pruebaCumplida = false;


            do
            {
                Console.WriteLine($"Ingrese el tiempo del dia {cantidadPruebas}");
                tiempoPrueba = int.Parse(Console.ReadLine());

                tiempoTotal = tiempoTotal + tiempoPrueba;
                promedio = tiempoTotal / cantidadPruebas;

                if (tiempoPrueba > 20)
                {
                    apto = false;
                }
                if (tiempoPrueba < 15)
                {
                    pruebaCumplida = true;
                }
                if (promedio > 18)
                {
                    apto = false;
                }

                cantidadPruebas++;
            } while (apto && cantidadPruebas <= 10);

            Console.WriteLine($" promedio es: {promedio}");

            if (!pruebaCumplida)
            {
                apto = false;
            }

            if (apto)
            {
                Console.WriteLine("El atleta es apto");
            }
            else
            {
                Console.WriteLine("El atleta no es apto");
            }

        }
    }
}
