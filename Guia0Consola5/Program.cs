using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia0Consola3
{
	class Program
	{
		static void Main(string[] args)
		{
			ConsoleKeyInfo tecla;
			Console.TreatControlCAsInput = true;
			Console.WriteLine("Ingrese F para cortar");
			do
			{
				tecla = Console.ReadKey();
				Console.Write(" fue la tecla que apretaste ");
				Console.Out.WriteLine("");
			} while (tecla.Key != ConsoleKey.F);
			Console.ReadKey();
		}
	}
}
