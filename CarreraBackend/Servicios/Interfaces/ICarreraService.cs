using CarreraBackend.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraBackend.Servicios.Interfaces
{
   public interface ICarreraService
    {
        //public bool RegistrarBajaCarrera(int carrera);
        //public List<Carrera> ConsultarCarreras(List<Parametro> criterios);
        public List<Carrera> Consultar();
        public bool Grabar(Carrera oCarrera);
    }
}
