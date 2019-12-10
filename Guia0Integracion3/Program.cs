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
            Tecnico[] tecnicos = new Tecnico[30];
            do
            {
                ConsoleKeyInfo deseaContinuar;
                do
                {
                    Console.WriteLine("¿Desea cargar otra solicitud de mantenimiento (S/N)?");
                    deseaContinuar = Console.ReadKey();
                    if (deseaContinuar.Key != ConsoleKey.N && deseaContinuar.Key != ConsoleKey.S)
                    {
                        Console.WriteLine("Ingrese S o N");
                        continue;
                    }
                }
                while (false);

                if (deseaContinuar.Key == ConsoleKey.N)
                {
                    break;
                }

                //pedir datos necesarios de la orden y hacer cuentas.

                //zona
                //cliente (buscarlo en lista)

                var solicitud = new Solicitud(new Cliente("pepe", "lolo"));

                bool aceptada = false;

                //si hay un tecnico q tenga ese cliente => tiene prioridad.
                if (tecnicos.FirstOrDefault(t => t.TieneCliente(solicitud.Cliente)) is Tecnico tecnicoMismoCliente)
                {
                    aceptada = tecnicoMismoCliente.AceptaSolicitud(solicitud);
                }

                if (!aceptada)
                {
                    foreach (var tecnico in tecnicos)
                    {
                        aceptada = tecnico.AceptaSolicitud(solicitud);
                        if (aceptada)
                        {
                            break;
                        }
                    }
                }

                if (!aceptada)
                {
                    Console.WriteLine("No se puede asignar.");
                }

            } while (true);


            //mostrar resultados



            Console.ReadKey();

        }
    }
}
