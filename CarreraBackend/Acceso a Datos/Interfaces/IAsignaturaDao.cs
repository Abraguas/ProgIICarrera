using CarreraBackend.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraBackend.Acceso_a_Datos.Interfaces
{
    interface IAsignaturaDao
    {
        bool Save(Asignatura asignatura);
        List<Asignatura> Get();
        bool DeleteByID(int id);
        bool Update(Asignatura asignatura);
        bool ExistsByID(int id);

    }
}
