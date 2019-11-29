using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Guia0Numericos4
{
	class Program
	{
		static void Main(string[] args)
		{
			//18.	Solicite el ingreso de un número al usuario y lo presente redondeado a dos decimales.
			double num1 = 0;
			var res1 = "";
			bool sonNumeros = false;
			while (sonNumeros != true)
			{
				Console.WriteLine("Ingrese 1 numero ");
				res1 = Console.ReadLine();

				Regex numeros = new Regex(@"^\d+[,.]?\d+$");
				if (numeros.IsMatch(res1))
				{
					num1 = Convert.ToDouble(res1);
					sonNumeros = true;
				}
				else
				{
					Console.WriteLine("No se matchearon numeros");
				}
			}
			num1 = Math.Round(num1, 2);
			Console.WriteLine(num1);
			Console.ReadKey();
		}
	}
}
