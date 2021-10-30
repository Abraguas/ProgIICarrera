using CarreraBackend.Servicios.Implementaciones;
using CarreraBackend.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraBackend.Servicios
{
    class ServiceFactoryImp : AbstractServiceFactory
    {
        public override ICarreraService CrearCarreraService()
        {
            return new CarreraService();
        }

        public override IAsignaturaService CrearAsignaturaService()
        {
            return new AsignaturaService();
        }
    }
}
