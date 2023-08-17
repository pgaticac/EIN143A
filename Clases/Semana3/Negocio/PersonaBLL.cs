using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class PersonaBLL
    {
        //Conexión a los datos
        List<Persona> contactos;

        public PersonaBLL()
        {
            contactos = new List<Persona>();
        }

        //Métodos de Negocio
        public void Agregar(Persona persona)
        {
            //Validaciones de regla de negocio

            //Agregar elemento a la colección
            contactos.Add(persona);
        }

        public List<Persona> ListarTodos()
        {
            return contactos;
        }
    }
}
