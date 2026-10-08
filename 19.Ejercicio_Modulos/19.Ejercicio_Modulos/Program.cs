using System;

namespace _19.Ejercicio_Modulos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMenu();
            RealizarOperaciones(CapturarOpcion());
        }

        static float Suma()
        {
            float num = 0;
            float suma = 0;
            char respuesta = ' ';
            do
            {

                Console.WriteLine("Ingrese un número: ");
                num = float.Parse(Console.ReadLine());
                suma += num;
                Console.WriteLine("¿Desea ingresar otro número? (s/n): ");
                respuesta = char.Parse(Console.ReadLine());

            } while (respuesta == 's' || respuesta == 'S');
            return suma;
        }

        static float Multiplicacion()
        {
            float num = 0;
            float producto = 1;
            char respuesta = ' ';
            do
            {

                Console.WriteLine("Ingrese un número: ");
                num = float.Parse(Console.ReadLine());
                producto *= num;
                Console.WriteLine("¿Desea ingresar otro número? (s/n): ");
                respuesta = char.Parse(Console.ReadLine());

            } while (respuesta == 's' || respuesta == 'S');
            return producto;
        }

        static float Resta()
        {
            Console.WriteLine("Ingrese un número 1: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un número 2: ");
            float num2 = float.Parse(Console.ReadLine());
            return num1 - num2;
        }

        static float Division()
        {
            Console.WriteLine("Ingrese un número 1: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un número 2: ");
            float num2 = float.Parse(Console.ReadLine());
            return num1 / num2;
        }   

        static void RealizarOperaciones(int opcion)
        {
            while(opcion != 0)
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine($"SUMA: {Suma()}");
                        break;
                    case 2:
                        Console.WriteLine($"RESTA: {Resta()}");
                        break;
                    case 3:
                        Console.WriteLine($"MULTIPLICACIÓN: {Multiplicacion()}");
                        break; 
                    case 4:
                        Console.WriteLine($"DIVISIÓN: {Division()}");
                        break; 
                }
                
                Console.ReadKey();           //Pausar la ejecución para que el usuario pueda ver el resultado
                Console.Clear();             //Limpiar la consola para que se vea más ordenado
                MostrarMenu();               //Volver a llamar el módulo de menú y capturar la opción nuevamente
                opcion = CapturarOpcion();
                

            }
            
        }

        static int CapturarOpcion()
        {
            return int. Parse( Console.ReadLine() );
        }

        static void MostrarMenu()
        {
            Console.WriteLine("------------------MENÚ------------------");
            Console.WriteLine("1. SUMA            2. RESTA");
            Console.WriteLine("3. MULTIPLICACIÓN  4. DIVISIÓN");
            Console.WriteLine("0. SALIR");
            Console.WriteLine("----------------------------------------"); 
            Console.WriteLine("Ingrese una opción: ");
        }
    }
}
