﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraBackend.Entidades
{
    class DetalleCarrera
    {
        public int AnioCursado { get; set; }
        public int Cuatrimestre { get; set; }
        public Asignatura materia { get; set; }

    }
}