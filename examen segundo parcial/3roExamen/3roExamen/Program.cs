using System;

namespace _3roExamen
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductoSimple cerveza = new ProductoSimple("cerveza ", 20);
            ProductoSimple cervezaregalo = new ProductoSimple("cerveza regalo", 0);
            ProductoSimple ron = new ProductoSimple("ron", 70);
            ProductoSimple whisky = new ProductoSimple("whisky", 100);
            ProductoSimple cocacola = new ProductoSimple("coca cola", 15);
            ProductoCompuesto caja = new ProductoCompuesto("caja",0);
            caja.insertarIngrediente(cerveza);
            caja.insertarIngrediente(cerveza);
            caja.insertarIngrediente(cerveza);
            caja.insertarIngrediente(cerveza);
            caja.insertarIngrediente(cerveza);
            caja.insertarIngrediente(cerveza);
            caja.insertarIngrediente(cerveza);
            caja.insertarIngrediente(cerveza);
            caja.insertarIngrediente(cerveza);
            caja.insertarIngrediente(cerveza);
            caja.insertarIngrediente(cerveza);
            caja.insertarIngrediente(cerveza);

            caja.insertarIngrediente(cerveza);
            ProductoCompuesto tiras = new ProductoCompuesto("combo carnavalero: ron + coca cola",0);
            tiras.insertarIngrediente(ron);
            tiras.insertarIngrediente(cocacola);
            tiras.insertarIngrediente(cocacola);


            OrdenCompra gammerOrden = new OrdenCompra(1, "1 opcion");
            gammerOrden.insertarProducto(tiras);
            
            gammerOrden.imprimirOrden();

            OrdenCompra gammerOrden2 = new OrdenCompra(1, "2 opcion");
            gammerOrden2.insertarProducto(caja);
            gammerOrden2.insertarProducto(cervezaregalo);
            gammerOrden2.imprimirOrden();

            Console.ReadKey();

        }
    }
}
