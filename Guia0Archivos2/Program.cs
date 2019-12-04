using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia0Archivos2
{
    class Program
    {
        static void Main(string[] args)
        {

            //2Solicite el ingreso de la ruta de un archivo de texto y presente el contenido

            string path = @"C:\Users\Fernando\Desktop\test.txt";



            // Leer el archivo
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadKey();
        }
    }
}
