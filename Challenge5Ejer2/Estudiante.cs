using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5Ejer2
{
    internal class Estudiante : Persona
    {
        public Estudiante(string nombre) : base(nombre)
        {
            Nombre = nombre;
        }
    
        public void Estudiar()
        {
            Console.WriteLine("Estoy estudiando");
        }

    
    }
}
