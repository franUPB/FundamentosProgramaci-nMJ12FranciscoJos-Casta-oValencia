using System;

namespace ParcialCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
           



            Console.WriteLine("Ingrese su mes de nacimiento");
            string mes= Console.ReadLine();

            Console.WriteLine("Ingrese su signo zodiacal");
            string signo = Console.ReadLine();

            if ( mes == "marzo" || mes == "abril")
            {
                if (signo == "aries")
                {
                    Console.WriteLine("El elemento de la persona es fuego");
                }
                else
                {
                    if (signo != "aries" && mes == "marzo" && mes == "abril" || signo == "aries" && mes != "marzo" || mes != "abril")
                    {
                        Console.WriteLine("Los valores ingresados no coinciden con ningún elemento zodiacal");
                    }
                }
            }
            else
            {
                if (mes == "julio" || mes == "agosto")
                {
                    if (signo == "leo")
                    {
                        Console.WriteLine("El elemento de la persona es fuego");
                    }
                    else
                    {
                        if (signo != "leo" && mes == "julio" && mes == "agosto" || signo == "leo" && mes != "julio" || mes != "agosto")
                        {
                            Console.WriteLine("Los valores ingresados no coinciden con ningún elemento zodiacal");
                        }
                    }
                }
                else
                {
                    if (mes == "noviembre" || mes == "diciembre")
                    {
                        if (signo == "sagitario")
                        {
                            Console.WriteLine("El elemento de la persona es fuego");
                        }
                        else
                        {
                            if (signo != "sagitario" && mes == "noviembre" && mes == "diciembre" || signo == "sagitario" && mes != "noviembre" || mes != "diciembre")
                            {
                                Console.WriteLine("Los valores ingresados no coinciden con ningún elemento zodiacal");
                            }
                        }
                    }
                    else
                    {
                        if (mes == "mayo" || mes == "abril")
                        {
                            if (signo == "tauro")
                            {
                                Console.WriteLine("El elemento de la persona es tierra");
                            }
                            else
                            {
                                if (signo != "tauro" && mes == "mayo" && mes == "abril" || signo == "tauro" && mes != "mayo" || mes != "abril")
                                {
                                    Console.WriteLine("Los valores ingresados no coinciden con ningún elemento zodiacal");
                                }
                            }
                        }
                        else
                        {
                            if (mes == "agosto" || mes == "septiembre")
                            {
                                if (signo == "virgo")
                                {
                                    Console.WriteLine("El elemento de la persona es tierra");
                                }
                                else
                                {
                                    if (signo != "virgo" && mes == "agosto" && mes == "septiembre" || signo == "virgo" && mes != "agosto" || mes != "septiembre")
                                    {
                                        Console.WriteLine("Los valores ingresados no coinciden con ningún elemento zodiacal");
                                    }
                                }
                            }
                            else
                            {
                                if (mes == "diciembre" || mes == "enero")
                                {
                                    if (signo == "capricornio")
                                    {
                                        Console.WriteLine("El elemento de la persona es tierra");
                                    }
                                    else
                                    {
                                        if (signo != "capricornio" && mes == "diciembre" && mes == "enero" || signo == "capricornio" && mes != "diciembre" || mes != "enero")
                                        {
                                            Console.WriteLine("Los valores ingresados no coinciden con ningún elemento zodiacal");
                                        }
                                    }
                                }
                                else
                                {
                                    if (mes == "mayo" || mes == "junio")
                                    {
                                        if (signo == "geminis")
                                        {
                                            Console.WriteLine("El elemento de la persona es aire");
                                        }
                                        else
                                        {
                                            if (signo != "geminis" && mes == "mayo" && mes == "junio" || signo == "geminis" && mes != "mayo" || mes != "junio")
                                            {
                                                Console.WriteLine("Los valores ingresados no coinciden con ningún elemento zodiacal");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (mes == "septiembre" || mes == "octubre")
                                        {
                                            if (signo == "libra")
                                            {
                                                Console.WriteLine("El elemento de la persona es aire");
                                            }
                                            else
                                            {
                                                if (signo != "libra" && mes == "septiembre" && mes == "octubre" || signo == "libro" && mes != "septiembre" || mes != "octubre")
                                                {
                                                    Console.WriteLine("Los valores ingresados no coinciden con ningún elemento zodiacal");
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (mes == "enero" || mes == "febrero")
                                            {
                                                if (signo == "acuario")
                                                {
                                                    Console.WriteLine("El elemento de la persona es aire");
                                                }
                                                else
                                                {
                                                    if (signo != "acuario" && mes == "enero" && mes == "febrero" || signo == "acuario" && mes != "enero" || mes != "febrero")
                                                    {
                                                        Console.WriteLine("Los valores ingresados no coinciden con ningún elemento zodiacal");
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if (mes == "junio" || mes == "julio")
                                                {
                                                    if (signo == "cancer")
                                                    {
                                                        Console.WriteLine("El elemento de la persona es agua");
                                                    }
                                                    else
                                                    {
                                                        if (signo != "cancer" && mes == "junio" && mes == "julio" || signo == "cancer" && mes != "junio" || mes != "julio")
                                                        {
                                                            Console.WriteLine("Los valores ingresados no coinciden con ningún elemento zodiacal");
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    if (mes == "octubre" || mes == "noviembre")
                                                    {
                                                        if (signo == "escorpio")
                                                        {
                                                            Console.WriteLine("El elemento de la persona es agua");
                                                        }
                                                        else
                                                        {
                                                            if (signo != "escorpio" && mes == "octubre" && mes == "noviembre" || signo == "escorpio" && mes != "octubre" || mes != "noviembre")
                                                            {
                                                                Console.WriteLine("Los valores ingresados no coinciden con ningún elemento zodiacal");
                                                            }
                                                        }
                                                    }
                                                    else
                                                    {
                                                        if (mes == "febrero" || mes == "marzo")
                                                        {
                                                            if (signo == "piscis")
                                                            {
                                                                Console.WriteLine("El elemento de la persona es agua");

                                                            }
                                                            else
                                                            {
                                                                if (signo != "piscis" && mes == "febrero" && mes == "marzo" || signo == "piscis" && mes != "febrero" || mes != "marzo")
                                                                {
                                                                    Console.WriteLine("Los valores ingresados no coinciden con ningún elemento zodiacal");
                                                                }
                                                            }
                                                        }

                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }
    }
}

