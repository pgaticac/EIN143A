using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class CategoriaBLL
    {
        BaseDeDatosEntities bde = new BaseDeDatosEntities();

        public void Add(string nombre)
        {
            //Validar reglas de negocio

            Categoria nueva = new Categoria();
            nueva.Nombre = nombre;

            bde.Categoria.Add(nueva);
            bde.SaveChanges();
        }
    }
}
