using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Participante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Email { get; set; }

        public Participante()
        {
            Nombre = String.Empty;
            Edad = 0;
            Email = String.Empty;
        }

        public Participante(string nombre, int edad, string email)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Email = email;
        }

        public override string ToString()
        {
            return this.Nombre + " " + this.Edad + " años";
        }
    }
}
