using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia0ALD
{
	class Program
	{
		static void Main(string[] args)
		{
			//2Solicite el ingreso de una frase al usuario y presente cada palabra en una línea por separado.
			String frase;
			Console.WriteLine("Ingrese una frase");
			frase = Console.ReadLine();

			frase = frase.Replace(" ", "\n");
			Console.WriteLine(frase);


			Console.ReadKey();



		}
	}
}
