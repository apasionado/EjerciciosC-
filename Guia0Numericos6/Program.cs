using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Guia0Numericos6
{
	class Program
	{
		static void Main(string[] args)
		{
			double num1 = 0;
			double num2 = 0;
			var res1 = "";
			var res2 = "";
			bool sonNumeros = false;
			while (sonNumeros != true)
			{
				Console.WriteLine("Ingrese 2 numeros ");
				res1 = Console.ReadLine();
				res2 = Console.ReadLine();

				Regex numeros = new Regex(@"^[-]?\d+[,.]?\d{0,}$");
				if (numeros.IsMatch(res1))
				{
					num1 = Convert.ToDouble(res1);
					num2 = Convert.ToDouble(res2);
					sonNumeros = true;
				}
				else
				{
					Console.WriteLine("No se matchearon numeros");
				}
				var mayor = Math.Max(num1, num2);
				Console.WriteLine("El mayor es: " + mayor);
				Console.ReadKey();
			}

		}
	}
}
