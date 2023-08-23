using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Inscripcion
    {
        private Recorrido _recorrido;
        private Categoria _categoria;
        private string _identificador;
        private DateTime _fechaInscripcion;
        private Participante _participante;

        public Inscripcion()
        {
            this.FechaInscripcion = DateTime.Today;
        }

        public Recorrido Recorrido { get => _recorrido; set => _recorrido = value; }
        public Categoria Categoria { get => _categoria; set => _categoria = value; }
        public string Identificador { get => _identificador; set => _identificador = value; }
        public DateTime FechaInscripcion { get => _fechaInscripcion; set => _fechaInscripcion = value; }
        public Participante Participante { get => _participante; set => _participante = value; }

        

        public int ValorInscripcion
        {
            get
            {
                int valor = (int)this.Recorrido * (int)this.Categoria / 100;
                return valor;

            }
        }

        public override string ToString()
        {
            return String.Format("{0} {1} ${2}",Identificador,Participante,ValorInscripcion)
        }
    }
}
