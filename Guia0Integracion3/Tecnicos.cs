using System;
using System.Collections.Generic;

namespace Guia0Integracion3
{
    internal class Tecnicos
    {
        public string legajo { get; set; }
        public List<string> solicitudesPendientes { get; set; }

        int limiteSolicitud { get; set; }

        public Tecnicos(int totalDeTecnicos)
        {
            if (totalDeTecnicos < 30)
            {
                this.legajo += 1;
                this.limiteSolicitud = 4;
            }
            else
            {
                Console.WriteLine("No ha sido posible crear el técnico, se ha llegado al limite de técnicos.");
            }
        }

    }
}