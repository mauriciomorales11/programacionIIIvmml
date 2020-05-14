using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipe
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular a = new Celular(Marca.apple, " ", new pantallatamaño(10, 7), Color.Rojo, 16, new procesador(" ", 7, 3));
            Celular b = (Celular)a.Clone();
            Celular b1 = (Celular)a.Clone();
            Celular b2 = (Celular)a.Clone();
            Celular b3 = (Celular)a.Clone();
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}

