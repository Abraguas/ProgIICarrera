
namespace CarreraFrontend.Forms.Asignatura
{
    partial class AltaAsignatura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaAsignatura));
            this.btn_CancelarAsig = new System.Windows.Forms.Button();
            this.btnAceptarAsig = new System.Windows.Forms.Button();
            this.txtNom_Asignatura = new System.Windows.Forms.TextBox();
            this.lblNom_Asignatura = new System.Windows.Forms.Label();
            this.lblAsignaturaNro = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_CancelarAsig
            // 
            this.btn_CancelarAsig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_CancelarAsig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelarAsig.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_CancelarAsig.Location = new System.Drawing.Point(247, 133);
            this.btn_CancelarAsig.Name = "btn_CancelarAsig";
            this.btn_CancelarAsig.Size = new System.Drawing.Size(94, 33);
            this.btn_CancelarAsig.TabIndex = 21;
            this.btn_CancelarAsig.Text = "Cancelar";
            this.btn_CancelarAsig.UseVisualStyleBackColor = false;
            // 
            // btnAceptarAsig
            // 
            this.btnAceptarAsig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAceptarAsig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarAsig.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAceptarAsig.Location = new System.Drawing.Point(132, 133);
            this.btnAceptarAsig.Name = "btnAceptarAsig";
            this.btnAceptarAsig.Size = new System.Drawing.Size(97, 33);
            this.btnAceptarAsig.TabIndex = 20;
            this.btnAceptarAsig.Text = "Aceptar";
            this.btnAceptarAsig.UseVisualStyleBackColor = false;
            this.btnAceptarAsig.Click += new System.EventHandler(this.btnAceptarAsig_Click);
            // 
            // txtNom_Asignatura
            // 
            this.txtNom_Asignatura.Location = new System.Drawing.Point(253, 66);
            this.txtNom_Asignatura.Name = "txtNom_Asignatura";
            this.txtNom_Asignatura.Size = new System.Drawing.Size(121, 23);
            this.txtNom_Asignatura.TabIndex = 19;
            // 
            // lblNom_Asignatura
            // 
            this.lblNom_Asignatura.AutoSize = true;
            this.lblNom_Asignatura.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNom_Asignatura.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNom_Asignatura.Location = new System.Drawing.Point(85, 67);
            this.lblNom_Asignatura.Name = "lblNom_Asignatura";
            this.lblNom_Asignatura.Size = new System.Drawing.Size(162, 19);
            this.lblNom_Asignatura.TabIndex = 18;
            this.lblNom_Asignatura.Text = "Nombre de la Asignatura";
            // 
            // lblAsignaturaNro
            // 
            this.lblAsignaturaNro.AutoSize = true;
            this.lblAsignaturaNro.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAsignaturaNro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAsignaturaNro.Image = ((System.Drawing.Image)(resources.GetObject("lblAsignaturaNro.Image")));
            this.lblAsignaturaNro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAsignaturaNro.Location = new System.Drawing.Point(14, 9);
            this.lblAsignaturaNro.Name = "lblAsignaturaNro";
            this.lblAsignaturaNro.Size = new System.Drawing.Size(225, 30);
            this.lblAsignaturaNro.TabIndex = 17;
            this.lblAsignaturaNro.Text = "       Asignatura Nro: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lblAsignaturaNro);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 48);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(149)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btn_CancelarAsig);
            this.panel2.Controls.Add(this.btnAceptarAsig);
            this.panel2.Controls.Add(this.txtNom_Asignatura);
            this.panel2.Controls.Add(this.lblNom_Asignatura);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(-2, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(485, 399);
            this.panel2.TabIndex = 23;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(48, 268);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(382, 118);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // AltaAsignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 444);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AltaAsignatura";
            this.Text = "AltaAsignatura";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CancelarAsig;
        private System.Windows.Forms.Button btnAceptarAsig;
        private System.Windows.Forms.TextBox txtNom_Asignatura;
        private System.Windows.Forms.Label lblNom_Asignatura;
        private System.Windows.Forms.Label lblAsignaturaNro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}