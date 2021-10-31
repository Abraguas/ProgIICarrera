﻿using CarreraBackend.Acceso_a_Datos.Implementaciones;
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
