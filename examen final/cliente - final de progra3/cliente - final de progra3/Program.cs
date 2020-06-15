using System;

namespace cliente___final_de_progra3
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            

            do
            {
                Console.WriteLine("1. Ingreso");
                Console.WriteLine("2. Salida");
                Console.WriteLine("3. Mostrar");

                Console.WriteLine("4. Salir");

                opcion = int.Parse(Console.ReadLine());
                string x;
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Nombre: ");
                        String nombre = Console.ReadLine();
                        Console.WriteLine("Apellido: ");
                        String apellido = Console.ReadLine();
                        Console.WriteLine("Sexo: ");
                        String sexo = Console.ReadLine();
                        Sexo sexoo;
                        Enum.TryParse(sexo, out sexoo);
                        Console.WriteLine("Edad: ");
                        int edad = int.Parse(Console.ReadLine());
                        x = Cliente.getInstancia().Lista(nombre, apellido, sexoo, edad);
                        Console.ReadKey();
                        break;
                   


                }

            } while (opcion != 3);
        }
    }
}
