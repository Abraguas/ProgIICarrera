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

        public bool Actualizar()
        {
            throw new NotImplementedException();
        }

        public bool Borrar(int id)
        {
            throw new NotImplementedException();
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
