using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia0Cadenas4
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Ingrese algo");
			var algo = Console.ReadLine();
			algo = algo.ToLower();
			Console.Write("Ahora está en minusculas: " + algo);
			Console.ReadKey();
		}
	}
}
