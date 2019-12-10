using System;
using System.Collections.Generic;

namespace Guia0Integracion3
{
    internal class Tecnico
    {
        public string Zona { get; private set; }
        public List<Cliente> Clientes { get; } = new List<Cliente>();
        public int CantidadSolicitudes { get; private set; }

        internal bool AceptaSolicitud(Solicitud solicitud)
        {
            if (Zona != null && solicitud.Zona != Zona)
            {
                return false;
            }

            if (CantidadSolicitudes == 4)
            {
                return false;
            }

            CantidadSolicitudes++;

            if (!Clientes.Contains(solicitud.Cliente))
            {
                Clientes.Add(solicitud.Cliente);
            }

            if(Zona == null)
            {
                Zona = solicitud.Zona;
            }

            return true;
        }

        internal bool TieneCliente(Cliente cliente) => Clientes.Contains(cliente);
    }
}