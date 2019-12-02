using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia0Fecha8
{
	class Program
	{
		static void Main(string[] args)
		{
			//Solicite el ingreso de un número al usuario y determine si corresponde a un año bisiesto.
			Console.WriteLine("Ingrese un número para comprobar si corresponde a un anio bisiesto");
			var ingreso = Console.ReadLine();
			var num = Convert.ToInt32(ingreso);
			if (num % 4 == 0)
			{
				Console.WriteLine("El numero ingresado es un año bisiesto");
			}
			else
			{
				Console.WriteLine("El numero ingresado no es un año bisiesto");
			}
			Console.ReadKey();

		}
	}
}
