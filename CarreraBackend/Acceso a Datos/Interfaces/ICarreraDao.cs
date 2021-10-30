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
 //       Carrera GetByID();
        bool Update(object entidad);
        bool DeleteByID(int id)
    }
}
