using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5Ejer2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Persona[] personas = new Persona[3];

            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Escribe nombre del profesor");
                    personas[i] = new Profesor(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Escribe nombre del estudiante");
                    personas[i] = new Estudiante(Console.ReadLine());
                }
            }

            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    ((Profesor)personas[i]).Explicar();

                }
                else
                {
                    ((Estudiante)personas[i]).Estudiar();
                }
            }

            Console.ReadKey();

        }
    }
}
