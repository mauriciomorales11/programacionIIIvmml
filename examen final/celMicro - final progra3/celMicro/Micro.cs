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
    class Micro
    {
        static Micro instance;
        private Micro()
        {
        }



        public static Micro getInstance()
        {
            if (instance == null)
            {
                instance = new Micro();
                return instance;
            }

            return instance;



        }
        protected DateTime inicio;
        protected DateTime fin;
        protected string nombre;
        protected int tamaño;
        protected int capacidad;
        protected int precio;
        protected double costo;
        int nrpuesto;
        private Persona[] puestos;
        List<Persona> personas;

        public Micro(string nombre, int tamaño, int capacidad, int precio, double costo)
        {
            this.nombre = "Bus Univalle";
            this.tamaño = 23;
            this.capacidad = 23;
            this.precio = 1;
            this.costo = 1;
            this.personas = new List<Persona>();
            this.puestos = new Persona[capacidad];
            for (int i = 0; i < this.puestos.Count(); i++)
            {
                this.puestos[i] = new Persona(i);
            }
        }
        private int getIndicePuesto()
        {
            int indice = -1;
            int i = 0;
            while ((i < puestos.Count()) && indice == -1)
            {
                if (!puestos[i].estaOcupado())
                {
                    indice = i;
                }
                i++;
            }
            return indice;
        }
        public void ingresarPersona(Persona y)
        {
            //Persona persona = new Persona(nombre, apellido, sexo, edad);
            int nropuesto = getIndicePuesto();
            if (nropuesto == -1)
                personas.Add(y);
            else
            {
                puestos[nropuesto].getIndicePuesto();

            }
        }
        public string SalirPersona(string nombre)
        {
            int nropuesto = buscarPuesto(nombre);
            if (nropuesto != -1)
            {
                double totalhoras = 1;
                double tarifa = totalhoras * costo;
                return "su tarifa es " + Convert.ToString(tarifa);
            }
            else
                return "placa no encontrada";
        }
        private int buscarPuesto(string placa)
        {
            int indice = -1;
            int i = 0;
            while ((i < puestos.Count()) && indice == -1)
            {
                if (puestos[i].getNombre() == placa)
                {
                    indice = i;
                }
                i++;

            }
            return indice;
        }
        public double salirPersona()
        {
            this.personas = null;
            fin = DateTime.Now;
            TimeSpan total = fin - inicio;
            return total.TotalHours;
        }
        public void getDatos()
        {
            for (int i = 0; i < this.puestos.Count(); i++)
            {
                if (puestos[i].estaOcupado())
                    Console.WriteLine("Puesto {0} Ocupado auto {1}", i, puestos[i].getNombre());
                else
                    Console.WriteLine("Puesto {0} Ocupado", i);
            }
        }
        public Boolean estaOcupado()
        {
            return (this.personas != null);
        }

    }
}
