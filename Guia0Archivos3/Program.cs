using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia0Archivos3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3Solicite el ingreso de la ruta de un archivo de texto. 
             * Luego, permita el ingreso de una lista de cadenas (hasta que el usuario indique “fin”),
             * grabándolas en el archivo a medida que el usuario las ingresa. */

            string path = @"C:\Users\Fernando\Desktop\test.txt";

            string ingreso = "";

            while (!ingreso.Equals("fin"))
            {
                Console.WriteLine("Ingrese una cadena, \" Fin para terminar \" ");
                ingreso = Console.ReadLine();

                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(ingreso);
                    }
                }
                else
                {
                    if (!(ingreso.Equals("fin")))
                    {

                        using (StreamWriter sw = File.AppendText(path))
                        {
                            sw.WriteLine(ingreso);
                            sw.Close();
                        }
                    }
                }

                Console.WriteLine("Mostrando cadenas existentes en la lista \n-----------------------");
                using (StreamReader sr = File.OpenText(path))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
