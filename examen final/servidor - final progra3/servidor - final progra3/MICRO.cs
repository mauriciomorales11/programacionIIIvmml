using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace micro___final_de_programacion_3
{
    class MICRO
    {
        static MICRO instancia;
        private MICRO()
        {
        }

        public static MICRO getInstancia()
        {
            if (instancia == null)
            {
                instancia = new MICRO();
            }
            return instancia;
        }
        protected DateTime inicio;
        protected DateTime fin;
        protected String nombre;
        protected int costo;
        protected int tamaño;
        List<PERSONA> personas;
        private PERSONA[] puestos;
        int numeropuesto;

        public MICRO(string nombre, int costo, int tamaño, List<PERSONA> personas)
        {
            this.nombre = "Bus Univalle";
            this.costo = 1;
            this.tamaño = 23;
            this.personas = new List<PERSONA>();
            this.puestos = new PERSONA[tamaño];

        }

        public string IngresarPersona(string nombre, string apellido, int edad)
        {
            PERSONA persona = new PERSONA(nombre, apellido, edad);
            int numeropuesto = 0;

            if (numeropuesto == -1)
            {
                return "no hay espacio";
            }
            else
            {

                puestos[numeropuesto].getNombre(); ;
                return "Su lugar es: " + numeropuesto.ToString();
            }

        }
        public string SalidaPersona(string nombre)
        {
            int numeropuesto = BuscarPuesto(nombre);
            if (numeropuesto != -1)
            {
                double horastotal = 1;
                double tarifa = horastotal * costo;
                return "Su tarifa es: " + Convert.ToString(tarifa);
            }
            else
            {
                return "no existe la placa";
            }
        }
        private int BuscarPuesto(string placa)
        {
            int indice = -1, i = 0;
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
        public double SalidaPersona()
        {
            this.personas = null;
            fin = DateTime.Now;
            TimeSpan total = fin - inicio;
            return total.TotalHours;
        }
        public void GetDatos()
        {
            for (int i = 0; i < this.puestos.Count(); i++)
            {
                if (puestos[i].Ocupado())
                {
                    Console.WriteLine("pesto {0} Ocupadoc{1}", i, puestos[i].getNombre());
                }
                else
                {
                    Console.WriteLine("Puesto {0} Ocupado", i);
                }
            }
        }
        public Boolean Ocupado()
        {
            return (this.personas != null);
        }



    }
}
