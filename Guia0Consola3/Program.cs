﻿using System;
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
			Console.WriteLine("Ingrese CTRL + F para cortar");
			do
			{

				tecla = Console.ReadKey();
				if ((tecla.Modifiers & ConsoleModifiers.Control) != 0) Console.Write(" CTL+");
				Console.Write(" fue la tecla que apretaste ");

				Console.Out.WriteLine("");
			} while (tecla.Key != ConsoleKey.F || tecla.Modifiers != ConsoleModifiers.Control);
			Console.Out.WriteLine("Salio bien");
			Console.ReadKey();
		}
	}
}
