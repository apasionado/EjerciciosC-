using System.Collections.Generic;

namespace Guia0Integracion3
{
    internal class ListaDeTecnicos
    {
        public List<Tecnicos> tecnicoOperativo { get; set; }
        public List<Tickets> solicitudAsignada { get; set; }


        public ListaDeTecnicos(Tecnicos tecnico, Tickets ticket)
        {
            tecnicoOperativo.Add(tecnico);
            solicitudAsignada.Add(ticket);

        }
    }
}