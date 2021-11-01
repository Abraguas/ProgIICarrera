using CarreraBackend.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraBackend.Acceso_a_Datos.Interfaces
{
    interface IDetalleDao
    {
        bool DeleteByID(int id);
        bool Save(DetalleCarrera detalle, int id_carrera);

        bool ExistsByID(int id);
    }
}
