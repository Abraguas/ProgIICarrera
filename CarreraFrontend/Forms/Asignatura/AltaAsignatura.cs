using CarreraBackend.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarreraFrontend.Forms.Asignatura
{

    public partial class AltaAsignatura : Form
    {
        private IAsignaturaService servicio_asignatura;
        private Accion modo;
        public AltaAsignatura(Accion modo, int nro)
        {
            InitializeComponent();

            //servicio_asignatura = new AsignaturaService().Grabar();
            this.modo = modo;
            if (modo.Equals(Accion.READ))
            {
                btnAceptarAsig.Enabled = false;
                this.Text = "Ver Asignatura";
                // Cargar_AsignaturaAsync(nro);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
