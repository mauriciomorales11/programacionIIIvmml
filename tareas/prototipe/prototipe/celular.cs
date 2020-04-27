using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipe
{
    class Celular
    {
        Marca marca;
        string Modelo;
        pantallatamaño pantallatamaño;
        Color color;
        int memoria;
        procesador procesador;
        public Celular(Marca marca, string modelo, pantallatamaño pantallatamaño, Color color, int memoria, procesador procesador)
        {
            this.marca = marca;
            Modelo = modelo;
            this.pantallatamaño = pantallatamaño;
            this.color = color;
            this.memoria = memoria;
            this.procesador = procesador;
        }
        public override string ToString()
        {
            return marca + Modelo + pantallatamaño + color + memoria + procesador;
        }
        public object Clone()
        {
            return MemberwiseClone();
        }

    }
    enum Marca
    {
        apple, samsung, htc
    }
    enum Color
    {
        Rojo, Negro, Plateado
    }
}
