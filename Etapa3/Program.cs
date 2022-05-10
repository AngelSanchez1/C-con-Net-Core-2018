using System;
using System.Collections.Generic;
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



            /*Forma de agregar el arreglo incluyendo la escuela
            escuela.Cursos = new Curso[]
            {
                new Curso(){ Nombre = "101" },
                new Curso(){ Nombre = "201" },
                new Curso(){ Nombre = "301" }
            };*/


            escuela.Cursos = new List<Curso>()
            {
                new Curso(){ Nombre = "101", Jornada = TiposJornada.Mañana },
                new Curso(){ Nombre = "201", Jornada = TiposJornada.Mañana },
                new Curso(){ Nombre = "301", Jornada = TiposJornada.Mañana }
            };

            escuela.Cursos.Add(new Curso() { Nombre = "102", Jornada = TiposJornada.Tarde });
            escuela.Cursos.Add(new Curso() { Nombre = "202", Jornada = TiposJornada.Tarde });

            var otraColleccion = new List<Curso>()
            {
                new Curso(){ Nombre = "401", Jornada = TiposJornada.Mañana },
                new Curso(){ Nombre = "501", Jornada = TiposJornada.Mañana },
                new Curso(){ Nombre = "501", Jornada = TiposJornada.Tarde }
            };
            //Curso tmp = new Curso { Nombre = "101 vacacional", Jornada = TiposJornada.Noche };
            escuela.Cursos.AddRange(otraColleccion);

            ImprimirCursosEscuela(escuela);
            /*Console.WriteLine("Curso.Hash "+ tmp.GetHashCode());
            escuela.Cursos.Remove(tmp);*/
            escuela.Cursos.RemoveAll(delegate (Curso cur)
            {
                return cur.Nombre == "301";
            });

            escuela.Cursos.RemoveAll((cur) => cur.Nombre == "501" && cur.Jornada == TiposJornada.Mañana);

            Console.WriteLine("===========================");
            ImprimirCursosEscuela(escuela);



        }


        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            Console.WriteLine("===========================");
            Console.WriteLine("    Cursos de la escuela");
            Console.WriteLine("===========================");

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
