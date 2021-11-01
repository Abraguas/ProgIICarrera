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
    public class DetalleService : IDetalleService
    {
        private IDetalleDao dao;
        public DetalleService()
        {
            dao = new DetalleDao();

        }

        public bool Borrar(int id)
        {
            if (dao.ExistsByID(id))
            {
                return dao.DeleteByID(id);

            }
            return false;
        }

        public bool Grabar(DetalleCarrera detalle, int id_carrera)
        {
            if (!dao.ExistsByID(detalle.Id))
            {
                return dao.Save(detalle, id_carrera);

            }
            return false;
        }
    }
}
