using System;
using System.Collections.Generic;

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

            //REVISAR POR QUE LAS LISTAS SE REPRODUCEN MAL

            bool terminar = false;
            bool terminarA = false;
            bool terminarB = false;
            bool terminarC = false;
            Console.WriteLine("Que operacion desea realizar" +
                "\n a -> Permite ingresar una lista de codigos de productos" +
                "\n b -> Permite ingresar una lista de precios de productos" +
                "\n c -> Permite ingresar una serie de productos en una lista (Codigo y precio del producto)");

            String operacion = Console.ReadLine();
            while (terminar != true)

                if (operacion.Equals("a") || operacion.Equals("b") || operacion.Equals("c"))

                {


                    switch (operacion)
                    {



                        case "a":
                            {
                                int ingreso = -1;
                                Console.WriteLine("Ingrese una lista de productos (codigo de producto). 0 para terminar \n");

                                while (terminarA != true)
                                {
                                    ingreso = Convert.ToInt32(Console.ReadLine());
                                    if (ingreso != 0)
                                    {
                                        listaProductos.Add(new producto { codigoProducto = ingreso });
                                        Console.WriteLine("Se agregó el producto con codigo: " + ingreso);

                                    }
                                    else
                                    {
                                        terminarA = true;
                                    }

                                    Console.WriteLine("Mostrando la lista de codigos");
                                    foreach (producto producto in listaProductos)
                                    {
                                        Console.WriteLine("Codigos de producto existentes: " + producto.codigoProducto);
                                    }

                                }
                                if (terminarA == true)
                                {
                                    Console.WriteLine("Seleccione que otra operacion desea realizar");
                                    operacion = Console.ReadLine();
                                }
                                break;

                            }
                        case "b":
                            {
                                /*
                                 * b.	Permita ingresar y almacenar una lista de precios. 
                                    La lista se compone de código de producto y precio. 
                                    El ingreso finalizará cuando el usuario ingrese “0” como precio.*/

                                int ingreso = -1;
                                Console.WriteLine("Ingrese una lista de precios, 0 para terminar");
                                while (terminarB != true)
                                {
                                    ingreso = Convert.ToInt32(Console.ReadLine());

                                    if (ingreso != 0)
                                    {
                                        listaProductos.Add(new producto { precio = ingreso });
                                        Console.WriteLine("Se agregó el producto con precio: " + ingreso);
                                    }
                                    else
                                    {
                                        terminarB = true;
                                    }
                                    Console.WriteLine("Mostrando la lista de precios");
                                    foreach (producto producto in listaProductos)
                                    {
                                        Console.WriteLine("Precios existentes: " + producto.precio);
                                    }

                                }
                                if (terminarB == true)
                                {
                                    Console.WriteLine("Seleccione que otra operacion desea realizar");
                                    operacion = Console.ReadLine();
                                }

                                break;
                            }
                        case "c":
                            {
                                /*c.Permita ingresar una serie de productos (hasta que el usuario ingrese “0”) y 
                                presente el monto total de acuerdo a los ingresos anteriores.*/

                                int codigoProducto = -1;
                                int precio = -1;

                                Console.WriteLine("Ingrese una serie de productos, 0 para terminar");

                                while (terminarC != true)
                                {
                                    Console.WriteLine("Ingrese codigo del producto");
                                    codigoProducto = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Ingrese precio del producto");
                                    precio = Convert.ToInt32(Console.ReadLine());


                                    if (codigoProducto != 0)
                                    {
                                        listaProductos.Add(new producto { codigoProducto = codigoProducto });
                                        Console.WriteLine("Se agregó el producto con codigo: " + codigoProducto);
                                        listaProductos.Add(new producto { precio = precio });
                                        Console.WriteLine("Se agregó el producto con precio: " + precio);
                                    }
                                    else
                                    {
                                        terminarC = true;
                                    }
                                    Console.WriteLine("Mostrando la lista de codigos y precios (series) ");
                                    foreach (producto producto in listaProductos)
                                    {
                                        Console.WriteLine("Codigo existente: " + codigoProducto + ".  Precio correspondiente: " + precio);
                                    }
                                }

                                if (terminarC == true)
                                {
                                    Console.WriteLine("Seleccione que otra operacion desea realizar");
                                    operacion = Console.ReadLine();
                                }
                                break;
                            }
                    }
                }
                else
                {
                    Console.WriteLine("Ingrese un comando valido");
                    operacion = Console.ReadLine();
                }

        }
    }
}
