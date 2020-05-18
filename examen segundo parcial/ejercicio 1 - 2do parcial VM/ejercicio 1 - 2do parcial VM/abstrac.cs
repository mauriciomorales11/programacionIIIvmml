using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_1___2do_parcial_VM
{
    interface abstrac
    {
        carta Getcarta(string fecha, string origen, string asunto);
        circular Getcircular(string de, string fecha, string para, string asunto);
        memorandum Getmemorandum(string fecha, string asunto, string para);
    }
}
