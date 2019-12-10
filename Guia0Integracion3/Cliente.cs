using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia0Integracion3
{
    class Cliente
    {
        public Cliente(string razonSocial, string zona)
        {
            RazonSocial = razonSocial;
            Zona = zona;
        }

        public string RazonSocial { get; }
        public string Zona { get; }
    }
}
