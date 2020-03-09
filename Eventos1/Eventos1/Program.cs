using System;

namespace Eventos1
{
    class Program
    {
        public static void NotificarRaizImaginaria(string msg)
        {
            //imprimos mensaje aviso.
            Console.WriteLine("Raiz Imaginaria");
            Console.WriteLine(msg);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("introduzca valor de a, b y c");
            Console.Write("a: "); int a = int.Parse(Console.ReadLine());
            Console.Write("b: "); int b = int.Parse(Console.ReadLine());
            Console.Write("c: "); int c = int.Parse(Console.ReadLine());

            double x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / 2 * a;
            double x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / 2 * a;

            Console.WriteLine("la raiz x1 es: " + x1);
            Console.WriteLine("la raiz x2 es: " + x2);



            Console.Write("Pulsa cualquier tecla para continuar . . . ");
            Console.ReadKey(true);
        }
    }
}
