using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Guia0Validacion1
{
	class Program
	{
		static void Main(string[] args)
		{
			//1Solicitar el ingreso de un número al usuario, repitiendo la operación (presentando un mensaje de error) hasta que el ingreso sea válido.
			Console.WriteLine("Ingrese un número");
			String ingreso = Console.ReadLine();
			Regex patron = new Regex(@"\d+");
			while (!patron.IsMatch(ingreso))
			{
				Console.WriteLine("ERROR: El ingreso no fue exitoso, por favor ingrese un numero");
				ingreso = Console.ReadLine();
			}
			Console.ReadKey();
		}
	}
}
