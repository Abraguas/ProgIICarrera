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
using Carr = CarreraBackend.Entidades.Carrera;
using Asign = CarreraBackend.Entidades.Asignatura;
using Detal = CarreraBackend.Entidades.DetalleCarrera;

namespace CarreraFrontend.Forms
{
    public enum Accion
    {
        CREATE,
        READ,
        UPDATE,
        DELETE
    }
    //"https://localhost:44307/" (mati)

    public partial class Alta_Carreras : Form
    {
        private Accion modo;
        private ClienteSingleton cliente;
        private Carr oCarrera;
        private Detal oDetalle;

        public Alta_Carreras(Accion modo, int nro)
        {
            InitializeComponent();
            oCarrera = new Carr();
            oCarrera.Id = nro;
            cliente = ClienteSingleton.GetInstancia();

            this.modo = modo;
            if (modo.Equals(Accion.UPDATE))
            {

            }
        }

        private void Alta_Carreras_Load(object sender, EventArgs e)
        {
            Iniciar();

        }
        private async void Iniciar()
        {
            if (modo.Equals(Accion.CREATE))
            {
                AsignarNumeroCarrreraAsync();
            }
            if (modo.Equals(Accion.UPDATE))
            {
                CargarCarrera();
                lblCarreraNro.Text = "    Carrera Nro: " + oCarrera.Id;
            }
            await CargarCombo();

        }

        private async void CargarCarrera()
        {

            string url = "https://localhost:5001/api/Carreras/" + oCarrera.Id;//4307(mati),5001(franco)
            var resultado = await cliente.GetAsync(url);
            oCarrera = JsonConvert.DeserializeObject<Carr>(resultado);

            txtNom_Carrera.Text = oCarrera.Nombre;
            cboTitulo.SelectedItem = oCarrera.Titulo;
            CargarDetalles();
        }
        private void CargarDetalles()
        {
            dgvAsignaturas.Rows.Clear();
            foreach (Detal oDetalle in oCarrera.Detalles)
            {
                dgvAsignaturas.Rows.Add(new string[]
                                        {
                                            oDetalle.Materia.Id.ToString(),
                                            oDetalle.Id.ToString(),
                                            oDetalle.Materia.Nombre,
                                            oDetalle.AnioCursado.ToString(),
                                            oDetalle.Cuatrimestre.ToString()
                                        });
            }
        }

        //BOTONES
        private async void btnAgregar_Asig_Click(object sender, EventArgs e)
        {
            if (ExisteProductoEnGrilla(cboMateria.Text))
            {
                MessageBox.Show("La asignatura ya fue registrada!", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            oDetalle = new Detal();
            oDetalle.Materia = (Asign)cboMateria.SelectedItem;
            oDetalle.AnioCursado = (int)nudAñosCursado.Value;
            oDetalle.Cuatrimestre = (int)nudCuatrimestre.Value;
            oCarrera.AgregarDetalle(oDetalle);
            if (modo == Accion.UPDATE)
            {
                await GrabarDetalle(oDetalle);
                CargarCarrera();

            }
            else if (modo == Accion.CREATE)
            {
                dgvAsignaturas.Rows.Add(new string[]
                                           {
                                            oDetalle.Materia.Id.ToString(),
                                            oDetalle.Id.ToString(),
                                            oDetalle.Materia.Nombre,
                                            oDetalle.AnioCursado.ToString(),
                                            oDetalle.Cuatrimestre.ToString()
                                           });
            }





        }

        private async Task<bool> GrabarDetalle(Detal oDetalle)
        {
            string data = JsonConvert.SerializeObject(oDetalle);
            string url = "https://localhost:5001/api/Detalles/" + oCarrera.Id;

            if ((await cliente.PostAsync(url, data)) == "Ok")
            {
                MessageBox.Show("Asignatura añadida con éxito!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;

            }
            else
            {
                MessageBox.Show("Ha ocurrido un inconveniente al registrar la nueva Asignatura!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private async void BorrarDetalle(int id)
        {
            string url = "https://localhost:5001/api/Detalles/" + id;

            if ((await cliente.DeleteAsync(url)) == "true")
            {
                MessageBox.Show("Asignatura eliminada con éxito!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarCarrera();
                CargarDetalles();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un inconveniente al eliminar la Asignatura!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNom_Carrera.Text) || string.IsNullOrEmpty(cboMateria.Text))
            {
                MessageBox.Show("Los campos: Nombre de carrera y Materia son obligatorios!", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            oCarrera.Nombre = txtNom_Carrera.Text;
            oCarrera.Titulo = Convert.ToString(cboTitulo.SelectedItem);
            string data = JsonConvert.SerializeObject(oCarrera);


            string url = "https://localhost:5001/api/Carreras";

            if (modo == Accion.CREATE)
            {
                if ((await cliente.PostAsync(url, data)) == "Ok")
                {
                    MessageBox.Show("Carrera registrada con éxito!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    AsignarNumeroCarrreraAsync();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un inconveniente al registrar la Carrera!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (modo == Accion.UPDATE)
            {
                if ((await cliente.PutAsync(url, data)) == "Ok")
                {
                    MessageBox.Show("Carrera actualizada con éxito!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un inconveniente al actualizar la Carrera!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            string url = "https://localhost:5001/api/Asignatura/Asignatura";
            var resultado = await cliente.GetAsync(url);
            List<Asign> lst = JsonConvert.DeserializeObject<List<Asign>>(resultado);
            cboMateria.DataSource = lst;
            cboMateria.ValueMember = "Id";
            cboMateria.DisplayMember = "Nombre";
        }
        private void LimpiarCampos()
        {
            txtNom_Carrera.Text = string.Empty;
            txtNom_Carrera.Focus();
            cboTitulo.SelectedItem = string.Empty;
            nudAñosCursado.Value = 0;
            nudCuatrimestre.Value = 0;
            dgvAsignaturas.Rows.Clear();
        }

        private async void AsignarNumeroCarrreraAsync()
        {
            string url = "https://localhost:5001/api/Carreras/ProximoId";
            var resultado = await cliente.GetAsync(url);
            int id = JsonConvert.DeserializeObject<int>(resultado);
            oCarrera.Id = id;
            lblCarreraNro.Text = "    Carrera Nro: " + id;

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
        private void dgvAsignatura_Quitar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                if(modo == Accion.CREATE)
                {
                    dgvAsignaturas.Rows.RemoveAt(e.RowIndex);                  
                    MessageBox.Show("Se borró el detalle con exito!!", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (modo == Accion.UPDATE)
                {
                    int id = Convert.ToInt32(dgvAsignaturas.CurrentRow.Cells[1].Value);
                    if(id == 0)
                    {
                        MessageBox.Show("No puede borrar una asignatura que insertó durante la edicion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        BorrarDetalle(id);
                    }


                    
                }
            }

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
