namespace Guia0Integracion3
{
    internal class Tickets
    {
        private string clienteIngresado;
        private string zonaIngresada;

        public string numeroSolicitud { get; set; }
        public string cliente { get; set; }

        public string zona { get; set; }
        public string responsable { get; set; }

        public Tickets(string cliente, string zona)
        {

            this.numeroSolicitud += 1;

            this.cliente = cliente;

            this.zona = zona;
        }

    }
}