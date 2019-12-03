using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia0ALD4
{
	class Program
	{
		static void Main(string[] args)
		{
			//4Solicite el ingreso de una palabra al usuario y la presente escrita al revés.

			Console.WriteLine("Ingrese una palabra");
			String palabra = Console.ReadLine();

			var palabraInvertida = Reverse(palabra);
			Console.WriteLine(palabraInvertida);
			Console.ReadKey();
		}
		public static string Reverse(string s)
		{
			char[] charArray = s.ToCharArray();
			Array.Reverse(charArray);
			return new string(charArray);
		}
	}
}
