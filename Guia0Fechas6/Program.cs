using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Guia0Fechas6
{
	class Program
	{
		static void Main(string[] args)
		{
			//5.	Solicite el ingreso de una 
			//fecha al usuario y le presente: el día, el año, el número y nombre del mes y el nombre y número del día de la semana.

			bool exito = false;
			while (exito != true)
			{
				Console.WriteLine("Ingrese una fecha");
				String fechaIngresada = Console.ReadLine();
				Regex patron = new Regex(@"^(0?[1-9]|[12]\d|3[01])[\/](0?[1-9]|1[0-2])[\/](19|20)\d{2}$");
				if (patron.IsMatch(fechaIngresada))
				{
					DateTime fechaYHora = DateTime.ParseExact(fechaIngresada, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
					exito = true;
					int dia = fechaYHora.Day;
					int año = fechaYHora.Year;
					int mes = fechaYHora.Month;
					String mesNombre = new DateTime(mes).ToString("MMMM", CultureInfo.CreateSpecificCulture("es"));
					String semanaNombre = obtenerNombreDeLaSemana(dia);
					String numeroDelDiaDeLaSemana = obtenerDiaCorrespondienteALaSemana(dia);
					Console.WriteLine("Dia: " + dia);
					Console.WriteLine("Año: " + año);
					Console.WriteLine("Mes: " + mes);
					Console.WriteLine("Nombre del mes: " + mesNombre);
					Console.WriteLine("Nombre del numero de semana: " + semanaNombre);
					Console.WriteLine("Numero del dia de la semana: " + numeroDelDiaDeLaSemana);
				}
				else
				{
					Console.WriteLine("Ingrese una fecha valida");
				}
				Console.ReadKey();
			}
		}
		static String obtenerNombreDeLaSemana(int dia)
		{
			String nombreSemana = "";

			if (dia > 0 && dia <= 7)
			{
				nombreSemana = "Primera";
			}
			if (dia > 7 && dia <= 14)
			{
				nombreSemana = "Segunda";
			}
			if (dia > 14 && dia <= 21)
			{
				nombreSemana = "Tercera";
			}
			if (dia > 21 && dia <= 31)
			{
				nombreSemana = "Cuarta";
			}


			return nombreSemana;
		}

		static String obtenerDiaCorrespondienteALaSemana(int dia)
		{

			/*
			int diaCorrespondiente = 0;
			int numeroSemana = 0;
			diaCorrespondiente = numeroSemana - dia 

			if (dia > 0 && dia <= 7)
			{
				numeroSemana = 1;
			}
			if (dia > 7 && dia <= 14)
			{
				numeroSemana = 2;
			}
			if (dia > 14 && dia <= 21)
			{
				numeroSemana = 3;
			}
			if (dia > 21 && dia <= 31)
			{
				numeroSemana = 4;
			}
			
			 NO LO PUDE SACAR
			 */


			return "No lo pude sacar";
		}
	}
}
