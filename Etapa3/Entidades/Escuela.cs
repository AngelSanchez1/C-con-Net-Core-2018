using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    class Escuela
    {
        string nombre;
        
        public string Nombre
        {
            get{ return "Copia: "+nombre; }
            set{ nombre = value.ToUpper(); }
        }

        public int AñoDeCreacion {get; set;}
        public string Pais { get; set; }
        public string Ciudad { get; set; }

        public TiposEscuela TipoEscuela { get; set; }
        
        //Metodo del array
        /*public Curso[] Cursos { get; set; }*/

        //Metodo de la lista
        public List<Curso> Cursos { get; set; }

        public Escuela (string nombre, int año) => (Nombre, AñoDeCreacion) = (nombre, año);

        public Escuela (string nombre, int año, TiposEscuela tipo,
        string pais = "", string ciudad = "")
        {
            (Nombre,AñoDeCreacion) = (nombre, año);
            Pais = pais;
            Ciudad = ciudad;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Tipo: {TipoEscuela}, {System.Environment.NewLine} Pais: {Pais}, Ciudad: {Ciudad}";
        }
    }
}