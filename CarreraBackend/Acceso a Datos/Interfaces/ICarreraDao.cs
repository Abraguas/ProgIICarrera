using CarreraBackend.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraBackend.Acceso_a_Datos
{
    interface ICarreraDao
    {
        bool Save(Carrera carrera);
        List<Carrera> Get();
        bool ExistsByID(int id);
        bool Update(Carrera carrera);
        bool DeleteByID(int id);
    }
}
