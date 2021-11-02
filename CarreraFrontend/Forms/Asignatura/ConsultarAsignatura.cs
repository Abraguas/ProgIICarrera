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


        private ClienteSingleton cliente;
        private Accion modo;
        public ConsultarAsignatura(Accion modo)
        {
            InitializeComponent();
            cliente = ClienteSingleton.GetInstancia();
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
            CargarAsignaturaAsync();
        }
        private async void CargarAsignaturaAsync()
        {
            List<CarreraBackend.Entidades.Asignatura> asignaturas;
            string url = "https://localhost:5001/api/Asignatura/Asignatura";
            var resultado = await cliente.GetAsync(url);
            asignaturas = JsonConvert.DeserializeObject<List<CarreraBackend.Entidades.Asignatura>>(resultado);
            foreach(CarreraBackend.Entidades.Asignatura asignatura in asignaturas)
            {
                dgvConsultar_Asignatura.Rows.Add(new object[] { asignatura.Id, asignatura.Nombre });

            }
        }

        private void dgvConsultar_Asignatura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 2)
            {
                int id = (int)dgvConsultar_Asignatura.Rows[e.RowIndex].Cells[0].Value;
                MessageBox.Show(id.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(e.ColumnIndex == 3) 
            {
                int id = (int)dgvConsultar_Asignatura.Rows[e.RowIndex].Cells[0].Value;
                MessageBox.Show(id.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
