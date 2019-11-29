using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Guia0Numericos3
{
	class Program
	{
		static void Main(string[] args)
		{

			/*17.	Solicite el ingreso de dos números al usuario y
			 * presente la suma, la resta, la multiplicación, la división, el resto, el primero elevado a la potencia del segundo. */

			double num1 = 2.0;
			double num2 = 2.0;
			var res1 = "";
			var res2 = "";
			bool sonNumeros = false;
			while (sonNumeros != true)
			{
				Console.WriteLine("Ingrese 2 numeros ");
				res1 = Console.ReadLine();
				res2 = Console.ReadLine();

				Regex numeros = new Regex(@"^\d+$");
				if (numeros.IsMatch(res1) && numeros.IsMatch(res2))
				{
					num1 = Convert.ToDouble(res1);
					num2 = Convert.ToDouble(res2);
					sonNumeros = true;

					Console.WriteLine(res1, res2, "res");
					Console.WriteLine(num1.ToString(), num2.ToString(), "Num");
				}
				else
				{
					Console.WriteLine("No se matchearon numeros");
				}
			}


			Operaciones(num1, num2);

		}

		static bool Operaciones(double num1, double num2)
		{
			var suma = num1 + num2;
			var resta = num1 - num2;
			var multiplicar = num1 * num2;
			var dividir = num1 / num2;
			var resto = num1 % num2;
			int res1 = Convert.ToInt32(num1);
			int res2 = Convert.ToInt32(num2);
			int potencia = res1 ^ res2;
			Console.WriteLine("Suma: ", suma);
			Console.WriteLine("Resta: ", resta);
			Console.WriteLine("Multiplicar: ", multiplicar);
			Console.WriteLine("Dividir: ", dividir);
			Console.WriteLine("Resto: ", resto);
			Console.WriteLine("Potencia: ", potencia);
			Console.ReadKey();
			return true;
		}
	}
}
