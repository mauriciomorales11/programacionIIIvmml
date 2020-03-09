using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos1
{

    public delegate void ActualizacionEventHandler(string msg);

    public class x
        {
            //atributo
            public int a ,b,c;

           
            public event ActualizacionEventHandler NombreCambiado;

            public x(int raiz)
            {
                raiz=b*b-4*a*c;
            }

            public void setNombre(int raiz)
            {
                
                

           
            if  (raiz<0)
             if (this.NombreCambiado != null)
                    this.NombreCambiado("no es posible");
            }

        }
   }


