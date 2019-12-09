using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia0Integracion3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 55.	Se le ha encomendado la programación de un sistema de Administración de Solicitudes de Mantenimiento.
             * La empresa cliente cuenta con un plantel fijo de 30 técnicos, identificados por números de legajo
             * consecutivos comenzando desde 1.
        Al comienzo del día se reciben las Solicitudes de Mantenimiento. Cada una cuenta con los siguientes datos:
        a.	Número de Solicitud de Mantenimiento (identificador único)
        b.	Razón Social o Nombre del Cliente
        c.	Zona (Centro, Zona Norte, Zona Sur, Zona Oeste)
        El sistema asignará automáticamente cada Solicitud a un técnico, cumpliendo con las siguientes condiciones:
        a.	Puede haber más de una Solicitud del mismo cliente. En este caso el sistema debe asignarlas al mismo técnico. 
        b.	No pueden asignarse más de cuatro Solicitudes por día a cada técnico. 
        c.	Todas las órdenes asignadas a un técnico deben ser dentro de una misma zona 
        (varios técnicos pueden trabajar en la misma zona).
        
        …y presentará una lista de técnicos, indicando en qué zona trabajarán, 
        sus clientes asignados y la cantidad de solicitudes asignadas.
    */

            List<ListaDeTecnicos> listaDeTecnicos = new List<ListaDeTecnicos>();
            bool terminar = false;


            do
            {
                Console.Clear();
                Console.WriteLine("1.Crear un ticket nuevo aleatorio y asignarlo automaticamente");
                Console.WriteLine("2.Crear ticket automaticamente y asignarlo automaticamente");
                Console.WriteLine("2.Ver los tickets creados y a qué técnico pertenecen");
                Console.WriteLine("3.Finalizar");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Tickets t;
                        t = crearTicket();
                        asignarTicketAutomaticamente(t);
                        break;
                    case "2":
                        crearTicketAutomaticamente();
                        asignarTicketAutomaticamente(ticket);
                        break;
                    case "3":
                        verTickets();
                        break;
                    case "4":
                        terminar = true;
                        break;
                    default:
                        Console.WriteLine("Comando invalido");
                        break;
                }
            } while (!terminar);

            Console.ReadKey();

        }

        public static Tickets crearTicket()
        {
            Console.WriteLine("Ingrese una zona");
            string zonaIngresada = Console.ReadLine();
            Console.WriteLine("Ingrese un nombre de cliente o razon social");
            string clienteIngresado = Console.ReadLine();

            Tickets ticket = new Tickets(clienteIngresado, zonaIngresada);
            return ticket;
        }
        public static List<ListaDeTecnicos> asignarTicketAutomaticamente(Tickets t, List<ListaDeTecnicos> lista)
        {
            /*a. * Puede haber más de una Solicitud del mismo cliente. 
             * En este caso el sistema debe asignarlas al mismo técnico. 
                b.	No pueden asignarse más de cuatro Solicitudes por día a cada técnico. 
                c.	Todas las órdenes asignadas a un técnico deben ser dentro de una misma zona 
                (varios técnicos pueden trabajar en la misma zona).*/

            //Verificar si algun tecnico ya tiene el ticket (o el nombre del ticket)
            //, o coincide la zona, o si ya excedió el limite de solicitudes
            Console.WriteLine("Iniciando asignación automática");

            foreach (var gestion in lista)
            {
                if (gestion.tecnicoOperativo.Contains())
                    if (gestion.solicitudAsignada.Contains(t))
                    {
                        Console.WriteLine("Este ticket ya existe en la lista de tickets")
                    }
            }

            return lista.Add(new ListaDeTecnicos { legajoDelTecnico = tecnicoOperador });
        }
        public static Tickets crearTicketAutomaticamente
    }
}
