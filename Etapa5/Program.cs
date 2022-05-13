using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using CoreEscuela.util;
using static System.Console;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var engine = new EscuelaEngine();
            engine.Inicializar();
            Printer.EscribirTitulo("Bienvenidos a la escuela".ToUpper());
            Printer.Beep();
            
            ImprimirCursosEscuela(engine.Escuela);

            
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

    }
}
