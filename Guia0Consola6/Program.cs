using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia0Ejercicio6
{
	class Program
	{
		static void Main(string[] args)
		{
			ConsoleKeyInfo tecla;
			Console.TreatControlCAsInput = true;
			Console.WriteLine("Ingrese SHIFT + CTRL + F para cortar");
			do
			{
				tecla = Console.ReadKey();
				if ((tecla.Modifiers & ConsoleModifiers.Control) != 0) Console.Write(" CTRL+");
				if ((tecla.Modifiers & ConsoleModifiers.Shift) != 0) Console.Write("SHIFT+");

				Console.Write(" fue la tecla que apretaste ");

				Console.Out.WriteLine("");
			} while (tecla.Key != ConsoleKey.F || tecla.Modifiers != (ConsoleModifiers.Control | ConsoleModifiers.Shift));
			Console.Out.WriteLine("Salio bien");
			Console.ReadKey();
		}
	}
}
