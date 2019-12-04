using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Guia0Archivos4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4Implemente un programa con los siguientes comandos, utilizando un diccionario para 
             * mantener los datos en memoria:
i.	“Alta [legajo] [nombre]”: da de alta el legajo / nombre en el diccionario.
j.	“Baja [legajo]”: da de baja el  legajo del diccionario.
k.	“Grabar [ruta de archivo]”: graba el diccionario en el archivo indicado.
l.	“Leer [ruta de archivo]”: Lee el diccionario a partir del archivo indicado.
*/
            SelectComands();
        }
        static string SelectComands()
        {

            bool terminar = false;
            string comando = "";

            Dictionary<int, String> legajos = new Dictionary<int, String>();

            do
            {
                Console.WriteLine("Ingrese un comando, \" fin \" para terminar" +
                    "\n alta -> da de alta un legajo" +
                    "\n baja -> da de baja un legajo" +
                    "\n grabar -> graba en un archivo los datos ingresados" +
                    "\n leer -> lee en un archivo los datos existentes");
                comando = Console.ReadLine();

                switch (comando)
                {
                    case "alta":

                        //pedir numero de legajo, y nombre, guardarlo en diccionario (legajos)
                        Console.WriteLine("Ingrese el numero de legajo a agregar");
                        int numLegajo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese nombre de legajo a agregar");
                        string nombreLegajo = Console.ReadLine();

                        if (legajos.ContainsKey(numLegajo))
                        {
                            Console.WriteLine("Este legajo ya existe!");
                        }
                        else
                        {
                            legajos.Add(numLegajo, nombreLegajo);

                            Console.WriteLine("Se a agregado a " + nombreLegajo + " con el legajo n " + numLegajo);
                            Console.WriteLine("No olvide guardar los legajos luego de agregarlos!");

                        }
                        break;

                    case "baja":
                        //pedir numero de legajo
                        Console.WriteLine("Ingrese el numero de legajo a eliminar");
                        numLegajo = Convert.ToInt32(Console.ReadLine());

                        if (legajos.ContainsKey(numLegajo))
                        {
                            legajos.Remove(numLegajo);
                            Console.WriteLine("Se a quitado el legajo n " + numLegajo + " exitosamente");
                        }

                        break;

                    case "grabar":
                        Console.WriteLine("Ingrese la ruta donde va a grabar el archivo");
                        string ruta = Console.ReadLine();

                        if (!File.Exists(ruta))
                        {
                            using (StreamWriter sw = File.CreateText(ruta))
                            {
                                foreach (KeyValuePair<int, string> fila in legajos)
                                {
                                    sw.WriteLine(fila);
                                }
                            }
                        }
                        else
                        {
                            {
                                using (StreamWriter sw = File.AppendText(ruta))
                                {
                                    foreach (KeyValuePair<int, string> fila in legajos)
                                    {
                                        sw.WriteLine(fila);
                                    }
                                }
                            }
                        }



                        break;

                    case "leer":

                        Console.WriteLine("Ingrese la ruta de donde va a leer los ingresos");
                        ruta = Console.ReadLine();
                        if (!File.Exists(ruta))
                        {
                            Console.WriteLine("El archivo que intenta leer no existe.");
                        }
                        else
                        {
                            Console.WriteLine("Mostrando cadenas existentes en la lista \n-----------------------");
                            using (StreamReader sr = File.OpenText(ruta))
                            {
                                string s;
                                while ((s = sr.ReadLine()) != null)
                                {
                                    Console.WriteLine(s);
                                }
                            }
                        }

                        break;

                    case "fin":
                        terminar = true;
                        break;

                    default:

                        Console.WriteLine("El comando ingresado es invalido");
                        comando = Console.ReadLine();
                        break;
                }
            } while (!terminar);

            return comando;
        }

    }
}
