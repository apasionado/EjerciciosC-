using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia0Integracion4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*56.	Se le ha encomendado un sistema de cálculo de calorías.
             * Los nutricionistas lo utilizarán para validar que una dieta cumpla con los requisitos calóricos de un paciente, 
             * calculados de acuerdo a su peso. Se le requiere:
                a.	La posibilidad de mantener una lista de platos junto con las calorías asociadas.
                Ejemplo: bife con puré - 1300 calorías, arroz con pollo – 1000 calorías, etc...
                b.	La posibilidad de mantener una lista de dietas. Cada dieta tendrá un nombre 
                (“Vegana”, “Hipercalórica”, “Carne blanca”), y se compone de una lista de platos.
                c.	La posibilidad de ingresar el sexo y peso de un paciente y 
                obtener una lista de las dietas que se ajustan a su contextura.
                La cantidad de calorías mínima por día para una persona surge de multiplicar 
                su peso por 20 (si es mujer) o 22 (si es hombre).
                La cantidad máxima de calorías por día es un 50% por encima de la mínima.
                //si soy hombre y peso 75, el minimo de calorias por dia es 1650, el maximo es 2475
            */

            List<Platos> platos = new List<Platos>();
            Dictionary<string, List<Platos>> dieta = new Dictionary<string, List<Platos>>();

            bool terminar = false;
            do
            {

                Console.Clear();
                Console.WriteLine("Elija la operación que desea realizar");
                Console.WriteLine("1 -> Agregar un plato");
                Console.WriteLine("2 -> Agregar una dieta");
                Console.WriteLine("3 -> Ingresar un nuevo paciente");

                var opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el nombre del plato que desea agregar");
                        var nombrePlato = Console.ReadLine();
                        Console.WriteLine("Ingrese las calorias del plato");
                        var caloriasPlato = Convert.ToInt32(Console.ReadLine());
                        platos.Add(new Platos
                        {
                            comida = nombrePlato,
                            calorias = caloriasPlato
                        });
                        Console.WriteLine("Plato agregado exitosamente");
                        Console.WriteLine("Platos existentes:");
                        foreach (Platos plato in platos)
                        {
                            Console.WriteLine("Comida: " + plato.comida + " con calorias: " + plato.calorias);
                        }
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Ingrese una dieta");
                        var nombreDieta = Console.ReadLine();

                        List<Platos> platosAgregar = new List<Platos>();
                        string platoNombre;
                        do
                        {
                            Console.WriteLine("Seleccione uno de los siguientes platos que debería ir con la dieta." +
                                " \"ninguno\" para terminar");

                            Console.WriteLine("Platos existentes:");
                            foreach (Platos plato in platos)
                            {
                                Console.WriteLine("Comida: " + plato.comida + " con calorias: " + plato.calorias);
                            }

                            platoNombre = Console.ReadLine();

                            foreach (Platos plato in platos)
                            {
                                if (plato.comida.Equals("platoNombre"))
                                {
                                    platosAgregar.Add(plato);
                                }
                            }
                        } while (platoNombre != "ninguno");


                        dieta.Add(nombreDieta, platosAgregar);



                        Console.WriteLine("La dieta se creó exitosamente");
                        Console.WriteLine("Dietas existentes: ");


                        foreach (var d in dieta)
                        {
                            Console.WriteLine(d.Key);
                            foreach (var listaDePlatos in dieta.Values)
                            {
                                foreach (var plato in listaDePlatos)
                                {
                                    Console.WriteLine("Nombre: " + plato.comida);
                                }
                            }
                        }
                        Console.ReadKey();

                        break;
                    case "3":
                        Console.WriteLine("Ingresar un nuevo paciente");
                        Console.WriteLine("Ingrese sexo del paciente");
                        var sexo = Console.ReadLine();
                        Console.WriteLine("Ingrese peso del paciente");
                        var peso = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Paciente ingresado con exito");
                        Console.WriteLine("Lista de dietas que se ajustan a las propiedades del paciente");

                        List<Platos> platoParaBuscar = new List<Platos>();
                        int calculoDelPeso;
                        if (sexo.Equals("hombre"))
                        {
                            calculoDelPeso = 22;
                        }
                        else
                        {
                            calculoDelPeso = 20;
                        }
                        int caloriasMinimas = peso * calculoDelPeso; //esto son las calorias minimas
                        int caloriasMaximas = (caloriasMinimas * 50) / 100;

                        foreach (var listaDePlatos in dieta.Values)
                        {
                            Console.WriteLine("De la dieta: " + dieta.Keys.ToString());
                            foreach (var plato in listaDePlatos)
                            {

                                if (plato.calorias <= caloriasMaximas || plato.calorias >= caloriasMinimas)
                                {
                                    Console.WriteLine("Se considera el plato: " + plato.comida.ToString() + " con calorias: " + plato.calorias.ToString());
                                }
                            }
                        }
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Comando invalido");
                        break;
                }
            } while (terminar != true);



        }
    }
}
