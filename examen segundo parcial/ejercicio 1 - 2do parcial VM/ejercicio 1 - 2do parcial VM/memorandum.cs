using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_1___2do_parcial_VM
{
    class memorandum : documentos
    {
        public memorandum(string fecha, string asunto, string para)
        {
            Fecha = fecha;
            Asunto = asunto;
            Para = para;
            
        }

        public string Fecha { get; set; }
        public string Asunto { get; set; }
        public string Para { get; set; }
        override public string ToString()
        {
            return Fecha + " " + Asunto + "  " + Para + "  " ;
        }
    }
}
