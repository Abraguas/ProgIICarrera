using CarreraBackend.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraBackend.Servicios.Interfaces
{
    public interface IDetalleService
    {
        public bool Borrar(int id);
        public bool Grabar(DetalleCarrera detalle, int id_carrera);

    }
}
