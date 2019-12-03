using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia0Ingresos3
{
	class Program
	{
		static void Main(string[] args)
		{
			//3Solicitar el ingreso de una cadena al usuario,
			//repitiendo la operación (presentando un mensaje de error) hasta que el ingreso sea válido. Debe tener entre 10 y 20 caracteres.

			Console.WriteLine("Ingrese una cadena");
			String ingreso = Console.ReadLine();

			while (!(ingreso.Length <= 20 && ingreso.Length >= 10))
			{
				Console.WriteLine("ERROR: Ingrese una cadena");
				ingreso = Console.ReadLine();
			}
			Console.ReadKey();
		}
	}
}
