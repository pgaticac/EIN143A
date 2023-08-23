using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class InscripcionDLL
    {
        private List<Inscripcion> inscripciones;
        int corrK2;
        int corrK4;
        int corrK8;
        public InscripcionDLL()
        {
            inscripciones = new List<Inscripcion>();
            corrK2 = 0;
            corrK4 = 0;
            corrK8 = 0;
        }

        public void Add(Inscripcion inscripcion)
        {
            switch (inscripcion.Recorrido)
            {
                case Recorrido.K2:
                    corrK2++;
                    inscripcion.Identificador = inscripcion.Recorrido +"-"+ corrK2;
                    break;
                case Recorrido.K4:
                    corrK4++;
                    inscripcion.Identificador = inscripcion.Recorrido + "-" + corrK4;
                    break;
                case Recorrido.K8:
                    corrK8++;
                    inscripcion.Identificador = inscripcion.Recorrido + "-" + corrK8;
                    break;
            }

            inscripciones.Add(inscripcion);
            
        }

        public List<Inscripcion> GetInscripciones()
        {
            //return this.inscripciones

            return (List<Inscripcion>)inscripciones.OrderBy(inscripcion => inscripcion.Recorrido); //Retornar lista ordenada por recorrido
        }
    }
}
