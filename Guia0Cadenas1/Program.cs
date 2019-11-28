using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia0Cadenas1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Ingrese nombre");
			var nombre = Console.In.ReadLine();
			Console.WriteLine("Hola " + nombre);
			Console.ReadKey();
		}
	}
}
