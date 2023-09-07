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

            //Validar que categoría no exista en la BD
            if (this.Find(nombre) == false)
            {
                Categoria nueva = new Categoria();
                nueva.Nombre = nombre;

                bde.Categoria.Add(nueva);
                bde.SaveChanges();
            }
        }

        public List<Categoria> GetAll()
        {
            List<Categoria> categorias = new List<Categoria>();

            categorias = bde.Categoria.ToList();

            return categorias;
        }

        public List<Categoria> GetFilter(string filtro)
        {
            List<Categoria> categorias = new List<Categoria>();
            categorias = bde.Categoria.Where(c => c.Nombre.Contains(filtro)).ToList();
            return categorias;
        }

        public bool Find(string nombre)
        {
            Categoria cat = bde.Categoria.FirstOrDefault(c => c.Nombre == nombre);
            if (cat == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Delete(Categoria categoria)
        {
            bde.Categoria.Remove(categoria);
            bde.SaveChanges();
        }

        public void Edit(Categoria categoria)
        {   
            //La búsqueda debe ser por la clave primaria (u otro cambio que no haya sido editado)
            Categoria cat = bde.Categoria.FirstOrDefault(c => c.Id == categoria.Id);
            cat.Nombre = categoria.Nombre;
            bde.SaveChanges();
        }


    }
}
