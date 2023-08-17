using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Persona
    {
        private string _nombre;
        private string _apellido;
        private string _telefono;
        private DateTime _fechaNacimiento;
        private Clasificacion _grupo;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public Clasificacion Grupo { get => _grupo; set => _grupo = value; }
        public int Edad
        {
            get {
                int edad = DateTime.Today.Year - this.FechaNacimiento.Year;
                return edad;
            }
           
        }

        
    }
}
