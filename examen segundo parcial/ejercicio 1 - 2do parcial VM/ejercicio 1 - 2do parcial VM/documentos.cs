using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_1___2do_parcial_VM
{
    abstract class documentos : abstrac
    {
        private string documen;

        public documentos(string documen)
        {
            this.documen = documen;
        }

        public carta Getcarta(string fecha, string origen, string asunto)
        {
            throw new NotImplementedException();
        }

        public circular Getcircular(string de, string fecha, string para, string asunto)
        {
            throw new NotImplementedException();
        }

        public memorandum Getmemorandum(string fecha, string asunto, string para)
        {
            throw new NotImplementedException();
        }

       
}   }
