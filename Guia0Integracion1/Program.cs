using System;
using System.Collections.Generic;
using System.IO;
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
            List<Agenda> agenda = new List<Agenda>();

            do
            {
                Console.WriteLine("Que operación desea realizar?");
                string comando = Console.ReadLine();


                switch (comando)
                {
                    case "a":
                        Console.WriteLine("Agregue un teléfono a la agenda");
                        string telefonoObtenido = Console.ReadLine();
                        Console.WriteLine("Agregue un nombre a la agenda");
                        string nombreObtenido = Console.ReadLine();
                        Console.WriteLine("Agregue un apellido a la agenda");
                        string apellidoObtenido = Console.ReadLine();


                        agenda.Add(new Agenda
                        {
                            telefono = telefonoObtenido,
                            nombre = nombreObtenido,
                            apellido = apellidoObtenido
                        });
                        Console.WriteLine("Se ha agregado los contactos a la agenda exitosamente");
                        Console.WriteLine("Contactos en la agenda: " + agenda.Count);

                        break;
                    case "b":

                        Console.WriteLine("Ingrese el apellido que desea buscar");
                        string apellidoABuscar = Console.ReadLine();

                        //si agenda tiene el apellido, mostrarlo.
                        int vecesEncontradoEnAgenda = 0;

                        for (int i = 0; i < agenda.Count; i++)
                        {
                            if (agenda[i].apellido.Equals(apellidoABuscar))
                            {
                                vecesEncontradoEnAgenda += 1;
                            }
                        }


                        if (vecesEncontradoEnAgenda > 0)
                        {
                            Console.WriteLine("Se encontró " + vecesEncontradoEnAgenda + " el apellido " + apellidoABuscar);
                        }
                        else
                        {
                            Console.WriteLine("No se encontró el apellido que buscabas en la agenda");
                        }

                        break;
                    case "c":
                        // si agenda tiene un nombre, mostrarlo

                        Console.WriteLine("Ingrese el nombre que desea buscar");
                        string nombreABuscar = Console.ReadLine();

                        vecesEncontradoEnAgenda = 0;

                        for (int i = 0; i < agenda.Count; i++)
                        {
                            if (agenda[i].nombre.Equals(nombreABuscar))
                            {
                                vecesEncontradoEnAgenda += 1;
                            }
                        }

                        if (vecesEncontradoEnAgenda > 0)
                        {
                            Console.WriteLine("Se encontró " + vecesEncontradoEnAgenda + " el apellido " + nombreABuscar);
                        }
                        else
                        {
                            Console.WriteLine("No se encontró el apellido que buscabas en la agenda");
                        }

                        break;
                    case "d":


                        Console.WriteLine("Ingrese la ruta donde va a grabar el archivo");
                        string ruta = Console.ReadLine();

                        if (!File.Exists(ruta))
                        {
                            using (StreamWriter sw = File.CreateText(ruta))
                            {
                                foreach (Agenda fila in agenda)
                                {
                                    sw.WriteLine("Nombre: " + fila.nombre + "\nApellido: " + fila.apellido + "\nTelefono: " + fila.telefono + "\n------------");
                                }
                            }
                        }
                        else
                        {
                            {
                                using (StreamWriter sw = File.AppendText(ruta))
                                {
                                    foreach (Agenda fila in agenda)
                                    {
                                        sw.WriteLine("Nombre: " + fila.nombre + "\nApellido: " + fila.apellido + "\nTelefono: " + fila.telefono + "\n------------");
                                    }
                                }
                            }
                        }



                        break;
                    case "e":

                        Console.WriteLine("Ingrese la ruta de donde va a leer los ingresos");
                        ruta = Console.ReadLine();
                        if (!File.Exists(ruta))
                        {
                            Console.WriteLine("El archivo que intenta leer no existe.");
                        }
                        else
                        {
                            Console.WriteLine("Mostrando cadenas existentes en la lista \n-----------------------");
                            using (StreamReader sr = File.OpenText(ruta))
                            {
                                string s;
                                while ((s = sr.ReadLine()) != null)
                                {
                                    Console.WriteLine(s);
                                }
                            }
                        }

                        break;
                    case "f":

                        terminar = true;
                        Console.WriteLine("chau chau");
                        Console.ReadKey();

                        break;
                    case "mostrar":


                        foreach (Agenda fila in agenda)
                        {

                            Console.WriteLine("Nombre: " + fila.nombre + "\nApellido: " + fila.apellido + "\nTelefono: " + fila.telefono + "\n------------");
                        }

                        break;
                    default:
                        Console.WriteLine("Comando invalido");
                        break;
                }
            } while (!terminar);
        }
    }
}
