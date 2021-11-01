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
        private DaoHelper helper;

        public AsignaturaDao()
        {
            helper = new DaoHelper();
        }

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
                asignaturas.Add(new Asignatura(Convert.ToInt32(fila["id_asignatura"]),Convert.ToString(fila["nombre"])));
            }
            return asignaturas;
        }

        public bool DeleteByID(int id)
        {
            List<Parametro> p = new List<Parametro>();
            p.Add(new Parametro("@id", Convert.ToString(id)));
            return helper.EjecutarSpEntrada("borrar_asignatura_id", p);
        }
        public bool ExistsByID(int id)
        {
            int resultado = (int)helper.ConsultarEscalar("verificar_asignatura_id", new Parametro("@id", Convert.ToString(id)));
            return resultado > 0;
        }
        public bool Update(Asignatura asignatura)
        {
            List<Parametro> p = new List<Parametro>();
            p.Add(new Parametro("@nombre", asignatura.Nombre));
            p.Add(new Parametro("@id", Convert.ToString(asignatura.Id)));
            return helper.EjecutarSpEntrada("actualizar_asignatura", p);
        }
    }
}
