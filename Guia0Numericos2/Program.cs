using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Guia0Numericos2
{
	class Program
	{
		static void Main(string[] args)
		{

			/*16.	Solicite un ingreso al usuario y determine si puede ser interpretado como un número entero.
			(De aquí en más todos los ingresos del usuario deben ser verificados, 
			finalizando el programa con un mensaje de error en caso de ser inválidos)
				*/
			var ingreso = Console.ReadLine();
			Regex numeros = new Regex(@"^\d+$");
			if (numeros.IsMatch(ingreso))
			{
				Console.Write("Determino que se interpreta el valor ingresado como un numero entero");
			}
			else
			{
				Console.Write("No puede ser interpretado como un numero entero");
			}
			Console.ReadKey();
		}
	}
}
