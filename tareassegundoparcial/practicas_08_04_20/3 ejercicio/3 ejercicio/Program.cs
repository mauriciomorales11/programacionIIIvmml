using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            ListaDouble list = new ListaDouble();

            while (op != 4)
            {
                Console.Clear();
                Console.WriteLine("1. Insertar");
                Console.WriteLine("2. Eliminar");
                Console.WriteLine("3. Mostrar");

                Console.WriteLine("4. Salir");

                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:

                        Console.Write("Nombre: ");
                        String Nombre = Console.ReadLine();
                        Console.Write("Primer Apellido: ");
                        String PrimerApellido = Console.ReadLine();
                        Console.Write("Segundo Apellido: ");
                        String segundoApellido = Console.ReadLine();
                        Console.Write("Introduzca estado : ");
                        String estado = Console.ReadLine();
                        Console.Write("Introduzca el Sexo: (M/F) ");
                        String sexo = Console.ReadLine();

                        Console.Write("Introduzca la Edad: ");
                        int edad = int.Parse(Console.ReadLine());

                        infectado a = new infectado(Nombre, PrimerApellido, segundoApellido, estado, sexo, edad);

                        list.Insertar(a);
                        break;
                    case 2:
                        Console.WriteLine("que apellido quiere eliminar");
                        string w = (Console.ReadLine());
                        list.EliminarApellido(w);
                        Console.ReadKey();
                        break;
                    case 3:
                        list.Mostrar();
                        Console.ReadKey();
                        break;
                }

            }
        }


    }
}
