using System;

namespace ParcialCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int vehículo = 0;
            int horas = 0;
            int contadorVehiculos = 1;
            int contadorMotos = 0;
            int contadorAutomoviles = 0;
            int contadorCamiones = 0;
            double tarifaMoto = 3000;
            int tarifaAutomovil = 5000;
            int tarifaCamion = 10000;
            double dineroTotal = 0;

            do
            {
                Console.WriteLine($"Ingrese el código numérico del vehículo {contadorVehiculos} (1 para moto, 2 para automóvil, 3 para camión):");
                vehículo = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la cantidad de horas que estuvo estacionado:");
                horas = int.Parse(Console.ReadLine());

                if (vehículo == 1)
                {
                    contadorMotos++;
                }
                else if (vehículo == 2)
                {
                    contadorAutomoviles++;
                }
                else if (vehículo == 3)
                {
                    contadorCamiones++;
                }

                if (vehículo == 1) 
                {
                
                    if (horas > 4)
                    {
                        tarifaMoto = (tarifaMoto * horas) * 0.10;
                        Console.WriteLine("El total a pagar por la moto es: " + tarifaMoto);
                    }
                    else
                    {
                        tarifaMoto = tarifaMoto * horas;
                        Console.WriteLine("El total a pagar por la moto es: " + tarifaMoto);
                    }
                
                }

                if(vehículo == 2)
                {

                    if ( horas > 3)
                    {
                        tarifaAutomovil = 20000;
                        Console.WriteLine("El total a pagar por el automóvil es: " + tarifaAutomovil);
                    }
                    else
                    {
                        tarifaAutomovil = tarifaAutomovil * horas;
                        Console.WriteLine("El total a pagar por el automóvil es: " + tarifaAutomovil);
                    }

                }

                
                if (vehículo == 3)
                {
                    if (horas > 5)
                    {
                        tarifaCamion = (tarifaCamion * horas) + 15000;
                        Console.WriteLine("El total a pagar por el camión es: " + tarifaCamion);
                    }
                    else
                    {
                        tarifaCamion = tarifaCamion * horas;
                        Console.WriteLine("El total a pagar por el camión es: " + tarifaCamion);
                    }
                }
                


                dineroTotal += tarifaMoto + tarifaAutomovil + tarifaCamion;

                contadorVehiculos++;



            } while (contadorVehiculos <= 12);

            Console.WriteLine("El dinero total recaudado es: " + dineroTotal);
            Console.WriteLine("Cantidad de motos: " + contadorMotos);
            Console.WriteLine("Cantidad de automóviles: " + contadorAutomoviles);
            Console.WriteLine("Cantidad de camiones: " + contadorCamiones);

        }
    }
}
