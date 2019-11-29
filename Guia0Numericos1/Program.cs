using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Guia0Numericos1
{
	class Program
	{
		static void Main(string[] args)
		{
			//15.	Solicite un ingreso al usuario y determine si puede ser interpretado como un valor numérico.
			var ingreso = Console.ReadLine();
			Regex numeros = new Regex(@"^\d+$");
			if (numeros.IsMatch(ingreso))
			{
				Console.Write("Determino que se interpreta el valor ingresado como un valor numerico");
			}
			else
			{
				Console.Write("No puede ser interpretado como un valor numerico");
			}
			Console.ReadKey();
		}
	}
}
