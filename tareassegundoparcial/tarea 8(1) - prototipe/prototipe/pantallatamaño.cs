using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipe
{
    class pantallatamaño
    {
        int alto;
        int ancho;

        public pantallatamaño(int alto, int ancho)
        {
            this.alto = alto;
            this.ancho = ancho;
        }

        public override string ToString()
        {
            return alto.ToString() + ancho.ToString();
        }
    }
}
