using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace Guia0ALD6
{
    class Program
    {
        /*6Realizar una aplicación que mantenga una lista de nombres. La aplicación debe interpretar los siguientes “comandos”, que el usuario ingresará hasta finalizar. 
 * Si el usuario ingresa…
a.	“alta [nombre]”, se insertará la cadena a la lista (ej.: “alta Pedro”).
b.	“baja [número entero]”, se eliminará la cadena en la posición indicada por el número ingresado. 
Debe presentar un mensaje de error si el número está fuera del rango de la lista.
c.	“baja [nombre]”, se eliminará la cadena de la lista. Debe presentar un mensaje de error si la cadena no existe.
d.	“mostrar”, mostrará las entradas de la lista, una por línea.
e.	“fin”, finalizará el programa.
f.	Cualquier otro ingreso indicará “comando inválido” y continuará.
*/
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un comando alta nombre, baja nombre, baja numero, mostrar, fin");
            List<String> lista = new List<String>();
            bool terminar = false;
            while (terminar != true)
            {
                String comando = Console.ReadLine();
                Regex comandoConNumero = new Regex(@"^baja\s?\d{0,3}$");
                Regex comandoConLetra = new Regex(@"^(alta|baja)\s?\w{0,14}$");
                Regex comandoSolo = new Regex(@"^mostrar|fin$");

                while (!(comandoConNumero.IsMatch(comando) || comandoConLetra.IsMatch(comando) || comandoSolo.IsMatch(comando)))
                {

                    Console.WriteLine("comando invalido");
                    comando = Console.ReadLine();
                }

                if (comandoConNumero.IsMatch(comando))
                {
                    comando = comando.Replace("baja ", "");
                    var num = Convert.ToInt32(comando);
                    Console.WriteLine("Posición seleccionada: " + num);
                    if (lista.ElementAt(num) != null)
                    {
                        lista.RemoveAt(num);
                        Console.WriteLine("Posición eliminada con exito");
                    }
                    else
                    {
                        Console.WriteLine("La posición que intentas eliminar está vacia!");
                    }

                }
                if (comandoConLetra.IsMatch(comando))
                {
                    if (comando.Contains("baja"))
                    {
                        comando = comando.Replace("baja ", "");

                        Console.WriteLine("Se dara de baja en la lista el nombre: " + comando + " despues de la posición " + lista.Count);
                        lista.Remove(comando);
                    }
                    else if (comando.Contains("alta"))
                    {
                        comando = comando.Replace("alta ", "");
                        Console.WriteLine("Se agregará a la lista el nombre: " + comando + " despues de la posición " + lista.Count);
                        lista.Add(comando);
                    }
                }

                switch (comando)
                {
                    case "mostrar":

                        Console.WriteLine("En la lista figuran los siguientes nombres: ");
                        foreach (string nombre in lista)
                        {
                            Console.WriteLine(nombre);
                        }

                        break;

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

