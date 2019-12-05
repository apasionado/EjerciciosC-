using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Guia0Integracion2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 54.	Realizar un programa que permita 
             * el ingreso y ejecución de los siguientes comandos 
             * (diseñe la interacción con el usuario según su criterio.
             * El sistema debe realizar las validaciones necesarias para que no se produzcan errores 
             * en tiempo de ejecución debido a un ingreso del usuario):
                a.	Dar de alta un alumno (Número de registro y nombre completo)
                b.	Dar de alta un curso (se ingresa el código del curso)
                c.	Asignar un alumno a un curso.
                d.	Desasignar un alumno de un curso.
                e.	Ver la lista de alumnos asignados a un curso.
                f.	Ver los cursos a los que está asignado un alumno.
                g.	Ver la cantidad de alumnos en cada curso.
                h.	Ver la cantidad de cursos de cada alumno.
                */

            Dictionary<string, string> listaDeAlumnos = new Dictionary<string, string>();
            Dictionary<string, List<string>> cursos = new Dictionary<string, List<string>>();

            Console.Clear();
            Console.WriteLine("Operaciones disponibles");
            Console.WriteLine("a.Dar de alta un alumno (Número de registro y nombre completo)" +
                "\nb.Dar de alta un curso(se ingresa el código del curso)" +
                "\nc.Asignar un alumno a un curso." +
                "\nd.Desasignar un alumno de un curso." +
                "\ne.Ver la lista de alumnos asignados a un curso." +
                "\nf.Ver los cursos a los que está asignado un alumno." +
                "\ng.Ver la cantidad de alumnos en cada curso." +
                "\nh.Ver la cantidad de cursos de cada alumno.)" +
                "\ni.Terminar");

            bool terminar = false;

            do
            {
                Console.WriteLine("Que operación desea realizar?");
                string comando = Console.ReadLine();



                switch (comando)
                {
                    case "a":
                        darAlumnoDeAlta(listaDeAlumnos);
                        break;
                    case "b":

                        darCursoDeAlta(cursos);
                        break;
                    case "c":

                        asignarAlumnoEnCurso(cursos);
                        break;

                    case "d":

                        desasignarAlumnoDeCurso(cursos);


                        break;
                    case "e":
                        mostrarListaDeAlumnosAsignados(cursos);

                        break;
                    case "f":
                        cursosDeAlumnoAsignado(cursos);

                        break;
                    case "g":
                        alumnosEnUnCurso(cursos);

                        break;
                    case "h":
                        cursosDeCadaAlumno(cursos, listaDeAlumnos);
                        break;
                    case "i":

                        terminar = true;
                        Console.WriteLine("chau chau");
                        Console.ReadKey();

                        break;
                    case "op":
                        Console.WriteLine("a.Dar de alta un alumno (Número de registro y nombre completo)" +
    "\nb.Dar de alta un curso(se ingresa el código del curso)" +
    "\nc.Asignar un alumno a un curso." +
    "\nd.Desasignar un alumno de un curso." +
    "\ne.Ver la lista de alumnos asignados a un curso." +
    "\nf.Ver los cursos a los que está asignado un alumno." +
    "\ng.Ver la cantidad de alumnos en cada curso." +
    "\nh.Ver la cantidad de cursos de cada alumno.)" +
    "\ni.Terminar");
                        break;
                    default:
                        Console.WriteLine("Comando invalido");
                        break;

                }
            } while (!terminar);

        }
        static string verificarNumero(string numero)
        {
            Regex soloNumeros = new Regex(@"^\d+$");
            while (!soloNumeros.IsMatch(numero))
            {
                Console.WriteLine("Ingrese solo numeros");
                numero = Console.ReadLine();

            }
            return numero;
        }
        static void darAlumnoDeAlta(Dictionary<string, string> listaDeAlumnos)
        {
            Console.WriteLine("Dar de alta un alumno");
            Console.WriteLine("Ingrese numero de registro del alumno qe quiere dar de alta");
            string registro = Console.ReadLine();
            verificarNumero(registro);

            Console.WriteLine("Ingrese el nombre del alumno");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido del alumno");
            string apellido = Console.ReadLine();
            string nombreCompleto = nombre + " " + apellido;

            listaDeAlumnos.Add(registro, nombreCompleto);
            Console.WriteLine("Alumno dado de alta con exito");
            Console.WriteLine("Hay " + listaDeAlumnos.Count + " alumnos registrados hasta ahora");
        }
        static void darCursoDeAlta(Dictionary<string, List<string>> cursos)
        {
            Console.WriteLine("Dar de alta un curso");
            Console.WriteLine("Ingrese el numero del curso que quiere dar de alta");
            string numeroCurso = Console.ReadLine();
            verificarNumero(numeroCurso);
            //los cursos al ser creados aun no contienen alumnos, con null da nullpointer exception
            cursos.Add(numeroCurso, null);
        }

        static void asignarAlumnoEnCurso(Dictionary<string, List<string>> cursos)
        {
            Console.WriteLine("Ingrese el registro del alumno que asignará a un curso");
            string registroDeAlumnoParaAsignar = Console.ReadLine();
            verificarNumero(registroDeAlumnoParaAsignar);
            Console.WriteLine("A que curso desea asignarlo? 0 para asignarlo a cualquier disponible");
            string cursoParaAsignar = Console.ReadLine();
            verificarNumero(cursoParaAsignar);
            while (!cursos.ContainsKey(cursoParaAsignar))
            {
                Console.WriteLine("El curso que intentas asignar no existe, elija otro");
                Console.WriteLine("Cursos disponibles: \n" + cursos.Keys);
                verificarNumero(cursoParaAsignar);
            }

            Console.WriteLine("Asignando el alumno a un curso... ");
            bool asignado = false;
            foreach (var curso in cursos)
            {
                if (curso.Key.Equals(cursoParaAsignar))
                {
                    //pincha aca
                    curso.Value.Add(registroDeAlumnoParaAsignar);
                    asignado = true;
                }
            }
            if (!asignado)
            {
                Console.WriteLine("No se pudo registrar el alumno");
            }
        }
        static void desasignarAlumnoDeCurso(Dictionary<string, List<string>> cursos)
        {
            Console.WriteLine("Ingrese el registro del alumno que desea desasignar de un curso");
            string registroDeAlumnoParaDesasignar = Console.ReadLine();
            verificarNumero(registroDeAlumnoParaDesasignar);
            Console.WriteLine("Ingrese el curso del que lo desea desasignar");
            string cursoParaDesasignar = Console.ReadLine();
            verificarNumero(cursoParaDesasignar);
            if (!(cursos.ContainsKey(cursoParaDesasignar)))
            {
                Console.WriteLine("No se encontró el curso que desea desasignar, por favor, ingrese un curso existente");
                Console.WriteLine("Cursos existentes\n" + cursos.Keys);
                verificarNumero(cursoParaDesasignar);

            }
            Console.WriteLine("Desasignando el alumno del curso... ");
            bool removido = false;

            foreach (var curso in cursos)
            {
                if (curso.Key.Equals(cursoParaDesasignar))
                {
                    curso.Value.Remove(registroDeAlumnoParaDesasignar);
                    removido = true;
                }
            }
            if (!removido)
            {
                Console.WriteLine("No se pudo remover el alumno");
            }
        }
        static void mostrarListaDeAlumnosAsignados(Dictionary<string, List<string>> cursos)
        {
            Console.WriteLine("Ver la lista de alumnos asignados a un curso");
            bool encontrados = false;
            foreach (var curso in cursos)
            {
                if (!curso.Value.Equals(""))
                {
                    Console.WriteLine("El/los alumno/s: " + curso.Value + " está/n en el curso: " + curso.Key);
                    encontrados = true;
                }
            }
            if (!encontrados)
            {
                Console.WriteLine("No hay alumnos asignados a un curso");
            }
        }
        static void cursosDeAlumnoAsignado(Dictionary<string, List<string>> cursos)
        {
            Console.WriteLine("Ver los cursos a los que está asignado un alumno");
            Console.WriteLine("Ingrese el registro del alumno que desea inspeccionar");
            var registroDeAlumnoParaBuscar = Console.ReadLine();
            verificarNumero(registroDeAlumnoParaBuscar);

            bool encontrado = false;
            Console.WriteLine("Se arrojarán los cursos a los que pertenece el alumno");
            foreach (var curso in cursos)
            {
                if (curso.Value.Contains(registroDeAlumnoParaBuscar))
                {
                    Console.WriteLine(curso.Key);
                    encontrado = true;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine("No se encontraron cursos a los que este alumno pertenezca");
            }
        }
        static void alumnosEnUnCurso(Dictionary<string, List<string>> cursos)
        {
            Console.WriteLine("Ver la cantidad de alumnos en un curso");

            var registroDeCursoParaBuscar = Console.ReadLine();
            verificarNumero(registroDeCursoParaBuscar);



            Console.WriteLine("Se mostraran los alumnos que pertenezcan al curso seleccionado");
            foreach (var curso in cursos)
            {
                if (curso.Key.Equals(registroDeCursoParaBuscar))
                {
                    Console.WriteLine("En el curso " + curso.Key + " hay " + curso.Value);
                }
            }
        }
        static void cursosDeCadaAlumno(Dictionary<string, List<string>> cursos, Dictionary<string, string> listaDeAlumnos)
        {
            Console.WriteLine("Ver la cantidad de cursos de cada alumno");

            Console.WriteLine("A continuación se mostraran los cursos a los que pertenece cada alumno");
            foreach (var alumno in listaDeAlumnos)
            {
                Console.WriteLine("El alumno " + alumno.Value + " pertenece a los cursos: ");
                for (int i = 0; i < cursos.Count; i++)
                {
                    if (cursos.ElementAt(i).Value.Contains(alumno.Value))
                    {
                        Console.WriteLine(cursos.ElementAt(i).Key.ToString());
                    }
                }
            }
        }

    }
}
