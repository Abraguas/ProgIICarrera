using CarreraBackend.Acceso_a_Datos.Interfaces;
using CarreraBackend.Entidades;
using System;
using System.Collections.Generic;
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
            return helper.InsertarAuxiliar("insertar_asignatura", p );
        }
        public List<Asignatura> Get()
        {
            throw new NotImplementedException();
        }

        public bool DeleteByID(int id)
        {
            throw new NotImplementedException();
        }

    }
}
