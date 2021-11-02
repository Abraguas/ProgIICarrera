using CarreraFrontend.Forms.Asignatura;
using CarreraFrontend.Forms.Carrera;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarreraFrontend.Forms
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void soporteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cargarNuevaCarreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alta_Carreras frmNueva_carrera = new Alta_Carreras (Accion.CREATE , 0);
            frmNueva_carrera.ShowDialog();
        }
        private void consultarCarrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarCarrera frmConsultar_carrera = new ConsultarCarrera(Accion.CREATE);
            frmConsultar_carrera.ShowDialog();
        }

        private void agregarAsignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaAsignatura frmNueva_Asignatura = new AltaAsignatura (Accion.CREATE, 0);
            frmNueva_Asignatura.ShowDialog();
        }

        private void consultarAsignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarAsignatura frmConsultar_Asignatura = new ConsultarAsignatura(Accion.CREATE);
            frmConsultar_Asignatura.ShowDialog();

        }

  
    }
}
