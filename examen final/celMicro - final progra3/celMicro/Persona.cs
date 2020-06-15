using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace celMicro
{
    class Persona
    {
        protected String Nombres;
        protected String Apellido;
        protected Sexo sexo;
        protected int Edad;
        private Persona puesto;
        private List<string> historial;



        public Persona(string nombres, string apellido, Sexo sexo, int edad)
        {
            Nombres = nombres;
            Apellido = apellido;
            this.sexo = sexo;
            this.Edad = edad;
        }
        public Persona(int numero)
        {
            puesto = new Persona(numero);
            historial = new List<string>();
        }

        public string getNombre()
        {
            return Nombres;
        }
        public void setAlto(string nombre)
        {
            this.Nombres = nombre;
        }
        public string getApellido()
        {
            return Nombres;
        }
        public void setApellido(string apellido)
        {
            this.Apellido = apellido;
        }
        public Sexo getSexo()
        {
            return sexo;
        }
        public void setSexo(Sexo sexo)
        {
            this.sexo = sexo;
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
            return sexo.ToString() + "Nombre " + Nombres + " Apellido " + Apellido + "" + Edad + sexo.ToString();
        }

        internal bool estaOcupado()
        {
            throw new NotImplementedException();
        }

        internal void getIndicePuesto()
        {
            throw new NotImplementedException();
        }
    }
    enum Sexo
    {
        masculino, femenino
    }
}
}