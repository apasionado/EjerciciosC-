using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia0ALD8
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 8.	Realizar una aplicación que:
a.	Permita ingresar y almacenar una lista de productos. 
La lista se compone de código de producto y precio.

    */
            List<producto> listaProductos = new List<producto>();

            bool terminar = false;
            Console.WriteLine("Que operacion desea realizar");
            String operacion = Console.ReadLine();
            while (terminar != true)
                switch (operacion)
                {


                    case "a":
                        {
                            int ingreso = -1;
                            Console.WriteLine("Ingrese una lista de productos (codigo de producto). 0 para terminar \n");

                            while (ingreso != 0)
                            {
                                ingreso = Convert.ToInt32(Console.ReadLine());
                                if (ingreso != 0)
                                {
                                    listaProductos.Add(new producto { codigoProducto = ingreso });
                                    Console.WriteLine("Se agregó el producto con codigo: " + ingreso);

                                }
                                Console.WriteLine("Mostrando la lista");
                                foreach (producto producto in listaProductos)
                                {
                                    Console.WriteLine("Codigos de producto existentes: " + producto.codigoProducto);
                                }

                            }
                            break;

                        }
                    case "b":
                        {
                            /*
                             * b.	Permita ingresar y almacenar una lista de precios. 
                                La lista se compone de código de producto y precio. 
                                El ingreso finalizará cuando el usuario ingrese “0” como precio.*/

                            break;
                        }
                    case "c":
                        {
                            /*c.Permita ingresar una serie de productos (hasta que el usuario ingrese “0”) y 
                            presente el monto total de acuerdo a los ingresos anteriores.*/

                            break;
                        }

                }

        }
    }
}
