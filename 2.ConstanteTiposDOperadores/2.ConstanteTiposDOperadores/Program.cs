using System;

namespace _2.ConstanteTiposDOperadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constantes
            const string gravedad = "9.8";
            string nombre = "Francisco";
            nombre = "José";
            //gravedad="10"; no puedo cambiar el valor de una constante

            //TIPOS DE DATOS
            byte dato1 = 5;
            int dato2 = -4563;
            ulong dato3 = 2342342345322;
            float dato4 = 14.6f;
            double dato5 = 12231213.334523;
            decimal dato6 = 32412423545.52352352355m;

            char dato7 = '5';
            string dato8 = "jdnqjnwsdjiuewhdfbwjqbuib";
            bool dato9 = false;//Puede ser true o false
            object dato10 = new object();

            //OPERADORES
            //Operadores numéricos
            //Cambio de signo
            int dato11 = 5;
            int dato12 = -dato11;
            int dato13 = +dato12;
            int dato14 = -dato13;
            Console.WriteLine("dato11:{0}, dato12:{1}. dato13:{2}, dato14:{3}",dato11, dato12, dato13, dato14);
            int dato15 = 5 + 3; //Suma
            int dato16 = dato15 - 2;//Resta
            int dato17 = 25 * 3;//Producto
            float dato18 = 5f / 3;//División
            Console.WriteLine("Suma: {0}. resta:{1}, producto:{2}, división:{3}", dato15, dato16, dato17, dato18);
        }
    }
}
