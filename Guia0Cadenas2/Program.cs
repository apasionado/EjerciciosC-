using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia0Cadenas2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Ingrese una frase que tenga \"Fin\" ");
			var frase = Console.In.ReadLine();
			if (frase.Contains("fin"))
			{
				Console.WriteLine("Tiene \"Fin\" ");
			}
			else
			{
				Console.WriteLine("No contiene \"Fin\" ");
			}
			Console.ReadKey();
		}
	}
}
