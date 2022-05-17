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
           // AppDomain.CurrentDomain.ProcessExit += AccionDelEvento;
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
