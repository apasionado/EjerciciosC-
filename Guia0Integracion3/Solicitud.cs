namespace Guia0Integracion3
{
    internal class Solicitud
    {
        public Solicitud(Cliente cliente)
        {
            Cliente = cliente;
        }

        public Cliente Cliente { get; }
        public string Zona => Cliente.Zona;
    }
}
