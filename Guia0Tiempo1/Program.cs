using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Guia0Tiempo1
{
	class Program
	{
		static void Main(string[] args)
		{
			//1Solicite un ingreso al usuario y determine si puede interpretarse como un intervalo de tiempo.

			TimeSpan time;
			String format;
			CultureInfo culture;
			format = "g";
			culture = CultureInfo.CurrentCulture;

			Console.WriteLine("Ingrese cualquier cosa");
			var obtenerTiempo = Console.ReadLine();
			Regex patron = new Regex(@"([01]?[0-9]|2[0-3]):[0-5][0-9](:[0-5][0-9])?");

			if (patron.IsMatch(obtenerTiempo))
			{

				time = TimeSpan.ParseExact(obtenerTiempo, format, culture);

				if (time.Equals(TimeSpan.Zero))
				{
					Console.WriteLine("Lo ingresado no puede interpretarse como un intervalo de tiempo");

				}
				else
				{
					Console.WriteLine("Lo ingresado pudo interpretarse como un intervalo de tiempo: " + time);
				}

			}
			else
			{
				Console.WriteLine("El valor ingresado no es un valor de tiempo posible de evaluar");
			}



			Console.ReadKey();


		}
	}
}
