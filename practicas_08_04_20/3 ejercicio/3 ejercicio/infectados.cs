using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ejercicio
{
    class infectado
    {
        public infectado(string nombre, string primerapellido, string segundoapellido, string estado, string sexo, int edad)
        {
            this.nombre = nombre;
            this.primerapellido = primerapellido;
            this.segundoapellido = segundoapellido;
            this.estado = estado;
            this.sexo = sexo;
            this.edad = edad;
        }

        public String nombre { get; set; }
        public String primerapellido { get; set; }
        public String segundoapellido { get; set; }
        public String estado { get; set; }
        public String sexo { get; set; }

        public int edad { get; set; }

        override public string ToString()
        {
            return nombre + " " + primerapellido + " " + segundoapellido + " " + edad.ToString() + "     " + sexo + "     " + estado;
        }



    }
}
