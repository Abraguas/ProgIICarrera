using CarreraBackend.Acceso_a_Datos.Interfaces;
using CarreraBackend.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraBackend.Acceso_a_Datos.Implementaciones
{
    class AsignaturaDao : IAsignaturaDao
    {
        private DaoHelper helper = DaoHelper.ObtenerInstancia();
        public bool Save(Asignatura asignatura)
        {
            List<Parametro> p = new List<Parametro>();
            p.Add(new Parametro("@nombre", asignatura.Nombre));
            return helper.EjecutarSpEntrada("insertar_asignatura", p );
        }
        public List<Asignatura> Get()
        {
            DataTable resultado = helper.ConsultarDB("consultar_asignatura");
            List<Asignatura> asignaturas = new List<Asignatura>();
            foreach(DataRow fila in resultado.Rows)
            {
                asignaturas.Add(new Asignatura(Convert.ToInt32("id_asignatura"),Convert.ToString("nombre")));
            }
            return asignaturas;
        }

        public bool DeleteByID(int id)
        {
            List<Parametro> p = new List<Parametro>();
            p.Add(new Parametro("@id", Convert.ToString(id)));
            return helper.EjecutarSpEntrada("borrar_asignatura", p);
        }

        public bool Update(Asignatura asignatura)
        {
            throw new NotImplementedException();
        }
    }
}
