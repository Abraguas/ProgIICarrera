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
    public partial class ConsultarAsignatura : Form
    {


        private CarreraBackend.Entidades.Asignatura asignatura;
        private ClienteSingleton cliente;
        private Accion modo;
        public ConsultarAsignatura(Accion modo)
        {
            InitializeComponent();
            //servicio_carrera = new CarreraService().Grabar();
            this.modo = modo;
            if (modo.Equals(Accion.READ))
            {
                //btnAceptar.Enabled = false;
                //this.Text = "Ver Carrera";
                // Cargar_CarreraAsync(nro);
            }
        }

        private void ConsultarAsignatura_Load(object sender, EventArgs e)
        {

        }
        private async Task CargarAsignaturaAsync()
        {
            string url = "https://localhost:5001/api/Asignatura/Asignatura";
            var resultado = await cliente.GetAsync(url);
            asignatura = JsonConvert.DeserializeObject<CarreraBackend.Entidades.Asignatura>(resultado);
        }
    }
}
