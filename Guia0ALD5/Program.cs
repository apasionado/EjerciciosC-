using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia0ALD5
{
	class Program
	{
		static void Main(string[] args)
		{
			//5Solicite el ingreso de una serie de números hasta que el usuario ingrese -1. 
			//Luego presentar: el máximo, el mínimo, el promedio, la suma. Realizar todos los cálculos una vez finalizado el ingreso.

			Console.WriteLine("Ingrese una serie de numeros, -1 para cancelar");
			int num = 0;
			List<int> lista = new List<int>();
			while (num != -1)
			{
				num = Convert.ToInt32(Console.ReadLine());
				lista.Add(num);
			}

			//el promedio es la suma de todos los numeros dividido la cantidad de numeros
			int sumaDeLaLista = 0;
			double promedio = 0;
			foreach (int numero in lista)
			{
				sumaDeLaLista = sumaDeLaLista + numero;
			}
			promedio = sumaDeLaLista / lista.Count;

			Console.WriteLine("El maximo es: " + lista.Max() + "\nEl minimo es: " + lista.Min() + "\nEl promedio es: " + promedio + "\nLa suma es: " + sumaDeLaLista);
			Console.ReadKey();
		}
	}
}
