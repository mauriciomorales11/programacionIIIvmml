using System;
using System.Collections.Generic;
using System.Text;

namespace _3roExamen
{
   abstract class AbstracProducto
    {
        protected String nombre;



        public String getNombre()
        {
            return nombre;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public abstract double getPrecio(); 
    }
}
