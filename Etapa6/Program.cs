using System;
using System.Collections.Generic;
using System.Linq;
using CoreEscuela.Entidades;
using CoreEscuela.util;
using static System.Console;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            
            PonerColorDeFondo();
            //se llama a la clase de EscuelaEngine que es la que inicializa las cargas de cursos, asignaturas y evaluaciones
            var engine = new EscuelaEngine();
            engine.Inicializar();

            //se llama a la clase printer que es la cual imprime en consola el titulo de la escuela 
            //con sus diferentes atributos 

            Printer.EscribirTitulo("Bienvenidos a la escuela".ToUpper());
            /*Printer.Beep();*/
            ImprimirCursosEscuela(engine.Escuela);
            var listaObjetos = engine.GetObjetoEscuelaBases();
            var listaILugar = from obj in listaObjetos
                              where obj is ILugar
                              select (ILugar) obj ;

            //engine.Escuela.LimpiarLugar();


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
