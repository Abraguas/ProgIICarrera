
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
            this.btn_CancelarAsig = new System.Windows.Forms.Button();
            this.btnAceptarAsig = new System.Windows.Forms.Button();
            this.txtNom_Asignatura = new System.Windows.Forms.TextBox();
            this.lblNom_Asignatura = new System.Windows.Forms.Label();
            this.lblAsignaturaNro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_CancelarAsig
            // 
            this.btn_CancelarAsig.Location = new System.Drawing.Point(291, 250);
            this.btn_CancelarAsig.Name = "btn_CancelarAsig";
            this.btn_CancelarAsig.Size = new System.Drawing.Size(75, 23);
            this.btn_CancelarAsig.TabIndex = 21;
            this.btn_CancelarAsig.Text = "Cancelar";
            this.btn_CancelarAsig.UseVisualStyleBackColor = true;
            // 
            // btnAceptarAsig
            // 
            this.btnAceptarAsig.Location = new System.Drawing.Point(291, 205);
            this.btnAceptarAsig.Name = "btnAceptarAsig";
            this.btnAceptarAsig.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarAsig.TabIndex = 20;
            this.btnAceptarAsig.Text = "Aceptar";
            this.btnAceptarAsig.UseVisualStyleBackColor = true;
            // 
            // txtNom_Asignatura
            // 
            this.txtNom_Asignatura.Location = new System.Drawing.Point(157, 58);
            this.txtNom_Asignatura.Name = "txtNom_Asignatura";
            this.txtNom_Asignatura.Size = new System.Drawing.Size(108, 23);
            this.txtNom_Asignatura.TabIndex = 19;
            // 
            // lblNom_Asignatura
            // 
            this.lblNom_Asignatura.AutoSize = true;
            this.lblNom_Asignatura.Location = new System.Drawing.Point(12, 61);
            this.lblNom_Asignatura.Name = "lblNom_Asignatura";
            this.lblNom_Asignatura.Size = new System.Drawing.Size(139, 15);
            this.lblNom_Asignatura.TabIndex = 18;
            this.lblNom_Asignatura.Text = "Nombre de la Asignatura";
            // 
            // lblAsignaturaNro
            // 
            this.lblAsignaturaNro.AutoSize = true;
            this.lblAsignaturaNro.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAsignaturaNro.Location = new System.Drawing.Point(12, 9);
            this.lblAsignaturaNro.Name = "lblAsignaturaNro";
            this.lblAsignaturaNro.Size = new System.Drawing.Size(159, 25);
            this.lblAsignaturaNro.TabIndex = 17;
            this.lblAsignaturaNro.Text = "Asignatura Nro: ";
            // 
            // AltaAsignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 284);
            this.Controls.Add(this.btn_CancelarAsig);
            this.Controls.Add(this.btnAceptarAsig);
            this.Controls.Add(this.txtNom_Asignatura);
            this.Controls.Add(this.lblNom_Asignatura);
            this.Controls.Add(this.lblAsignaturaNro);
            this.Name = "AltaAsignatura";
            this.Text = "AltaAsignatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CancelarAsig;
        private System.Windows.Forms.Button btnAceptarAsig;
        private System.Windows.Forms.TextBox txtNom_Asignatura;
        private System.Windows.Forms.Label lblNom_Asignatura;
        private System.Windows.Forms.Label lblAsignaturaNro;
    }
}