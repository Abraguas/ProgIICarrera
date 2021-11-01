using CarreraBackend.Acceso_a_Datos.Interfaces;
using CarreraBackend.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraBackend.Acceso_a_Datos.Implementaciones
{
    class DetalleDao : IDetalleDao
    {           
        private DaoHelper helper;

        public bool DeleteByID(int id)
        {
            List<Parametro> p = new List<Parametro>();
            p.Add(new Parametro("@id_detalle", Convert.ToString(id)));
            return helper.EjecutarSpEntrada("borrar_detalle_id", p);
        }

        public bool ExistsByID(int id)
        {
            int resultado = (int)helper.ConsultarEscalar("verificar_detalle_id", new Parametro("@id_detalle", Convert.ToString(id)));
            return resultado > 0;
        }

        public bool Save(DetalleCarrera detalle, int id_carrera)
        {
            List<Parametro> p = new List<Parametro>();
            p.Add(new Parametro("@id_carrera", Convert.ToString(id_carrera)));
            p.Add(new Parametro("@anio_cursado", Convert.ToString(detalle.AnioCursado)));
            p.Add(new Parametro("@cuatrimestre", Convert.ToString(detalle.Cuatrimestre)));
            p.Add(new Parametro("@id_materia", Convert.ToString(id_carrera)));
            return helper.EjecutarSpEntrada("insertar_detalle", p);
        }
    }
}
