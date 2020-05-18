using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_1___2do_parcial_VM
{
    class circular : documentos
    {
        public circular(string de, string fecha, string para, string asunto)
        {
            De = de;
            Fecha = fecha;
            Para = para;
            Asunto = asunto;
        }
        public string De { get; set; }
        public string Fecha { get; set; }
        public string Para { get; set; }
        public string Asunto { get; set; }
        override public string ToString()
        {
            return De + " " + Fecha + " " + Para + "  " + Asunto + "  ";
        }
    }
}
