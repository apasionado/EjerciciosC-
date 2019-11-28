using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia0
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3.	Lea las teclas presionadas y finalice al presionar la tecla “X”.*/
            
            var ingreso = Console.ReadKey();
            Console.Out.WriteLine("Usted ingreso al sistema: " + ingreso.Key.ToString());
            Console.ReadKey();
        }
    }
}
