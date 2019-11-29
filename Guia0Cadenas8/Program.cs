using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia0Cadenas8
{
	class Program
	{
		static void Main(string[] args)
		{
			String frase1 = Console.ReadLine();
			String frase2 = Console.ReadLine();

			frase1 = frase1.ToLower();
			frase2 = frase2.ToLower();
			if (frase1 == frase2)
			{
				Console.WriteLine("Es igual");
			}
			else
			{
				Console.WriteLine("No es igual");
			}
			Console.ReadKey();
		}
	}
}
