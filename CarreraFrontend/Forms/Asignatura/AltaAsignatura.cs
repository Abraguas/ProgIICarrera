﻿using CarreraBackend.Servicios.Interfaces;
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
using Asignat = CarreraBackend.Entidades.Asignatura;


namespace CarreraFrontend.Forms.Asignatura
{

    public partial class AltaAsignatura : Form
    {
        private ClienteSingleton cliente;
        private Accion modo;
        private Asignat asignatura;
        public AltaAsignatura(Accion modo, int id)
        {
            InitializeComponent();
            asignatura = new Asignat();
            cliente = ClienteSingleton.GetInstancia();
            //servicio_asignatura = new AsignaturaService().Grabar();
            this.modo = modo;
            if(modo == Accion.UPDATE)
            {
                asignatura.Id = id;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void btnAceptarAsig_Click(object sender, EventArgs e)
        {
            if(modo == Accion.CREATE)
            {
                asignatura.Id = 0;
                asignatura.Nombre = txtNom_Asignatura.Text;
                await cliente.PostAsync("https://localhost:5001/api/Asignatura", JsonConvert.SerializeObject(asignatura));
                MessageBox.Show("Se grabó la asignatura con exito!!", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNom_Asignatura.Clear();
            }
            else if (modo == Accion.UPDATE)
            {
                asignatura.Nombre = txtNom_Asignatura.Text;
                await cliente.PutAsync("https://localhost:5001/api/Asignatura", JsonConvert.SerializeObject(asignatura));
                MessageBox.Show("Se actualizó la asignatura con exito!!", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();

            }

        }

        private void AltaAsignatura_Load(object sender, EventArgs e)
        {

        }

        private void btn_CancelarAsig_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
