using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Guia0ColasFilas1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1
             * Se le ha solicitado codificar un simulador de atención al cliente para una obra social que opera con 3 cajas. El sistema se ha diseñado como una aplicación de consola que recibe del usuario los siguientes comandos:
d.	“afiliado: [nombre]” – (Ej.: “afiliado:Perez”) le indica al sistema que el afiliado [nombre] se ha presentado en mesa de entradas (asuma que cada afiliado tiene un nombre único). Si hay una caja libre pasará directamente, si no quedará en espera.
e.	“caja: [n]” – (Ej.:”caja:1”) le indica al sistema que la caja n (1, 2 o 3) está libre. Debe asignársele un cliente según el orden de presentación en mesa de entrada.
f.	“fin” – Finaliza la ejecución.
Cualquier otro ingreso se considerará un error del operador, indicándose con un mensaje. 
Luego de procesar cada comando el sistema mostrará:
a.	La lista de afiliados en espera, según orden de atención.
b.	El estado de cada caja (“libre” o el nombre del afiliado que está siendo atendido).
*/

            Console.WriteLine("Ingrese un comando afiliado <nombre>, caja <numero>,  fin");
            List<String> lista = new List<String>();
            bool terminar = false;
            while (terminar != true)
            {
                String comando = Console.ReadLine();
                Regex comandoConNumero = new Regex(@"^caja\s?\d{0,3}$");
                Regex comandoConLetra = new Regex(@"^afiliado\s?\w{0,14}$");
                Regex comandoSolo = new Regex(@"^fin$");

                while (!(comandoConNumero.IsMatch(comando) || comandoConLetra.IsMatch(comando) || comandoSolo.IsMatch(comando)))
                {

                    Console.WriteLine("comando invalido");
                    comando = Console.ReadLine();
                }

                if (comandoConNumero.IsMatch(comando))
                {
                    comando = comando.Replace("caja ", "");

                }
                if (comandoConLetra.IsMatch(comando))
                {
                    if (comando.Contains("alta"))
                    {
                        comando = comando.Replace("alta ", "");
                        Console.WriteLine("Se agregará a la lista el nombre: " + comando + " despues de la posición " + lista.Count);

                    }
                }

                switch (comando)
                {

                    case "fin":

                        Console.WriteLine("Fin del programa");
                        terminar = true;
                        break;
                }

            }
            Console.ReadKey();
        }

    }
}
}
