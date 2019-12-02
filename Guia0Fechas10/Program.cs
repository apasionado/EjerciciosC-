using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Guia0Fechas10
{
	class Program
	{
		static void Main(string[] args)
		{
			//Solicite el ingreso de una fecha al usuario y muestre sólo la hora.
			bool exito = false;
			while (exito != true)
			{
				Console.WriteLine("Ingrese una fecha");
				String fechaIngresada = Console.ReadLine();
				Regex patron = new Regex(@"(?m)/(0?[1-9]|[12][0-9]|3[01])[\/\-](0?[1-9]|1[012])[\/\-]\d{4}( \d{1,2}[:-]\d{2}([:-]\d{2,3})*)?");
				if (patron.IsMatch(fechaIngresada))
				{
					DateTime fecha = DateTime.ParseExact(fechaIngresada, "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
					exito = true;
					Console.WriteLine("La hora de la fecha ingresada es: ");
					var horaDeLaFecha = fecha.TimeOfDay.ToString();
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
