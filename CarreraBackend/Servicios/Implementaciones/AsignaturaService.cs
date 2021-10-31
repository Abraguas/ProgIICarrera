using CarreraBackend.Acceso_a_Datos.Implementaciones;
using CarreraBackend.Acceso_a_Datos.Interfaces;
using CarreraBackend.Entidades;
using CarreraBackend.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraBackend.Servicios.Implementaciones
{
   public class AsignaturaService : IAsignaturaService
    {
        private IAsignaturaDao dao;

        public AsignaturaService()
        {
            dao = new AsignaturaDao();
        }

        public bool Actualizar(Asignatura asignatura)
        {
            if (dao.ExistsByID(asignatura.Id))
            {
                return dao.Update(asignatura);
            }
            else return false;
        }

        public bool Borrar(int id)
        {
            if (dao.ExistsByID(id))
            {
                return dao.DeleteByID(id);
            }
            else return false;
        }

        public List<Asignatura> Consultar()
        {
            return dao.Get();
        }

        public bool Grabar(Asignatura asignatura)
        {

            return dao.Save(asignatura);

        }
    }
}
