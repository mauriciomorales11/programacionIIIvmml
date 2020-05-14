using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universal
{
    class Program
    {
       
            static void Main(string[] args)
            {
                

                FabricaPersona fabricapersonas = new FabricaPersona();
              
                Persona Daniel = fabricapersonas.getPersona("alumno");
                

                Daniel.setDatos("Victor", "Morales", Sexo.Masculino, "11/02/1998", 12488437, "victormauriciomoraleslopez7@gmail.com");
                Console.WriteLine(Daniel.getDatos());
                FabricaAula fabricaaulas = new FabricaAula();

                Aula a = fabricaaulas.getAula("teoria", null);
                a.setDatos("A303", new Ubicacion(1, 3), new Tamaño(3, 5), 30);
                List<Computadora> ab = new List<Computadora>();
                List<DiscoDuro> l = new List<DiscoDuro>();
                l.Add(new DiscoDuro("toshiba", 2, MedidaCapacidad.Tb));
                Computadora c = new Computadora(Marca.Hp, "tinkpad", new Procesador("Intel", 24), l, Color.negro, 2019);
                for (int i = 1; i <= 18; i++)
                {
                    ab.Add((Computadora)c.Clone());
                }
                Aula l302 = fabricaaulas.getAula("laboratorio", ab);
                l302.setDatos("L302", new Ubicacion(1, 4), new Tamaño(3, 5), 25);
                Console.WriteLine(a.getDatos());
                

                Console.WriteLine(a);
               
             

                Console.ReadKey();

            }
        
    }
}
