using System;

namespace ejercicio_1___2do_parcial_VM
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;

            pila<documentos> T = new pila<documentos>();
            while (opcion != 4)
            {
                Console.Clear();
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Mostrar");
                Console.WriteLine("4. Salir");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("introduzca carta o circular o memorandum");
                        String documen = Console.ReadLine();
                        

                        documentos a = new documentos(documen);
                        T.push(a);
                        break;
                    case 2:
                        documentos y = T.pop();
                        Console.WriteLine("El elemento eliminado es {0}", y.ToString());
                        Console.ReadKey();
                        break;
                    case 3:
                        T.mostrar();
                        Console.ReadKey();
                        break;
                }
            }
        }

    }
}
