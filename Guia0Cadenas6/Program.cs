using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia0Cadenas6
{
	class Program
	{
		static void Main(string[] args)
		{
			String frase1 = Console.ReadLine();
			String frase2 = Console.ReadLine();

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
