using System;

namespace _18.TallerMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Desarrollar un programa que crea una matriz de 10 filas y 20 columnas y muestre por 
            //pantalla la suma de los elementos de cada columna.
            /*
            int[,] numeros = new int[10, 20];
            int acumulador = 0;
            int acumuladorTotal = 0;

            Random rnd = new Random();

            

            for (int c = 0; c < 20; c++)//columnas
            {

                acumulador = 0;

                for (int f = 0; f < 10; f++)//filas
                {
                    
                    numeros[f, c] = rnd.Next(1, 6);
                    acumulador = acumulador + numeros[f, c];
                    acumuladorTotal = acumuladorTotal + numeros[f, c];
                    
                }
                Console.WriteLine($"La suma de la columna {c} es: {acumulador}");
                


            }
            Console.WriteLine($"La suma de todos los elementos es: {acumuladorTotal}");
            */

            //2.Desarrollar un programa que crea una matriz de n filas * m columnas, el usuario ingresa 
            //caracteres en cada posición de la matriz hasta llenarla.
            // El programa debe intercambiar la primera fila con la última fila de la matriz
            // Al final se debe imprimir la matriz original, y la
            //matriz con el intercambio de filas.
            /*
            int n = 3;
            int m = 3;


            char[,] caracteres = new char[n, m];
            char[,] caracteresInvertida = new char[n, m];


            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Ingrese el caracter para la posición [{j},{i}]: ");
                    caracteres[j, i] = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                }
            }


          
            for (int i = 0; i < caracteres.GetLength(0); i++)//GetLength(0) devuelve el número de filas
            {
                for (int j = 0; j < caracteres.GetLength(1); j++)//GetLength(1 devuelve el número de columnas
                {
                    Console.Write($"{caracteres[i, j]} |");
                }
                Console.WriteLine();
            }
            
            caracteresInvertida  = (char[,])caracteres.Clone();
         


            for (int i = 0; i < m; i++)
            {
                caracteresInvertida[n - 1, i] = caracteres[0, i];
                caracteresInvertida[0, i] = caracteres[n - 1, i]; ;
            }

            Console.WriteLine();

           
            for (int i = 0; i < caracteresInvertida.GetLength(0); i++)//GetLength(0) devuelve el número de filas
            {
                for (int j = 0; j < caracteresInvertida.GetLength(1); j++)//GetLength(1 devuelve el número de columnas
                {
                    Console.Write($"{caracteresInvertida[i, j]} |");
                }
                Console.WriteLine();
            }
            */



            //3.  Crear un algoritmo que cuente la frecuencia de cada número del 1 al 10 en una matriz de 
            //5x5 llena de números aleatorios.
            //El algoritmo debe permitir:
            // Usa la función Random para generar los números aleatorios.
            // Crea un arreglo adicional para almacenar la frecuencia de cada número.
            // Mostrar la matriz y el nuevo arreglo con la frecuencia de cada número


            int[,] numeros = new int[5, 5];
            int numeroLimite = 10;
            int[] frecuencia = new int[numeroLimite];
                




            Random rnd = new Random();



            for (int c = 0; c < numeros.GetLength(1); c++)//columnas
            {
                for (int f = 0; f < numeros.GetLength(0); f++)//filas
                {
                    numeros[f, c] = rnd.Next(1, numeroLimite + 1);

                }
            }

            for (int i = 0; i < numeros.GetLength(0); i++)//GetLength(0) devuelve el número de filas
            {
                for (int j = 0; j < numeros.GetLength(1); j++)//GetLength(1 devuelve el número de columnas
                {
                    Console.Write($"{numeros[i, j]} |");
                }
                Console.WriteLine();
            }


            
            for (int i = 0; i < numeros.GetLength(0); i++)//GetLength(0) devuelve el número de filas
            {
                for (int j = 0; j < numeros.GetLength(1); j++)//GetLength(1 devuelve el número de columnas
                {
                    frecuencia[ numeros[i, j] - 1 ] = frecuencia[ numeros[i, j] - 1 ] + 1;
                }
            }


            Console.WriteLine("Frecuencia de cada número:");
            for (int i = 0; i < frecuencia.Length; i++)
            {
                Console.Write($"{frecuencia[i]} |");
            }
            Console.WriteLine();






        }
    }
}
