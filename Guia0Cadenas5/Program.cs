using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Guia0Cadenas11
{
	class Program
	{
		static void Main(string[] args)
		{
			String algo;
			algo = Console.ReadLine();

			Regex pattern = new Regex("á");
			algo = pattern.Replace(algo, "a");
			pattern = new Regex("é");
			algo = pattern.Replace(algo, "e");
			pattern = new Regex("í");
			algo = pattern.Replace(algo, "i");
			pattern = new Regex("ó");
			algo = pattern.Replace(algo, "o");
			pattern = new Regex("ú");
			algo = pattern.Replace(algo, "u");

			Console.WriteLine(algo, "algo");
			Console.ReadKey();

			/*
			if (algo.Contains("á"))
			{
				Console.WriteLine(algo + " sin result");
				algo = algo.Replace("á", "a");
				Console.WriteLine(algo);
			}
			if (algo.Contains("é"))
			{
				Console.WriteLine(algo + " sin result");
				algo = algo.Replace("é", "e");
				Console.WriteLine(algo);
			}
			if (algo.Contains("í"))
			{
				Console.WriteLine(algo + " sin result");
				algo = algo.Replace("í", "i");
				Console.WriteLine(algo);

			}
			if (algo.Contains("ó"))
			{
				Console.WriteLine(algo + " sin result");
				algo = algo.Replace("ó", "o");
				Console.WriteLine(algo);
			}
			if (algo.Contains("ú"))
			{
				Console.WriteLine(algo + " sin result");
				algo = algo.Replace("ú", "u");
				Console.WriteLine(algo);
			}
			*/

		}
	}
}
