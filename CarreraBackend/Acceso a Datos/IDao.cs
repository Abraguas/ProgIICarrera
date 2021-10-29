using CarreraBackend.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraBackend.Acceso_a_Datos
{
    interface IDao
    {
        bool Save(Carrera carrera);
        List<Asignatura> GetAsignaturas();

    }
}
