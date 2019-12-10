using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Guia0Fechas4
{
    class Program
    {
        static void Main(string[] args)
        {
            //24.	Solicite el ingreso de una fecha al usuario utilizando, estrictamente, el formato dd/MM/yyyy


            bool exito = false;
            while (exito != true)
            {
                Console.WriteLine("Ingrese una fecha");
                String fechaIngresada = Console.ReadLine();
                Regex patron = new Regex(@"^(0[1-9]|[12]\d|3[01])[\/](0[1-9]|1[0-2])[\/](19|20)\d{2}$");
                if (patron.IsMatch(fechaIngresada))
                {
                    DateTime fecha = DateTime.ParseExact(fechaIngresada, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                    exito = true;
                    Console.WriteLine("El mes ingresado es: " + fechaIngresada);
                }
                else
                {
                    Console.WriteLine("Ingrese una fecha valida");
                }
                Console.ReadKey();
            }
        }
    }
}
