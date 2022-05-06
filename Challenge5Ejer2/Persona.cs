using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5Ejer2
{
    public class Persona
    {
        protected string Nombre { get; set; }

        public Persona(string nombre)
        {
            Nombre = nombre;
        }

        public override string ToString()
        {
            return "Hola mi nombre es " + Nombre;
        }
    }
}
