using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5Ejer2
{
    internal class Profesor : Persona
    {
        public Profesor(string nombre) : base(nombre)
        {
            Nombre = nombre;
        }

        public void Explicar()
        {
            Console.WriteLine("Estoy explicando");
        }
    }
}
