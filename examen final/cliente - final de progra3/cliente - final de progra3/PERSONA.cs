﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cliente___final_de_progra3
{
    class PERSONA
    {
        protected String Nombre;
        protected String Apellido;
        protected Sexo sexo;
        protected int Edad;
        public PERSONA(string nombre, string apellido, Sexo sexo, int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            this.sexo = sexo;
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
            return Nombre.ToString() + " " + Apellido.ToString() + "sexo: " + sexo + " " + Edad.ToString();
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
