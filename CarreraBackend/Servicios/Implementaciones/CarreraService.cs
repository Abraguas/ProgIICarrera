using CarreraBackend.Acceso_a_Datos;
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
    class CarreraService : ICarreraService
    {
        private ICarreraDao dao;
        public CarreraService()
        {
            dao = new CarreraDao();

        }

        public bool Actualizar(Carrera carrera)
        {
            if (dao.ExistsByID(carrera.Id))
            {
                return dao.Update(carrera);
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

        //public List<Carrera> ConsultarCarreras(List<Parametro> criterios)
        //{
        //    dao.GetByFilters(criterios);
        //}
        public List<Carrera> Consultar()
        {
           return dao.Get();
        }
        public bool Grabar(Carrera oCarrera)
        {
            return dao.Save(oCarrera);
        }

    }
}
