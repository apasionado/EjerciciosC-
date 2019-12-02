using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Guia0Tiempos2
{
	class Program
	{
		static void Main(string[] args)
		{
			//2Solicite el ingreso de dos fechas al usuario y determine el intervalo en días, meses y años.

			bool exito = false;
			while (exito != true)
			{
				Console.WriteLine("Ingrese una primera fecha");
				String fechaIngresada = Console.ReadLine();
				Regex patron = new Regex(@"^(0?[1-9]|[12]\d|3[01])[\/](0?[1-9]|1[0-2])[\/](19|20)\d{2}$");
				if (patron.IsMatch(fechaIngresada))
				{
					DateTime fechaUno = DateTime.ParseExact(fechaIngresada, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
					exito = true;
					bool exito1 = false;
					while (exito1 != true)
					{
						Console.WriteLine("Ingrese una segunda fecha");
						String segundaFecha = Console.ReadLine();
						if (patron.IsMatch(segundaFecha))
						{
							DateTime fechaDos = DateTime.ParseExact(segundaFecha, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
							exito1 = true;

							//Empezamos a trabajar los datos recibidos 

							var intervaloDias = (fechaUno - fechaDos).TotalDays;
							var intervaloMeses = (fechaUno - fechaDos).TotalDays / 12;
							var intervaloAnios = Math.Abs(fechaUno.Year - fechaDos.Year);

							Console.WriteLine("El intervalo entre ambas fechas en dias es de: " + Math.Abs(intervaloDias));
							Console.WriteLine("El intervalo entre ambas fechas en meses es de: " + Math.Abs(intervaloMeses));
							Console.WriteLine("El intervalo entre ambas fechas en años es de: " + Math.Abs(intervaloAnios));

						}
						else
						{
							Console.WriteLine("Ingrese una segunda fecha valida");
						}
					}



				}
				else
				{
					Console.WriteLine("Ingrese una primera fecha valida");
				}
				Console.ReadKey();
			}
		}
	}
}
