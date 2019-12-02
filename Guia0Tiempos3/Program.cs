using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Guia0Tiempos3
{
	class Program
	{
		static void Main(string[] args)
		{
			//3Solicite el ingreso de una fecha al usuario y determine cuántos días restan para el fin de año próximo más cercano.
			bool exito = false;
			while (exito != true)
			{
				Console.WriteLine("Ingrese una fecha");
				String fechaIngresada = Console.ReadLine();
				Regex patron = new Regex(@"^(0?[1-9]|[12]\d|3[01])[\/](0?[1-9]|1[0-2])[\/](19|20)\d{2}$");
				if (patron.IsMatch(fechaIngresada))
				{
					DateTime fecha = DateTime.ParseExact(fechaIngresada, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
					var anioSiguiente = fecha.Year + 1;
					String finDeAnio = "01/01/" + anioSiguiente;
					DateTime fechaFinDeAnio = DateTime.ParseExact(finDeAnio, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
					exito = true;

					var faltaParaFinDeAnio = (fecha - fechaFinDeAnio).TotalDays;
					//redondeo
					faltaParaFinDeAnio = Math.Abs(faltaParaFinDeAnio);
					Console.WriteLine("Falta para el fin de anio: " + faltaParaFinDeAnio);

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
