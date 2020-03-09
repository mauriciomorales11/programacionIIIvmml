using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetodosGenericos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] intArray = { 2, 3, 4};
            double[] doubleArray = { 3.1, 4.6, 2.3};
            string[] stringArray = { "Juan", "Pedro", "Maria" };
            Console.WriteLine("a) contiene:");
            Console.WriteLine(" ");
            int length1 = intArray.Length;
            Array.Sort(intArray);
            for (int i = 0; i < length1; i++)
            {
                Console.WriteLine(intArray[i]);
            }
            Console.WriteLine(" ");
            MuestraArreglo(intArray);
            Console.WriteLine("b) contiene:");
            Console.WriteLine(" ");
            double length2 = doubleArray.Length;
            Array.Sort(doubleArray);
            Console.WriteLine(" ");
            for (int i = 0; i < length2; i++)
            {
                Console.WriteLine(doubleArray[i]);
            }
            MuestraArreglo(doubleArray);
            Console.WriteLine("c) contiene:");
            Console.WriteLine(" ");
            int length3 = stringArray.Length;
            Array.Sort(stringArray);
            for (int i = 0; i < length3; i++)
            {
                Console.WriteLine(stringArray[i]);
            }
            Console.WriteLine(" ");
            MuestraArreglo(stringArray);
            Console.ReadKey();
        }
        private static void MuestraArreglo<T>(T[] arreglo)
        {
            foreach (T elemento in arreglo)
                Console.Write(elemento + " ");
            Console.WriteLine("\n");
        }
    }
}
