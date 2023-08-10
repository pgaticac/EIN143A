using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisClases
{
    public class Persona
    {
        private string _nombre;
        private string _apellido;
        private DateTime _fechaNacimiento;

        public Persona()
        {

        }
        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        //CTRL+R , CTRL+E encapsula un campo
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }

        public int Edad
        {
            get
            {
                int edad = DateTime.Today.Year - this.FechaNacimiento.Year;
                return edad;
                //Ctrl+K, Ctrl+D ordena el código
            }

        }




        public override string ToString()
        {
            return this.Nombre + " " + this.Apellido;
        }


    }
}
