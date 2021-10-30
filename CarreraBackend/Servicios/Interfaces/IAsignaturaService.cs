using CarreraBackend.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraBackend.Servicios.Interfaces
{
    public interface IAsignaturaService
    {
        public bool Grabar(Asignatura asignatura);
        public List<Asignatura> Consultar();
        public bool Actualizar();
        public bool Borrar(int id);
    }
}
