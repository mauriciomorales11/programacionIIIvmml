using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_1___2do_parcial_VM
{
    class carta : documentos 
    {
        public carta(string fecha,string origen, string asunto)
        {
            Fecha = fecha;
            Origen = origen;
            Asunto = asunto;
            

        }
        public string Fecha { get; set; }
        public string Origen { get; set; }
        public string Asunto { get; set; }
        override public string ToString()
        {
            return Fecha + " " + Origen + "  " + Asunto + "  ";
        }
    }
}
