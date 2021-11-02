using CarreraBackend.Servicios.Implementaciones;
using CarreraBackend.Servicios.Interfaces;
using CarreraFrontend.Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarreraBackend.Entidades;
using Newtonsoft.Json;
using CarreraBackend.Acceso_a_Datos;
using CarreraWebAPI.Controllers;

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
        private ClienteSingleton cliente;


       CarreraBackend.Entidades.Carrera oCarrera = new CarreraBackend.Entidades.Carrera();
       CarreraBackend.Entidades.DetalleCarrera oDetalleCarrera = new CarreraBackend.Entidades.DetalleCarrera();

        public Alta_Carreras(Accion modo, int nro)
        {
            InitializeComponent();
            cliente = ClienteSingleton.GetInstancia();
            //servicio_carrera = new CarreraService().Grabar();
            this.modo = modo;
            if (modo.Equals(Accion.READ))
            {
                btnAceptar.Enabled = false;
                this.Text = "Ver Carrera";
                //Cargar_CarreraAsync(nro);
            }
        }
        //44307 (mati)

        private async Task Cargar_CarrreraAsync(int nro)
        {
            string url = "https://localhost:44307/api/Carreras/" + nro.ToString();
            var resultado = await ClienteSingleton.GetInstancia().GetAsync(url);
            this.oCarrera = JsonConvert.DeserializeObject<CarreraBackend.Entidades.Carrera>(resultado);

            oCarrera.Nombre = txtNom_Carrera.Text;
            oCarrera.Titulo = Convert.ToString(cboTitulo.SelectedItem);
            oDetalleCarrera.AnioCursado = Convert.ToInt32(nudAñosCursado.Value);
            oDetalleCarrera.Cuatrimestre = Convert.ToInt32(nudCuatrimestre.Value);
            CarreraBackend.Entidades.Asignatura oMateria = (CarreraBackend.Entidades.Asignatura)cboMateria.SelectedItem;

        }

        private async void CargarCombo()
        {
            string url = "https://localhost:44307/api/Asignatura/Asignatura";
            var resultado = await cliente.GetAsync(url);
            List<CarreraBackend.Entidades.Asignatura> lst = JsonConvert.DeserializeObject <List<CarreraBackend.Entidades.Asignatura>>(resultado);
            cboMateria.DataSource = lst;
            cboMateria.ValueMember = "Id";
            cboMateria.DisplayMember = "Nombre";
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
            CargarCombo();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
        }

        private void Alta_Carreras_Load(object sender, EventArgs e)
        {

        }
    }
}
