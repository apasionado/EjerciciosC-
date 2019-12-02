using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Guia0Tiempos4
{
	class Program
	{
		static void Main(string[] args)
		{
			//4Presente la fecha actual cada 10 segundos durante un minuto.

			Console.WriteLine("Te voy a mostrar la fecha actual cada 10 segundos durante 1 minuto");

			var quiero = DateTime.Now.AddSeconds(60);
			var estimado = DateTime.Now.AddSeconds(0);

			Console.WriteLine(quiero + " Quiero");
			Console.WriteLine(estimado + " Estimado");

			while (DateTime.Now != quiero)
			{
				if (estimado.Second == DateTime.Now.Second)
				{
					estimado = DateTime.Now.AddSeconds(10);
					Console.WriteLine(estimado + " La nueva fecha esperada es esta ");
				}
			}


			Console.ReadKey();
		}
	}
}
