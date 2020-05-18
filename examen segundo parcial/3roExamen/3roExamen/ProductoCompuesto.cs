using System;
using System.Collections.Generic;
using System.Text;

namespace _3roExamen
{
    class ProductoCompuesto:AbstracProducto
    {
        private List<AbstracProducto> componentes = new List<AbstracProducto>();



        protected double descuento;

        public ProductoCompuesto(String nombre, double descuento)
        {
            this.nombre = nombre;
            this.descuento = descuento;

        }


        public void insertarIngrediente(AbstracProducto componente)
        {
            this.componentes.Add(componente);
        }

        public bool eliminarProductos(AbstracProducto producto)
        {
            return this.componentes.Remove(producto);
        }

        public override double getPrecio()
        {
            double precio = 0;
            foreach (AbstracProducto producto in componentes)
            {
                precio += producto.getPrecio();

            }
            precio = precio - descuento;
            return precio;

        }
    }

}

