using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MisClases;

namespace Presentacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            p.Nombre = "Pedro";
            p.Apellido = "Parker";
            p.FechaNacimiento = new DateTime(1999, 5, 14);

            Persona p1 = new Persona("Bruno", "Diaz");
            p1.FechaNacimiento = new DateTime(1970, 9, 24);

            Console.WriteLine(p.Nombre + " " + p.Apellido);
            Console.WriteLine(p1.Nombre + " " + p1.Apellido);

            Console.WriteLine(p);
            Console.WriteLine(p1);

            Console.WriteLine(p.Edad);
            Console.WriteLine(p1.Edad);

            Console.WriteLine(p.FechaNacimiento.ToString("dd/MM/yyyy"));

            Console.ReadKey();
        }
    }
}
