using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace micro___final_de_programacion_3
{
    class PERSONA
    {
        protected String Nombre;
        protected String Apellido;
        protected int Edad;
        public PERSONA(string nombre, string apellido, int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;


        }
        public string getNombre()
        {
            return Nombre;
        }
        public void setNombre(string nombre)
        {
            this.Nombre = nombre;
        }
        public string getApellido()
        {
            return Apellido;
        }
        public void setApellido(string apellido)
        {
            this.Apellido = apellido;
        }
        public int getEdad()
        {
            return Edad;
        }
        public void setEdad(int edad)
        {
            this.Edad = edad;
        }
        public override string ToString()
        {
            return Nombre.ToString() + " " + Apellido.ToString() + " " + Edad.ToString();
        }

        internal bool Ocupado()
        {
            throw new NotImplementedException();
        }
    }

    enum Sexo
    {
        Masculino, Femenino
    }

}
