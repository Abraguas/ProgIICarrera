﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraBackend.Entidades
{
    class Asignatura
    {
        public string Nombre { get; set; }

        public Asignatura()
        {
        }

        public Asignatura(string nombre)
        {
            Nombre = nombre;
        }
    }
}