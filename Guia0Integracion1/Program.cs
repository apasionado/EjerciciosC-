using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia0Integracion1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1Confeccionar una agenda a partir del siguiente menú principal: 
                m.	Ingresar datos (Apellido, Nombre, Teléfono)
                n.	Buscar por apellido 
                o.	Buscar por nombre 
                p.	Grabar datos
                q.	Leer datos
                r.	Finalizar
                */


            comandosDisponibles();

        }

        static void comandosDisponibles()
        {
            bool terminar = false;

            Console.WriteLine("Menu principal");
            Console.WriteLine("a. Ingresar datos" +
                "\nb. buscar por apellido " +
                "\nc buscar por nombre" +
                "\nd Grabar datos" +
                "\ne Leer datos" +
                "\nf Finalizar");


            do
            {
                Console.WriteLine("Que operación desea realizar?");
                string comando = Console.ReadLine();
                List<Agenda> agenda = new List<Agenda>();

                switch (comando)
                {
                    case "a":
                        Console.WriteLine("Agregue un teléfono a la agenda");
                        string telefono = Console.ReadLine();
                        Console.WriteLine("Agregue un nombre a la agenda");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Agregue un apellido a la agenda");
                        string apellido = Console.ReadLine();

                        agenda.Add(new Agenda
                        {
                            telefono = telefono,
                            nombre = nombre,
                            apellido = apellido
                        });
                        Console.WriteLine("Se ha agregado los contactos a la agenda exitosamente");

                        break;
                    case "b":

                        Console.WriteLine("Ingrese el apellido que desea buscar");
                        apellido = Console.ReadLine();

                        //si agenda tiene el apellido, mostrarlo.
                        if (agenda))
                        {

                        }

                        break;
                    case "c":
                        break;
                    case "d":
                        break;
                    case "e":
                        break;
                    case "f":
                        break;
                    default:
                        Console.WriteLine("Comando invalido");
                        comando = Console.ReadLine();
                        break;

                }
            } while (!terminar);
        }
    }
}
