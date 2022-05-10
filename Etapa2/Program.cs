using System;
using CoreEscuela.Entidades;
using static System.Console;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Raza de Bronce", 1858, TiposEscuela.Primaria,
            pais: "México", ciudad: "Mérida");

        

            //Forma de agregar el arreglo incluyendo la escuela
            escuela.Cursos = new Curso[]
            {
                new Curso(){ Nombre = "101" },
                new Curso(){ Nombre = "201" },
                new Curso(){ Nombre = "301" }
            };


            ImprimirCursosEscuela(escuela);

           

        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            Console.WriteLine("===========================");
            Console.WriteLine("    Cursos de la escuela");
            Console.WriteLine("===========================");

            if(escuela?.Cursos != null)
            {
                foreach (var Curso in escuela.Cursos)
                {
                    Console.WriteLine($"Nombre: {Curso.Nombre}, Id: {Curso.UniqueId}");
                }
            }
            
        }

    }
}
