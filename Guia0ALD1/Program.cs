using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia0ALD1
{
	class Program
	{
		static void Main(string[] args)
		{
			//1Solicite el ingreso de una serie de números al usuario y los presente en orden inverso.

			Console.WriteLine("Ingrese una serie de numeros");
			ArrayList serie = new ArrayList();

			while (serie.Count < 5)
			{
				var num = Convert.ToInt32(Console.ReadLine());
				serie.Add(num);
			}
			serie.Reverse();
			Console.WriteLine("Los numeros ingresados son: ");
			foreach (int x in serie)
			{
				Console.WriteLine(x);
			}

			Console.ReadKey();
		}
	}
}
