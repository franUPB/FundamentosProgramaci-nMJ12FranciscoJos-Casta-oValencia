using Microsoft.SqlServer.Server;
using System;

namespace _17.Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Arreglos bidimensionales - matrices
            //int[,] numeros = new int[2, 3];

            ////numeros[2, 1] = 23; No se puede almacenar porque el arreglo tiene 2 filas y 3 columnas, por lo que el índice máximo para las filas es 1 y para las columnas es 2.
            ////numeros[1, 3] = 54; No se puede almacenar porque el arreglo tiene 2 filas y 3 columnas, por lo que el índice máximo para las filas es 1 y para las columnas es 2.
            // numeros[0, 0] = 0;
            // numeros[0, 1] = 1;
            // numeros[0, 2] = 2;
            // numeros[1, 0] = 3;
            // numeros[1, 1] = 4;
            // numeros[1, 2] = 5;

            //Console.WriteLine($"El valor almacenado en la posición [0, 0] es: {numeros[0, 0]}");

            //char[,] símbolos = new char[3, 2];

            ////Recorrer para llenar
            //for (int i = 0; i < 3; i++) //Recorre las filas
            //{
            //    for (int j = 0; j < 2; j++) //Recorre las columnas
            //    {
            //        Console.WriteLine($"Ingrese el valor para la posición [{i}, {j}]: ");
            //        símbolos[i, j] = Convert.ToChar(Console.ReadLine());
            //    }
            //}

            ////Recorrer para recuperar
            //for (int i = 0; i < símbolos.GetLength(0); i++) //Recorre las filas //GetLength(0) devuelve el número de filas
            //{
            //    for (int j = 0; j < símbolos.GetLength(1); j++) //Recorre las columnas //GetLength(1) devuelve el número de columnas
            //    {
            //        Console.Write($" {símbolos[i, j]} |");
            //    }
            //    Console.WriteLine(); // Agrega una línea en blanco después de cada fila
            //}

            ////Otra forma de declarar e inicializar matrices
            //string[,] nombres =
            //{
            //    { "Ana", "Luis" },
            //    { "María", "Carlos" },
            //    { "Pedro", "Sofía" }
            //};

            //1. Crear una matriz[10, 20], en cada posición de la mTRIZ PONER EL NÚMERO 100; mostrar la matriz en pantalla
            //int[,] matriz = new int[10, 20];

            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        matriz[i, j] = 100;
            //    }
            //}

            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        Console.Write($" {matriz[i, j]} |");
            //    }
            //    Console.WriteLine();
            //}


            //Escribe un programa que realice la suma de dos matrices de dimensiones 2x3.
            //Requisitos del programa:
            //Solicita al usuario que ingrese los elementos de la primera matriz de 2 filas y 3 columnas.
            //Solicita al usuario que ingrese los elementos de la segunda matriz de las mismas dimensiones(2x3).
            //Calcula la matriz suma, resultado de sumar cada elemento correspondiente de las dos matrices.
            //Muestra la matriz resultante de la suma en formato de matriz(2 filas, 3 columnas).

            int[,] matriz1 = new int[2, 3];
            int[,] matriz2 = new int[2, 3];
            int[,] matrizSuma = new int[2, 3];

            Console.WriteLine("Ingrese los elementos de la primera matriz:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Elemento [{i}, {j}]: ");
                    matriz1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Ingrese los elementos de la segunda matriz:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Elemento [{i}, {j}]: ");
                    matriz2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Calcular la matriz suma
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrizSuma[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }

            // Mostrar la matriz resultante
            Console.WriteLine("Matriz suma:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($" {matrizSuma[i, j]} |");
                }
                Console.WriteLine();
            }

        }
    }
}
