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
    class AsignaturaService : IAsignaturaService
    {
        private IAsignaturaDao dao;

        public AsignaturaService()
        {
            dao = new AsignaturaDao();
        }

        public bool Actualizar()
        {
            throw new NotImplementedException();
        }

        public bool Borrar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Asignatura> Consultar()
        {
            throw new NotImplementedException();
        }

        public bool Grabar(Asignatura asignatura)
        {
            throw new NotImplementedException();
        }
    }
}
