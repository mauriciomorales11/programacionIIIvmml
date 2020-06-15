using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace micro___final_de_programacion_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            MICRO Univalle = MICRO.getInstancia();

            do
            {
                Console.WriteLine("1. Ingreso");
                Console.WriteLine("2. Salida");
                Console.WriteLine("3. Mostrar");

                Console.WriteLine("4. Salir");

                opcion = int.Parse(Console.ReadLine());
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
                        PERSONA y = new PERSONA(nombre, apellido, sexoo, edad);
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("introduzca Placa");
                        String m = Console.ReadLine();
                        Console.WriteLine(Univalle.SalidaPersona(m));
                        Console.ReadKey();
                        break;
                    case 3:
                        Univalle.GetDatos();
                        Console.ReadKey();
                        break;
                    

                }

            } while (opcion != 3);
        }
    }
}
