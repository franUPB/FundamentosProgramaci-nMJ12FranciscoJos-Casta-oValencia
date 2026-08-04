using System;

namespace _3.Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operadores numéricos
            //Incremento decremento
            int dato1 = 0;
            dato1++;//dato1 = dato1 + 1; Incremento en 1 unidad
            dato1--;//dato1 = dato1 - 1; Decremento en 1 unidad
            dato1 += 15;//dato1 = dato1 + 15;
            dato1 -= 15;//dato1 = dato1 - 15;
            dato1 *= 15;//dato1 = dato1 * 15;
            dato1 /= 15;//dato1 = dato1 / 15;
            dato1 *= dato1;//dato1 = dato1 * dato1;

            //Orden de evaluación operadores aritméticos
            int dato2 = 4 * 3 / 2;
            int dato3 = 5 / 2 * 4;
            int dato4 = 4 * 8 / 5 + 4;
            int dato5 = 4 * (5 / 3);
            int dato6 = 3 - 1 * (4 / 2);
            Console.WriteLine(dato2);

            //OPERADORE LÓGICOS
            //CONJUNCIÓN - AND - Y - &&
            Console.WriteLine("TABLA DE CONJUNCIÓN");
            Console.WriteLine("V && V =" + (true && true));
            Console.WriteLine("V && F =" + (true && false));
            Console.WriteLine("F && V =" + (false && true));
            Console.WriteLine("F && F =" + (false && false));

            //DISYUNCIÓN - OR - O - ||
            Console.WriteLine("TABLA DE CONJUNCIÓN");
            Console.WriteLine("V || V =" + (true || true));
            Console.WriteLine("V || F =" + (true || false));
            Console.WriteLine("F || V =" + (false || true));
            Console.WriteLine("F || F =" + (false || false));

            //NEGACIÓN
            bool dato7 = true;
            bool dato8 = !dato7;

            //OPERADORES DE COMPARACIÓN
            bool dato9 = 5 > 4;//Mayor que
            bool dato10 = 1002 == 102;//Igual que
            bool dato11 = 10 >= 9;//Mayor o igual
            bool dato12 = 0 != 1;//Diferente a
            bool dato13 = 4 < 5 && 3 == 0;
            bool dato14 = 0 != 2 && dato9 || dato10;
        }
    }
}
