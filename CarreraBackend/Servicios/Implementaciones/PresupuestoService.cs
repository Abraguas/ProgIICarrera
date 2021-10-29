using CarreraBackend.Acceso_a_Datos;
using CarreraBackend.Entidades;
using CarreraBackend.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraBackend.Servicios.Implementaciones
{
    class CarreraService : IService
    {
        private IDao dao; 
        public CarreraService()
        {
            dao = new CarreraDao();
        }
        //public List<Carrera> ConsultarCarreras(List<Parametro> criterios)
        //{
        //    dao.GetByFilters(criterios);
        //}
        public List<Asignatura> ConsultarAsignatura()
        {
           return dao.GetAsignatura;
        }
        public bool GrabarCarrera(Carrera oCarrera)
        {
            return dao.Save(oCarrera);
        }

    }
}
