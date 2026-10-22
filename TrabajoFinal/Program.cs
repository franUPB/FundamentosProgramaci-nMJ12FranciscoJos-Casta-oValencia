using System;

namespace TrabajoFinal
{
    internal class Program
    {
        //variable o atributo de la clase Program
        string[,] usuarios = new string[15, 3];
        int cantidadUsuarios = 0;


        static void Main(string[] args)
        {
            // creo un objeto llamado programa
            Program program = new Program();
            
            program.crearAdministrador();


            int contadorError = 0;
            bool autenticado = false;
            while (contadorError < 3 && !autenticado)
            {
                if (program.autenticar())
                {
                    autenticado = true;
                } 
                else
                {
                    contadorError++;
                }
            }

            if ( autenticado ) { 
                Console.WriteLine("Bienvenido al sistema");





            } else {
                Console.WriteLine("Error al autenticar, contacte a soporte técnico");
            }

            //program.crearCuenta();
            //program.mostrarUsuarios();


            /*
           
            program.mostrarUsuarios();
            program.crearCuenta();
            program.mostrarUsuarios();
            program.crearCuenta();
            program.mostrarUsuarios();
            */
            //
        }


        public void crearAdministrador()
        {

            string contraseña = "";
            string usuario = "";
            int rol = 1;


            Console.WriteLine("Ingrese el nombre de usuario para el administrador:");
            usuario = Console.ReadLine();

            Console.WriteLine("Ingrese su contraseña:");
            contraseña = Console.ReadLine();

            // Implementación de la creación de cuenta adicional, como agregar el nuevo usuario al arreglo de usuarios[,]

            this.usuarios[this.cantidadUsuarios, 0] = usuario;
            this.usuarios[this.cantidadUsuarios, 1] = contraseña;
            this.usuarios[this.cantidadUsuarios, 2] = rol.ToString();
            this.cantidadUsuarios++;

        }

        public void crearCajero()
        {

            string contraseña = "";
            string usuario = "";
            int rol = 2;
      

            Console.WriteLine("Ingrese el nombre de usuario:");
            usuario = Console.ReadLine();

            Console.WriteLine("Ingrese su contraseña:");
            contraseña = Console.ReadLine();

            // Implementación de la creación de cuenta adicional, como agregar el nuevo usuario al arreglo de usuarios[,]
  
            this.usuarios[this.cantidadUsuarios, 0] = usuario;
            this.usuarios[this.cantidadUsuarios, 1] = contraseña;
            this.usuarios[this.cantidadUsuarios, 2] = rol.ToString();
            this.cantidadUsuarios++;

        }

        public void mostrarUsuarios()
        {
            Console.WriteLine("Usuarios registrados:");
            for (int i = 0; i < this.cantidadUsuarios;  i++)
            {
                Console.WriteLine($"Usuario: {usuarios[i, 0]}, Contraseña: {usuarios[i, 1]}, Rol: {usuarios[i, 2]}");
            }
        }

        public bool autenticar() {
            Console.Clear();
            string contraseña = "";
            string usuario = "";
            int rol = 0;

            Console.WriteLine("------------Inicio de Sesión-----------");

            Console.WriteLine("Ingrese el nombre de usuario:");
            usuario = Console.ReadLine();
            
            Console.WriteLine("Ingrese su contraseña:");
            contraseña = Console.ReadLine();
            
            Console.WriteLine("¿Cuál es su rol(1/Administrador, 2/Cajero)?");
            rol = int.Parse(Console.ReadLine());


            //buscar en usuarios[,] si el usuario y contraseña coinciden con algún registro
            bool encontrado = false;
            for (int i = 0; i < this.cantidadUsuarios; i++)
            {
                if (usuarios[i, 0] == usuario && usuarios[i, 1] == contraseña.ToString() && usuarios[i, 2] == rol.ToString())
                {
                    encontrado = true;
                    break;
                }
            }
            if ( !encontrado )
            {
                Console.WriteLine("Error al ingresar el rol, vuelva a intentar presione una tecla");
                Console.ReadKey();
            }
            return encontrado;
        }


        // Remove static so it can access instance fields
        public void Autenticación()
        {
            //Console.WriteLine(this.color);

            int contraseña = 0;
            string usuario = " ";
            int rol = 0;
            int contadorError = 0;
            while (contadorError <3)
            {
                Console.WriteLine("Ingrese el nombre de usuario:");
                usuario = Console.ReadLine();
                Console.WriteLine("Ingrese su contraseña:");
                contraseña = int.Parse (Console.ReadLine());
                Console.WriteLine("¿Cuál es su rol(1/Administrador, 2/Cajero)?");
                rol = int.Parse (Console.ReadLine());
                
                if (rol == 1 || rol == 2)
                {
                    
                    Console.WriteLine($"Bienvenido/a, {usuario}");
                
                    if (rol == 1)
                    {
                        string admin = "Administrador";
                       Console.WriteLine($"Rol: {admin}");
                
                    }
                    else
                    {
                        string cajero = "Cajero";
                        Console.WriteLine($"Rol: {cajero}");
                    }
                
                
                }
                else
                {
                    Console.WriteLine("Error al ingresar el rol, vuelva a intentar");
                    contadorError++;
                    Console.ReadKey();          
                    Console.Clear();
                }

            }
            
            if (contadorError == 3)
            {
                Console.WriteLine("ERROR");
                Console.WriteLine("Contacte a soporte técnico");
            }
            
        }
    }
}





/*

    autenticar
    crear cuenta
    editar cuenta
    editar contraseña



 */