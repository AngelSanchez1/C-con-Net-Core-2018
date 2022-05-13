//Esta es la clases padre del cual se aplicara la herencia a las demas clases
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEscuela.Entidades
{
    // Una clase abstracta (asbtract) puede ser heredada pero no instanciada
    public  class ObjetoEscuelaBase
    {
        public string UniqueId { get; private set; } // propiedad que asigna un unico Id a las clases
        public string Nombre { get; set; } // propiedad que se usa para asignar el nombre a la clase que lo herede

        //constructor que es es encargado que el objeto con unico Id lo convierta en variable string
        public ObjetoEscuelaBase()
        {
            UniqueId = Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            return $"{Nombre},{UniqueId}";
        }
    }
}