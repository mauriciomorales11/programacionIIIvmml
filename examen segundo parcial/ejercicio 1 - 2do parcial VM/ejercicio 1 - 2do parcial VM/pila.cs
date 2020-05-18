﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_1___2do_parcial_VM
{
    class pila<T>
    {
        public const int Maximo = 10;
        private T[] arreglo = new T[Maximo];
        private int tope = -1;
        public void push(T valor)
        {
            if (!LLena())
            {
                tope++;
                arreglo[tope] = valor;
            }
            else
                Console.WriteLine("La Pila esta llena");
        }
        public T pop()
        {
            if (!Vacia())
            {
                tope--;
                return arreglo[tope + 1];
            }
            else
            {
                Console.WriteLine("La Pila esta vacia");
                return arreglo[tope + 1];
            }
        }
        public void mostrar()
        {
            for (int i = 0; i <= tope; i++)
                Console.WriteLine(arreglo[i].ToString() + " ");

        }
        private Boolean Vacia()
        {
            return tope == -1;
        }
        private Boolean LLena()
        {
            return tope == Maximo;
        }
    }
}
