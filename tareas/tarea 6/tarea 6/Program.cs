using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar el numero: ");
            int A = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= A; i++)
            {
                Console.WriteLine("fibonacci: " + (i + 1) + FactorialRecursivo(i));
            }
            Console.ReadKey();
        }
        static int FactorialRecursivo(int A)
        {
            if (A == 0 || A == 1)
            {
                return 1;
            }    
            else
            {
                return A * FactorialRecursivo(A - 1) + A * FactorialRecursivo(A - 2);
            }          
        }


    }

}
