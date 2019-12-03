using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia0Ingreso4
{
	class Program
	{
		static void Main(string[] args)
		{
			//4Solicitar el ingreso de una serie de números al usuario, donde cada número de la serie debe ser mayor al anterior.

			Console.WriteLine("Ingrese una serie de numeros");
			ArrayList serie = new ArrayList();
			while (serie.Count <= 4)
			{
				var ingreso = Console.ReadLine();
				int num = Convert.ToInt32(ingreso);
				for (int i = 0; i < serie.Count; i++)
				{
					if (serie.Count == 0)
					{
						serie.Add(num);
					}
					else
					{
						int num2 = Convert.ToInt32(serie[i]);
						while (num <= num2)
						{
							Console.WriteLine("El número ingresado es menor al último ingresado en la lista, por favor, vuelva a ingresar otro numero");
							num = Convert.ToInt32(Console.ReadLine());
						}
					}
				}

				serie.Add(ingreso.ToString());
			}

			Console.ReadKey();
		}
	}
}
