using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Guia0ALD3
{
	class Program
	{
		static void Main(string[] args)
		{
			//3Solicite el ingreso de una serie de fechas al usuario y las presente ordenadas en forma ascendente.
			Console.WriteLine("Ingrese una serie de fechas");
			List<DateTime> listaDeFechas = new List<DateTime>();
			while (listaDeFechas.Count < 3)
			{
				String fechaIngresada = Console.ReadLine();
				//En el patron tiene que haber un 0 si o si por que parseExact está esperando un 0 0d/0m/yyyy o tambien 22/11/1999
				Regex patron = new Regex(@"^(0[1-9]|[12]\d|3[01])[\/](0[1-9]|1[0-2])[\/](19|20)\d{2}$");
				if (patron.IsMatch(fechaIngresada))
				{
					DateTime fechaUno = DateTime.ParseExact(fechaIngresada, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
					Console.WriteLine("Fecha ingresada exitosamente");
					listaDeFechas.Add(fechaUno);

				}
				else
				{
					Console.WriteLine("Ingrese una fecha valida");
				}
			}
			//Presentar fechas ordenadas en forma ascendete
			var list = listaDeFechas.OrderBy(x => x.Date).ToList();
			foreach (DateTime fecha in list)
			{
				Console.WriteLine(fecha);
			}
			Console.ReadKey();
		}
	}
}
