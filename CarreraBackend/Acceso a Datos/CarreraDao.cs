using CarreraBackend.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraBackend.Acceso_a_Datos
{
    class CarreraDao : IDao
    {
        private DaoHelper helper;

        public CarreraDao()
        {
            helper = DaoHelper.ObtenerInstancia();
        }

        public List<Asignatura> GetAsignaturas()
        {
            DataTable resultado = helper.ConsultarDB("insertar_asignatura");
            List<Asignatura> lista = new List<Asignatura>();
            Asignatura asignatura;           
            foreach(DataRow fila in resultado.Rows)
            {
                asignatura = new Asignatura(Convert.ToString(fila["nombre"]));
                lista.Add(asignatura);
            }
            return lista;
        }

        public bool Save(Carrera carrera)
        {
            List<List<Parametro>> paramDetalles = new List<List<Parametro>>();
            List<Parametro> paramMaestro = new List<Parametro>();

            paramMaestro.Add(new Parametro("@nombre", carrera.Nombre));
            paramMaestro.Add(new Parametro("@titulo", carrera.Titulo));

            List<Parametro> auxParam;
            foreach(DetalleCarrera detalle in carrera.Detalles)
            {
                auxParam = new List<Parametro>();
                auxParam.Add(new Parametro("@id_carrera", Convert.ToString(carrera.Id)));
                auxParam.Add(new Parametro("@anio", Convert.ToString(detalle.AnioCursado)));
                auxParam.Add(new Parametro("@cuatrimestre", Convert.ToString(detalle.Cuatrimestre)));
                auxParam.Add(new Parametro("@id_materia", Convert.ToString(detalle.Materia.Id)));
            }

            return helper.InsertarMaestroDetalle("insertar_carrera",paramMaestro,"insertar_detalle",paramDetalles);

        }
    }
}
