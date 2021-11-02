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
using System.Net.Http;

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
        CarreraBackend.Entidades.Asignatura oAsignatura = new CarreraBackend.Entidades.Asignatura();
        CarreraBackend.Entidades.DetalleCarrera oDetalle = new CarreraBackend.Entidades.DetalleCarrera();

        public Alta_Carreras(Accion modo, int nro)
        {
            InitializeComponent();
            cliente = ClienteSingleton.GetInstancia();
            //servicio_carrera = new CarreraService().ObtenerProximoID();
            this.modo = modo;
            if (modo.Equals(Accion.READ))
            {
                btnAceptar.Enabled = false;
                this.Text = "Ver Carrera";  
            }
        }

        private void Alta_Carreras_Load(object sender, EventArgs e)
        {
            if (modo.Equals(Accion.CREATE))
            {
                LimpiarCamposAsync();
                CargarCombo();
                //Cargar_CarrreraAsync();
                
            }
       
        }

        //BOTONES
        private void btnAgregar_Asig_Click(object sender, EventArgs e)
        {
            if (ExisteProductoEnGrilla(cboMateria.Text))
            {
                MessageBox.Show("La asignatura ya fue registrada!", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DetalleCarrera oDetalle = new DetalleCarrera();
            CarreraBackend.Entidades.Carrera oCarrera = new CarreraBackend.Entidades.Carrera();

            oDetalle.Materia = (CarreraBackend.Entidades.Asignatura)cboMateria.SelectedItem;
            oDetalle.AnioCursado = (int)nudAñosCursado.Value;
            oDetalle.Cuatrimestre = (int)nudCuatrimestre.Value;
            oCarrera.AgregarDetalle(oDetalle);
            dgvAsignaturas.Rows.Add(new string[] {"", oDetalle.Materia.Nombre, oDetalle.AnioCursado.ToString(), oDetalle.Cuatrimestre.ToString() });
            
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNom_Carrera.Text) || string.IsNullOrEmpty(cboMateria.Text))
            {
                MessageBox.Show("Los campos: Nombre de carrera y Materia son obligatorios!", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string url = "https://localhost:44307/api/Carreras/ProximoId";
            var resultado = await ClienteSingleton.GetInstancia().GetAsync(url);
            this.oCarrera.Id = JsonConvert.DeserializeObject<int>(resultado);

            oCarrera.Nombre = txtNom_Carrera.Text;
            oCarrera.Titulo = Convert.ToString(cboTitulo.SelectedItem);
            string data = JsonConvert.SerializeObject(oCarrera);

            
            string url2 = "https://localhost:44307/api/Carreras";

            if (cliente.PostAsync(url2,data).IsCompleted)
            {
                MessageBox.Show("Carrera registrada con éxito!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
               // await LimpiarCamposAsync();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un inconveniente al registrar la Carrera!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cancelar el registro?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        //METODOS PRIVATE
        //private async Task Cargar_CarrreraAsync()
        //{
        //    //44307 (mati)
        //    //string url = "https://localhost:44307/api/Carreras/ProximoId";
        //    //var resultado = await ClienteSingleton.GetInstancia().GetAsync(url);
        //    //this.oCarrera.Id = JsonConvert.DeserializeObject<int>(resultado);

        //    dgvAsignaturas.Rows.Clear();
        //    foreach (DetalleCarrera oDetalle in oCarrera.Detalles)
        //    {
        //        dgvAsignaturas.Rows.Add(new object[] { "" ,oDetalle.Materia.Nombre, oDetalle.AnioCursado, oDetalle.Cuatrimestre }); ;
        //    }
        //}

        private async Task CargarCombo()
        {
            string url = "https://localhost:44307/api/Asignatura/Asignatura";
            var resultado = await cliente.GetAsync(url);
            List<CarreraBackend.Entidades.Asignatura> lst = JsonConvert.DeserializeObject<List<CarreraBackend.Entidades.Asignatura>>(resultado);
            cboMateria.DataSource = lst;
            cboMateria.ValueMember = "Id";
            cboMateria.DisplayMember = "Nombre";
        }
        private async Task LimpiarCamposAsync()
        {
            txtNom_Carrera.Text = string.Empty;
            txtNom_Carrera.Focus();
            cboTitulo.SelectedItem = string.Empty;
            nudAñosCursado.Value = int.MinValue;
            nudCuatrimestre.Value = int.MinValue;
            dgvAsignaturas.Rows.Clear();
            
            await AsignarNumeroCarrreraAsync();
        }

        private async Task AsignarNumeroCarrreraAsync()
        {
            string url = "https://localhost:44307/api/Carrera/proximoId";
            
            {
                var result = await cliente.GetAsync(url);
                oCarrera.Id = Int32.Parse(result);
                lblCarreraNro.Text = "Carrera Nro: " + result;
            }

        }
        private async Task <bool> GrabarCarreraAsync(string data)
        {
            string url = "https://localhost:44307/api/Carrera";
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(url, content);
                string response = await result.Content.ReadAsStringAsync();
                return response.Equals("Ok");
            }
        }

        private bool ExisteProductoEnGrilla(string text)
        {
            foreach (DataGridViewRow fila in dgvAsignaturas.Rows)
            {
                if (fila.Cells["col_Asignatura"].Value.Equals(text))
                    return true;
            }
            return false;
        }




        //----------------------------------------------------------------
        private void lblCarreraNro_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
