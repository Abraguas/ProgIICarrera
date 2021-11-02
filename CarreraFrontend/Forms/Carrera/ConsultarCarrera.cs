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
using Asig = CarreraBackend.Entidades.Asignatura;
using Carr = CarreraBackend.Entidades.Carrera;

namespace CarreraFrontend.Forms.Carrera
{
    public partial class ConsultarCarrera : Form
    {
        private ClienteSingleton cliente;
        public ConsultarCarrera()
        {

            InitializeComponent();
            cliente = ClienteSingleton.GetInstancia();

        }

        private void ConsultarCarrera_Load(object sender, EventArgs e)
        {
            CargarDgv();
        }
        private async void CargarDgv()
        {
            dgvConsultar_Carrera.Rows.Clear();
            List<Carr> carreras;
            string url = "https://localhost:44307/api/Carreras/Carrera";//4307(mati), 5001(franco)
            var resultado = await cliente.GetAsync(url);
            carreras = JsonConvert.DeserializeObject<List<Carr>>(resultado);
            foreach (Carr carrera in carreras)
            {
                dgvConsultar_Carrera.Rows.Add(new object[] { carrera.Id, carrera.Nombre, carrera.Titulo });

            }
        }

        private async void dgvConsultar_Carrera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //EDITAR
            if (e.ColumnIndex == 3)
            {
                int id = (int)dgvConsultar_Carrera.Rows[e.RowIndex].Cells[0].Value;
                Alta_Carreras frmNueva_Asignatura = new Alta_Carreras(Accion.UPDATE, id);
                frmNueva_Asignatura.ShowDialog();
                CargarDgv();
            }
            //BORRAR
            else if (e.ColumnIndex == 4)
            {
                int id = (int)dgvConsultar_Carrera.Rows[e.RowIndex].Cells[0].Value;
                var result = (await BorrarCarreraAsync(id));
                if (result == "true")
                {
                    MessageBox.Show("Se borró la asignatura con exito!!", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo borrar la asignatura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                CargarDgv();
            }
        }

        private async Task<string> BorrarCarreraAsync(int id)
        {
            string url = "https://localhost:44307/api/Carreras/" + id;//4307(mati),//5001(franco)
            var resultado = await cliente.DeleteAsync(url);
            return resultado;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Carrera_Click(object sender, EventArgs e)
        {

        }
    }
}
