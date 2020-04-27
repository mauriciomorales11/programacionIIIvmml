using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipe
{
    class procesador
    {
        String Marca;
        int CantidadNucleos;
        double Frecuencia;

        public procesador(string marca, int cantidadNucleos, double frecuencia)
        {
            Marca = marca;
            CantidadNucleos = cantidadNucleos;
            Frecuencia = frecuencia;
        }

        public override string ToString()
        {
            return Marca + CantidadNucleos.ToString() + Frecuencia.ToString();
        }
    }
}
