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
        public ConsultarAsignatura()
        {
            InitializeComponent();
            cliente = ClienteSingleton.GetInstancia();
        }

        private void ConsultarAsignatura_Load(object sender, EventArgs e)
        {
            CargarDgv();
        }
        private async void CargarDgv()
        {
            dgvConsultar_Asignatura.Rows.Clear();
            List<CarreraBackend.Entidades.Asignatura> asignaturas;
            string url = "https://localhost:5001/api/Asignatura/Asignatura";
            var resultado = await cliente.GetAsync(url);
            asignaturas = JsonConvert.DeserializeObject<List<CarreraBackend.Entidades.Asignatura>>(resultado);
            foreach(CarreraBackend.Entidades.Asignatura asignatura in asignaturas)
            {
                dgvConsultar_Asignatura.Rows.Add(new object[] { asignatura.Id, asignatura.Nombre });

            }
        }
        private async Task<string> BorrarAsignaturaAsync(int id)
        {
            string url = "https://localhost:5001/api/Asignatura/" + id;
            var resultado = await cliente.DeleteAsync(url);
            return resultado;
        }

        private async void dgvConsultar_Asignatura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //EDITAR
            if(e.ColumnIndex == 2)
            {
                int id = (int)dgvConsultar_Asignatura.Rows[e.RowIndex].Cells[0].Value;
                AltaAsignatura frmNueva_Asignatura = new AltaAsignatura(Accion.UPDATE, id);
                frmNueva_Asignatura.ShowDialog();
                CargarDgv();
            }
            //BORRAR
            else if(e.ColumnIndex == 3) 
            {
                int id = (int)dgvConsultar_Asignatura.Rows[e.RowIndex].Cells[0].Value;
                var result = (await BorrarAsignaturaAsync(id));
                if ( result == "true")
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
                this.Dispose();
        }
    }
}
