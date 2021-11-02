using CarreraBackend.Servicios.Implementaciones;
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

namespace CarreraFrontend.Forms
{
    public enum Accion
    {
        CREATE,
        READ,
        UPDATE,
        DELETE
    }
    public partial class Alta_Carreras : Form
    {
        private ICarreraService servicio_carrera;
        private Accion modo;
        public Alta_Carreras(Accion modo, int nro)
        {
            InitializeComponent();
            //servicio_carrera = new CarreraService().Grabar();
            this.modo = modo;
            if (modo.Equals(Accion.READ))
            {
                btnAceptar.Enabled = false;
                this.Text = "Ver Carrera";
               // Cargar_CarreraAsync(nro);
            }
        }

        private void lblCarreraNro_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Alta_Carreras_Load(object sender, EventArgs e)
        {

        }
    }
}
