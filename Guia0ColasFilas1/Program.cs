using System;
using System.Collections;
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

            //NO ME SALE QUEUE NI STACKS

            Console.WriteLine("Ingrese un comando afiliado <nombre>, caja <numero>,  fin");
            List<String> lista = new List<String>();
            bool terminar = false;

            String comando;
            Regex comandoConNumero = new Regex(@"^caja\s?\d{0,3}$");
            Regex comandoSolo = new Regex(@"^\w+\b$");
            // Se puede pasar a Do While, el primer paso lo hace siempre y luego chequea la condicion
            Queue<string> afiliadosEnEspera = new Queue<string>();
            // Cajas que pueden ponerse en cola
            Dictionary<int, string> dicCajas = new Dictionary<int, string>();
            Queue<Caja> cajasDisponibles = new Queue<Caja>();
            // Cada caja individual, con su afiliado (o, un array de cajas y acceder con el indice o foreach)
            
            do
            {
                comando = Console.ReadLine();

                string cadenaEncontrada = comandoSolo.Match(comando).Value; 
                // Al ser un solo valor debería funcionar, sino hay que entrar a .groups
                //tambien hay un metodo de regex que te devuelve un array, ese también es más facil de manejar,
                //de última usamos ese (creo que es el que vos decis, groups)

                switch (cadenaEncontrada)
                {
                    case "caja":
                        // de las 3 cajas que hay, indica cual está libre, 
                        //si hay alguan libre le asigna el primer afiliado que ingresó
                        
                        Caja caja1 = new Caja(1,"") ;
                        Caja caja2 = new Caja(2, "");
                        Caja caja3 = new Caja(3, "");
                        cajasDisponibles.Enqueue(caja1);
                        cajasDisponibles.Enqueue(caja2);
                        cajasDisponibles.Enqueue(caja3);
                        foreach(Caja caja in cajasDisponibles)
                        {
                            if()
                        }


                        /*Luego de procesar cada comando el sistema mostrará:
        a.	La lista de afiliados en espera, según orden de atención.
        b.	El estado de cada caja (“libre” o el nombre del afiliado que está siendo atendido).*/

                        


                    case "afiliado":
                        // Agregar al queue "afiliadosEnEspera"
                        String nuevoAfiliado = cadenaEncontrada.Replace("afiliado ", "");
                        afiliadosEnEspera.Enqueue(nuevoAfiliado);
                        //El afiliado ya está en espera, por lo tanto no es más un nuevo afiliado
                        nuevoAfiliado = "";





                        /*Luego de procesar cada comando el sistema mostrará:
    a.	La lista de afiliados en espera, según orden de atención.
    b.	El estado de cada caja (“libre” o el nombre del afiliado que está siendo atendido).*/
                        foreach (Caja caja in cajasDisponibles)
                        {
                            
                        }

                        break;
                    case "fin":
                        Console.WriteLine("Fin del programa");
                        terminar = true;
                        break;
                    default:
                        Console.WriteLine("Comando inválido, intente nuevamente");
                        break;
                }
                // Mostrar estado de cajas / filas / pilas / stacks / comosea





            } while (!terminar);
            Console.ReadKey();
        }

    }
}
