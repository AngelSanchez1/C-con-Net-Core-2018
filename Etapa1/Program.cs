using System;
using CoreEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Raza de Bronce",1858,TiposEscuela.Primaria,
            pais:"México", ciudad: "Mérida");
            

            Console.WriteLine(escuela);
        }
    }
}
