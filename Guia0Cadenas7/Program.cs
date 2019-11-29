using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia0Cadenas7
{
	class Program
	{
		static void Main(string[] args)
		{
			String frase1 = Console.ReadLine();
			String frase2 = Console.ReadLine();

			if (frase1.Length == frase2.Length)
			{
				Console.WriteLine("Es igual de longitud");
			}
			else
			{
				Console.WriteLine("No es igual de longitud");
			}
			Console.ReadKey();
		}
	}
}
