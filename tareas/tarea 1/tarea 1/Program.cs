﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_1
{

    public class Program
    {
        public static void Main()
        {
            int m = 0, num = 0;
            Console.WriteLine("Cuantos numeros va ingresar");
            int numeros = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numeros; i++)
            {
                Console.WriteLine("Digite un numero:");
                num = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    m = num;
                }
                if (num > m)
                {
                    m = num;
                }
                num = 0;
            }
            Console.WriteLine("numero mayor es:" + m);
        }
    }


}
