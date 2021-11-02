
namespace CarreraFrontend.Forms
{
    partial class Alta_Carreras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alta_Carreras));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCarreraNro = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudAñosCursado = new System.Windows.Forms.NumericUpDown();
            this.nudCuatrimestre = new System.Windows.Forms.NumericUpDown();
            this.dgvAsignaturas = new System.Windows.Forms.DataGridView();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Asignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cuatrimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_quitar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtNom_Carrera = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTitulo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboMateria = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudAñosCursado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCuatrimestre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaturas)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCarreraNro
            // 
            this.lblCarreraNro.AutoSize = true;
            this.lblCarreraNro.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCarreraNro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCarreraNro.Image = ((System.Drawing.Image)(resources.GetObject("lblCarreraNro.Image")));
            this.lblCarreraNro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCarreraNro.Location = new System.Drawing.Point(12, 12);
            this.lblCarreraNro.Name = "lblCarreraNro";
            this.lblCarreraNro.Size = new System.Drawing.Size(163, 25);
            this.lblCarreraNro.TabIndex = 0;
            this.lblCarreraNro.Text = "       Carrera Nro: \r\n";
            this.lblCarreraNro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCarreraNro.Click += new System.EventHandler(this.lblCarreraNro_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(43, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de la Carrera";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(66, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Años de Cursado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(88, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cuatrimestre";
            // 
            // nudAñosCursado
            // 
            this.nudAñosCursado.Location = new System.Drawing.Point(169, 64);
            this.nudAñosCursado.Name = "nudAñosCursado";
            this.nudAñosCursado.Size = new System.Drawing.Size(100, 23);
            this.nudAñosCursado.TabIndex = 5;
            this.nudAñosCursado.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudCuatrimestre
            // 
            this.nudCuatrimestre.Location = new System.Drawing.Point(169, 95);
            this.nudCuatrimestre.Name = "nudCuatrimestre";
            this.nudCuatrimestre.Size = new System.Drawing.Size(100, 23);
            this.nudCuatrimestre.TabIndex = 6;
            this.nudCuatrimestre.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dgvAsignaturas
            // 
            this.dgvAsignaturas.AllowUserToAddRows = false;
            this.dgvAsignaturas.AllowUserToDeleteRows = false;
            this.dgvAsignaturas.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvAsignaturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAsignaturas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvAsignaturas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(136)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAsignaturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAsignaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsignaturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.col_Asignatura,
            this.col_cuatrimestre,
            this.col_año,
            this.btn_quitar});
            this.dgvAsignaturas.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAsignaturas.Location = new System.Drawing.Point(17, 158);
            this.dgvAsignaturas.Name = "dgvAsignaturas";
            this.dgvAsignaturas.ReadOnly = true;
            this.dgvAsignaturas.RowHeadersWidth = 47;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAsignaturas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAsignaturas.RowTemplate.Height = 25;
            this.dgvAsignaturas.Size = new System.Drawing.Size(597, 218);
            this.dgvAsignaturas.TabIndex = 8;
            // 
            // col_id
            // 
            this.col_id.HeaderText = "Id";
            this.col_id.Name = "col_id";
            this.col_id.ReadOnly = true;
            this.col_id.Visible = false;
            // 
            // col_Asignatura
            // 
            this.col_Asignatura.HeaderText = "Asignatura";
            this.col_Asignatura.Name = "col_Asignatura";
            this.col_Asignatura.ReadOnly = true;
            // 
            // col_cuatrimestre
            // 
            this.col_cuatrimestre.HeaderText = "Numero de Cuatrimestre";
            this.col_cuatrimestre.Name = "col_cuatrimestre";
            this.col_cuatrimestre.ReadOnly = true;
            this.col_cuatrimestre.Width = 200;
            // 
            // col_año
            // 
            this.col_año.HeaderText = "Año de cursado";
            this.col_año.Name = "col_año";
            this.col_año.ReadOnly = true;
            this.col_año.Width = 150;
            // 
            // btn_quitar
            // 
            this.btn_quitar.HeaderText = "Quitar";
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.ReadOnly = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAceptar.Location = new System.Drawing.Point(430, 385);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(82, 26);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(532, 385);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 26);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // txtNom_Carrera
            // 
            this.txtNom_Carrera.Location = new System.Drawing.Point(169, 7);
            this.txtNom_Carrera.Name = "txtNom_Carrera";
            this.txtNom_Carrera.Size = new System.Drawing.Size(100, 23);
            this.txtNom_Carrera.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(126, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Titulo";
            // 
            // cboTitulo
            // 
            this.cboTitulo.FormattingEnabled = true;
            this.cboTitulo.Location = new System.Drawing.Point(169, 35);
            this.cboTitulo.Name = "cboTitulo";
            this.cboTitulo.Size = new System.Drawing.Size(100, 23);
            this.cboTitulo.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(116, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Materia";
            // 
            // cboMateria
            // 
            this.cboMateria.FormattingEnabled = true;
            this.cboMateria.Location = new System.Drawing.Point(169, 126);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Size = new System.Drawing.Size(100, 23);
            this.cboMateria.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lblCarreraNro);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 49);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(70)))), ((int)(((byte)(101)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.cboMateria);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.cboTitulo);
            this.panel2.Controls.Add(this.btnAceptar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtNom_Carrera);
            this.panel2.Controls.Add(this.dgvAsignaturas);
            this.panel2.Controls.Add(this.nudCuatrimestre);
            this.panel2.Controls.Add(this.nudAñosCursado);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(629, 419);
            this.panel2.TabIndex = 17;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(322, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 92);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Alta_Carreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 467);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Alta_Carreras";
            this.Text = "Nueva Carrera";
            this.Load += new System.EventHandler(this.Alta_Carreras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAñosCursado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCuatrimestre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaturas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCarreraNro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudAñosCursado;
        private System.Windows.Forms.NumericUpDown nudCuatrimestre;
        private System.Windows.Forms.DataGridView dgvAsignaturas;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtNom_Carrera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTitulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Asignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cuatrimestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_año;
        private System.Windows.Forms.DataGridViewButtonColumn btn_quitar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}