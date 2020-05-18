using System;
using System.Collections.Generic;
using System.Text;

namespace _3roExamen
{
    class ProductoSimple:AbstracProducto
    {
        protected double precio;

        public ProductoSimple(string nombre, double precio)
        {
            this.nombre = nombre;
            this.precio = precio;

        }


        public override double getPrecio()
        {
            return precio;
        }

        public void setPrecio(double precio1)
        {
            precio = precio1;
        }

    }
}
