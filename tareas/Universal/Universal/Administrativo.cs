﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universal
{
    class Administrativo : Persona
    {

        public override String getDatos()
        {
            return "Administrativo: " + nombres + " " + apellidos;
        }
    }
}
