﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetodosGenericos
{

    class Program
    {
        static void Main(string[] args)

        {


            int n = 0, m = 0;
            int[] a = { 2, 6, 5, 1, 3, 4 };
            double l = 0, k = 0;
            double[] b = { 3.3, 6.6, 4.4, 5.5, 7.7, 2.2, 1.1 };

            char[] c = { 'H', 'Z', 'U', 'O', 'L', 'A' };
            Console.WriteLine("a  es:");


            for (int x = 1; x < 6; x++)
            {
                for (int y = 0; y < 6 - 1; y++)
                {

                    if (a[x] < a[y])
                    {
                        m = a[x];
                        a[x] = a[y];
                        a[y] = m;
                    }

                }

            }
            for (int r = 0; r < n; r++)
                Console.WriteLine("{0},-{0}", r + 1, a[r]);

            MuestraArreglo(a);


            Ordenar(a);

            MuestraArreglo(a);
            Console.WriteLine("b es:");

            MuestraArreglo(b);

            Ordenar(b);

            MuestraArreglo(b);




            Console.WriteLine("c es:");

            int length = c.Length;

            Array.Sort(c);

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(c[i]);
            }

            MuestraArreglo(c);
            Console.ReadKey();
        }

        private static void Ordenar<T>(T[] a)
            where T : IComparable<T>
        {
            for (int j = 0; j < a.Length; j++)
            {
                for (int i = 0; i < a.Length - 1 - j; i++)
                {
                    if (a[i].CompareTo(a[i + 1]) < 0)
                    {
                        T aux = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = aux;
                    }
                }
            }
        }

        private static void MuestraArreglo<T>(T[] arreglo)
            where T : IComparable<T>
        {
            foreach (T elemento in arreglo)
                Console.Write(elemento + " ");
            Console.WriteLine("\n");

        }

    }
}