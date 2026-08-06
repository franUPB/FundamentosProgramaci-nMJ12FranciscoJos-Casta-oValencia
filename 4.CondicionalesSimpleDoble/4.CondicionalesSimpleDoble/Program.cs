using System;

namespace _4.CondicionalesSimpleDoble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Estructuras de control condicionales
            //SIMPLES
            //1. Crea un algortimo que lea la edad de un usuario si el usuario es mayor de 18, se debe mostrar el siguiente mensaje: "Bienvenido a la página web".
            /*    byte edad = 0;
                Console.WriteLine("Ingrese su edad");
                edad = Convert.ToByte(Console.ReadLine());
                if (edad >= 18)
                {
                    //Si la condición es verdadera, se ejecuta el bloque de código dentro del if.
                    Console.WriteLine("Bienvenido a la página web");

                }*/
            //Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona, si el sueldo es mayor a 3000 pesos, se debe mostrar el mensaje en pantalla con el nombre de l persona: "Usted debe abonar impuestos".

            string nombre;
            float sueldo = 0;
            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su sueldo");
            sueldo = Convert.ToUInt32(Console.ReadLine());
            if (sueldo >= 3000)
            {
                Console.WriteLine("Usted debe abonar impuestos");
            }

            //DOBLES
            //Crea un algortimo que lea la edad de un usuario si el usuario es mayor de 18, se debe mostrar el siguiente mensaje: "Bienvenido a la página web". De lo contrario, se debe mostrar el siguiente mensaje: "Usted no puede ingresar a la página web".

            byte edad = 0;
            Console.WriteLine("Ingrese su edad");
            edad = Convert.ToByte(Console.ReadLine());
            if (edad >= 18)
            {
                //Si la condición es verdadera, se ejecuta el bloque de código dentro del if.
                Console.WriteLine("Bienvenido a la página web");
            }
            else
            {
                //Si la condición es falsa, se ejecuta el bloque de código dentro del else.
                Console.WriteLine("Usted no puede ingresar a la página web");
            }
        }
    }
}
