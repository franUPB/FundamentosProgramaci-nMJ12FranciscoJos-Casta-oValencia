using System;

namespace _7.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Escribir un algoritmo que permita generar los primeros 5 números enteros positivos y realizar y mostrar su suma.
            int contador = 1;
            int acumulador = 1;

            while (contador < 5)
            {
                contador++;
                acumulador = acumulador + contador;
            }

            Console.WriteLine($"La suma de los cinco primeros números es: {acumulador}");

        }
    }
}
