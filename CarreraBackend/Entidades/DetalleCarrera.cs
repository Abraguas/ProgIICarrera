using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraBackend.Entidades
{
   public class DetalleCarrera
    {
        public int Id { get; set; }
        public int AnioCursado { get; set; }
        public int Cuatrimestre { get; set; }
        public Asignatura Materia { get; set; }

        public DetalleCarrera(int id, int anioCursado, int cuatrimestre, Asignatura materia)
        {
            Id = id;
            AnioCursado = anioCursado;
            Cuatrimestre = cuatrimestre;
            Materia = materia;
        }

        public DetalleCarrera()
        {
        }
    }
}
