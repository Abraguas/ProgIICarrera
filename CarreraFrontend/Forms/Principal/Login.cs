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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        string usuario = "Grupo17";
        string contraseña = "utn2021";
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == usuario && txtContraseña.Text == contraseña)
            {
                this.Hide();
                FrmPrincipal principal = new FrmPrincipal();
                principal.Show();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrecto, Porfavor vuelva a intertarlo", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }







        private void btnAceptar1_Click(object sender, EventArgs e)
        {
        //    if (txtUsuario.Text.Contains("Grupo16") && txtUsuario.Text.Contains("utn2021"))
        //    {
        //        Application.Run(new FrmPrincipal());
         }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        //}
    }
}
