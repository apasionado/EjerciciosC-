using System;
using System.Collections;
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
            /*7.	Realizar una aplicación que solicite el ingreso de una serie de números de registro y nombres de 
             * alumno, hasta que el usuario ingrese el registro “0”. 
             * Luego, solicitará el ingreso de un número de registro y presentará (de existir) el nombre asociado,
             * repitiendo hasta que el usuario ingrese “0” como número de registro. */

            //hacer con un diccionario

            Dictionary<int, string> registros = new Dictionary<int, string>();



            bool terminar = false;
            while (terminar != true)
            {
                var ingresoNumeroSerie = -1;
                while (ingresoNumeroSerie != 0)
                {
                    Console.WriteLine("Ingrese un numero de serie: ");
                    ingresoNumeroSerie = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese un nombre del alumno:");
                    var ingresoNombre = Console.ReadLine();
                    if (ingresoNumeroSerie == 0)
                    {
                        terminar = true;
                    }
                    registros.Add(ingresoNumeroSerie, ingresoNombre);
                }


                Console.WriteLine("Ingrese un numero para mostrarle el nombre en la lista");
                var ingreso = Convert.ToInt32(Console.ReadLine());


                while (ingreso != 0)
                {
                    if (registros.ContainsKey(ingreso))
                    {
                        Console.WriteLine("Mostrando elemento seleccionado");
                        Console.WriteLine(registros[ingreso].ToString());
                        Console.WriteLine("Desea ver otro elemento?");
                        ingreso = Convert.ToInt32(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("No existe el elemento que buscas en la lista");
                        Console.WriteLine("Vuelva a ingresar un numero para intentar denuevo");
                        ingreso = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.ReadKey();
            }
        }
    }
}
