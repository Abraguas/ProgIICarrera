using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraBackend.Entidades
{
    public class Asignatura
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Asignatura()
        {
        }

        public Asignatura(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }
}
