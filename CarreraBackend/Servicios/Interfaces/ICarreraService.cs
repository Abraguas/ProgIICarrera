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
        public List<Carrera> Consultar();
        public bool Grabar(Carrera oCarrera);
        public bool Actualizar(Carrera oCarrera);
        public bool Borrar(int id);
    }
}
