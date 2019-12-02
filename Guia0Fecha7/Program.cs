using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Guia0Fecha7
{
	class Program
	{
		static void Main(string[] args)
		{
			//Solicite el ingreso de una fecha al usuario y presente las fechas 30, 60, 90 y 180 días posteriores a la ingresada.
			bool exito = false;
			while (exito != true)
			{
				Console.WriteLine("Ingrese una fecha");
				String fechaIngresada = Console.ReadLine();
				Regex patron = new Regex(@"^(0?[1-9]|[12]\d|3[01])[\/](0?[1-9]|1[0-2])[\/](19|20)\d{2}$");
				if (patron.IsMatch(fechaIngresada))
				{
					DateTime fecha = DateTime.ParseExact(fechaIngresada, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
					exito = true;
					Console.WriteLine("Fecha 30 posterior: " + fecha.Date.AddDays(30));
					Console.WriteLine("Fecha 60 posterior: " + fecha.Date.AddDays(60));
					Console.WriteLine("Fecha 90 posterior: " + fecha.Date.AddDays(90));
					Console.WriteLine("Fecha 180 posterior: " + fecha.Date.AddDays(180));
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
