using System;

namespace _18.TallerMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Desarrollar un programa que crea una matriz de 10 filas y 20 columnas y muestre por 
            //pantalla la suma de los elementos de cada columna.

            int[,] numeros = new int[10, 20];
            int acumulador = 0;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Random rnd = new Random();
                    numeros[i, j] = rnd.Next(1, 6);
                    acumulador= acumulador + numeros[i, j];
                    Console.WriteLine(numeros[i, j]);
                    
                }
                
            }
            Console.WriteLine($"La suma de los números es: {acumulador}");
            

        }
    }
}
