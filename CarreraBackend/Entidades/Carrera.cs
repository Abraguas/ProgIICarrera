using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraBackend.Entidades
{
    public class Carrera
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Titulo { get; set; }
        public List<DetalleCarrera> Detalles { get; set; }

        public Carrera()
        {
            Detalles = new List<DetalleCarrera>();
        }

        public Carrera(string nombre, string titulo, List<DetalleCarrera> detalles)
        {
            Nombre = nombre;
            Titulo = titulo;
            Detalles = detalles;
        }

        public void AgregarDetalle(DetalleCarrera detalle)
        {
            Detalles.Add(detalle);
        }
    }
}
