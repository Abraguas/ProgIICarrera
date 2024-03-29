﻿using CarreraBackend.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraBackend.Servicios
{
   public abstract class AbstractServiceFactory
    {
        public abstract ICarreraService CrearCarreraService();
        public abstract IAsignaturaService CrearAsignaturaService();
    }
}
