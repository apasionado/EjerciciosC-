using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia0Archivos1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1Cree un archivo de texto que contenga la cadena “hola mundo”.
            .

            string path = @"C:\Users\Fernando\Desktop\test.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("hola mundo");
                }
            }

            Console.ReadKey();
        }
    }
}
