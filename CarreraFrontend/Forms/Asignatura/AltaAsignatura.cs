using CarreraBackend.Servicios.Interfaces;
using CarreraFrontend.Cliente;
using Newtonsoft.Json;
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
        private ClienteSingleton cliente;
        private Accion modo;
        private CarreraBackend.Entidades.Asignatura asignatura;
        public AltaAsignatura(Accion modo, int nro)
        {
            InitializeComponent();
            asignatura = new CarreraBackend.Entidades.Asignatura();
            cliente = ClienteSingleton.GetInstancia();
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

        private async void btnAceptarAsig_Click(object sender, EventArgs e)
        {
            asignatura.Id = 0;
            asignatura.Nombre = txtNom_Asignatura.Text;
            await cliente.PostAsync("https://localhost:5001/api/Asignatura", JsonConvert.SerializeObject(asignatura));


        }
     
    }
}
