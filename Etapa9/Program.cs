using System;
using System.Collections.Generic;
using System.Linq;
using CoreEscuela.Entidades;
using CoreEscuela.util;
using CoreEscuela.App;
using static System.Console;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.ProcessExit += AccionDelEvento;
            //AppDomain.CurrentDomain.ProcessExit += (o, s)=>Printer.Beep(2000,1000,1);

            PonerColorDeFondo();
            //se llama a la clase de EscuelaEngine que es la que inicializa las cargas de cursos, asignaturas y evaluaciones
            var engine = new EscuelaEngine();
            engine.Inicializar();

            //se llama a la clase printer que es la cual imprime en consola el titulo de la escuela 
            //con sus diferentes atributos 

            Printer.EscribirTitulo("Bienvenidos a la escuela".ToUpper());

            var Reporteador = new Reporteador(engine.GetDiccionarioObjeto());
            var evalLlist = Reporteador.GetListaEvaluaciones();
            var listaAsg = Reporteador.GetListaAsignaturas();
            var listaEvalXAsig = Reporteador.GetDicEvaluaXAsig();
            var listaPromXAsig = Reporteador.GetPromeAlumnPorAsignatura();
            var listaMejorPromXAsig = Reporteador.GetTopAluPorAsig(5);

            Printer.EscribirTitulo("Captura de una evaluación por consola");
            var newEval = new Evaluación();
            string nombre, notastring;
            float nota;

            Console.WriteLine("Ingrese el nombre de la evaluacion");
            Printer.PresioneEnter();
            nombre = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                Printer.EscribirTitulo("El valor del nombre no puede ser vacio");
                Console.WriteLine("Saliendo del programa");
            }
            else
            {
                newEval.Nombre = nombre.ToLower();
                Console.WriteLine("El nombre de la evaluacion ha sido ingresado exitosamente");
            }

            Console.WriteLine("Ingrese la nota de la evaluacion");
            Printer.PresioneEnter();
            notastring = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(notastring))
            {
                Printer.EscribirTitulo("El valor de la nota no puede ser vacio");
                Console.WriteLine("Saliendo del programa");
            }
            else
            {
                try
                {
                    newEval.Nota = float.Parse(notastring);
                    if(newEval.Nota < 0 || newEval.Nota >5)
                    {
                        throw new ArgumentOutOfRangeException("La nota debe estar entre 0 y 5");
                    }
                    Console.WriteLine("La nota de la evaluacion ha sido ingresado exitosamente");
                }
                catch(ArgumentOutOfRangeException arge)
                {
                    Printer.EscribirTitulo(arge.Message);
                    Console.WriteLine("Saliendo del programa");
                }
                catch (Exception)
                {
                    
                    Printer.EscribirTitulo("El valor de la nota no es un numero valido");
                    Console.WriteLine("Saliendo del programa");
                }
                finally
                {
                    Printer.EscribirTitulo("FINALLY");
                }  
            }

        }

        private static void AccionDelEvento(object sender, EventArgs e)
        {
            Printer.EscribirTitulo("SALIENDO");
            Printer.Beep();
            Printer.EscribirTitulo("SALIO");
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            Printer.EscribirTitulo("Curso de la escuela");

            if (escuela?.Cursos != null)
            {
                foreach (var Curso in escuela.Cursos)
                {
                    Console.WriteLine($"Nombre: {Curso.Nombre}, Id: {Curso.UniqueId}");
                }
            }

        }
        //constructor que coloca un fondo de tras de consola y coloca un color a las letras
        public static void PonerColorDeFondo()
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;

            /*Console.Clear();*/
        }

    }
}
