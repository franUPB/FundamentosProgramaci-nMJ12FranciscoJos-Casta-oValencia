using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.TallerVectores
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int[] numeros = new int[15];
            int max = 0;
            int min = 0;

            Console.WriteLine("Ingrese 15 números enteros:");

            for (int i = 0; i < 15; i++)
            {

                Console.Write("Número {0}: ", i + 1);
                numeros[i] = int.Parse(Console.ReadLine());

                if (numeros[i] == numeros[0])
                {
                    max = numeros[i];
                    min = numeros[i];
                }
                else
                {
                    if (numeros[i] > max)
                    {
                        max = numeros[i];
                    }
                    else if (numeros[i] < min)
                    {
                        min = numeros[i];
                    }

                }

                

            }
                Console.WriteLine("Número máximo: {0}", max);
                Console.WriteLine("Número mínimo: {0}", min);

        }
    }
}
