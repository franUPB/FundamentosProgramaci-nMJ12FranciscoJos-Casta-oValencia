using System;

namespace _8.CicloWhile2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumaEnteros = 0;
            int numero = 0;
            Console.WriteLine("Ingrese un número para sumar:");
            numero = int.Parse(Console.ReadLine());

            while (numero >= 0) 
            {
                sumaEnteros += numero;
                Console.WriteLine("Ingrese un número para sumar:");
                numero = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"La suma de los números es: {sumaEnteros}");


        }
    }
}
