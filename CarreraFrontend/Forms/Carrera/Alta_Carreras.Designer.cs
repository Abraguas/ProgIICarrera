
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboMateria = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cboTitulo = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom_Carrera = new System.Windows.Forms.TextBox();
            this.dgvAsignaturas = new System.Windows.Forms.DataGridView();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Asignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cuatrimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_quitar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.nudCuatrimestre = new System.Windows.Forms.NumericUpDown();
            this.nudAñosCursado = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar_Asig = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCuatrimestre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAñosCursado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCarreraNro
            // 
            this.lblCarreraNro.AutoSize = true;
            this.lblCarreraNro.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCarreraNro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCarreraNro.Image = ((System.Drawing.Image)(resources.GetObject("lblCarreraNro.Image")));
            this.lblCarreraNro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCarreraNro.Location = new System.Drawing.Point(16, 17);
            this.lblCarreraNro.Name = "lblCarreraNro";
            this.lblCarreraNro.Size = new System.Drawing.Size(191, 32);
            this.lblCarreraNro.TabIndex = 0;
            this.lblCarreraNro.Text = "    Carrera Nro: \r\n";
            this.lblCarreraNro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCarreraNro.Click += new System.EventHandler(this.lblCarreraNro_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lblCarreraNro);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 66);
            this.panel1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(342, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 141);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // cboMateria
            // 
            this.cboMateria.FormattingEnabled = true;
            this.cboMateria.Location = new System.Drawing.Point(168, 219);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Size = new System.Drawing.Size(141, 23);
            this.cboMateria.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(106, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 29;
            this.label5.Text = "Materia";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(625, 517);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 26);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cboTitulo
            // 
            this.cboTitulo.FormattingEnabled = true;
            this.cboTitulo.Items.AddRange(new object[] {
            "Tecnicatura"});
            this.cboTitulo.Location = new System.Drawing.Point(168, 134);
            this.cboTitulo.Name = "cboTitulo";
            this.cboTitulo.Size = new System.Drawing.Size(141, 23);
            this.cboTitulo.TabIndex = 28;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAceptar.Location = new System.Drawing.Point(521, 517);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(82, 26);
            this.btnAceptar.TabIndex = 24;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(119, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "Titulo";
            // 
            // txtNom_Carrera
            // 
            this.txtNom_Carrera.Location = new System.Drawing.Point(168, 107);
            this.txtNom_Carrera.Name = "txtNom_Carrera";
            this.txtNom_Carrera.Size = new System.Drawing.Size(141, 23);
            this.txtNom_Carrera.TabIndex = 26;
            // 
            // dgvAsignaturas
            // 
            this.dgvAsignaturas.AllowUserToAddRows = false;
            this.dgvAsignaturas.AllowUserToDeleteRows = false;
            this.dgvAsignaturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAsignaturas.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvAsignaturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.col_año,
            this.col_cuatrimestre,
            this.btn_quitar});
            this.dgvAsignaturas.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAsignaturas.Location = new System.Drawing.Point(12, 278);
            this.dgvAsignaturas.Name = "dgvAsignaturas";
            this.dgvAsignaturas.ReadOnly = true;
            this.dgvAsignaturas.RowHeadersWidth = 47;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAsignaturas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAsignaturas.RowTemplate.Height = 25;
            this.dgvAsignaturas.Size = new System.Drawing.Size(696, 218);
            this.dgvAsignaturas.TabIndex = 23;
            this.dgvAsignaturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsignatura_Quitar_CellContentClick);
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
            // col_año
            // 
            this.col_año.HeaderText = "Año de cursado";
            this.col_año.Name = "col_año";
            this.col_año.ReadOnly = true;
            // 
            // col_cuatrimestre
            // 
            this.col_cuatrimestre.HeaderText = "Numero de Cuatrimestre";
            this.col_cuatrimestre.Name = "col_cuatrimestre";
            this.col_cuatrimestre.ReadOnly = true;
            // 
            // btn_quitar
            // 
            this.btn_quitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_quitar.HeaderText = "Quitar";
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.ReadOnly = true;
            this.btn_quitar.Text = "X";
            // 
            // nudCuatrimestre
            // 
            this.nudCuatrimestre.Location = new System.Drawing.Point(168, 191);
            this.nudCuatrimestre.Name = "nudCuatrimestre";
            this.nudCuatrimestre.Size = new System.Drawing.Size(141, 23);
            this.nudCuatrimestre.TabIndex = 22;
            this.nudCuatrimestre.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudAñosCursado
            // 
            this.nudAñosCursado.Location = new System.Drawing.Point(168, 162);
            this.nudAñosCursado.Name = "nudAñosCursado";
            this.nudAñosCursado.Size = new System.Drawing.Size(141, 23);
            this.nudAñosCursado.TabIndex = 21;
            this.nudAñosCursado.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(74, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Cuatrimestre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(48, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Años de Cursado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(21, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nombre de la Carrera";
            // 
            // btnAgregar_Asig
            // 
            this.btnAgregar_Asig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregar_Asig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar_Asig.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar_Asig.Location = new System.Drawing.Point(21, 246);
            this.btnAgregar_Asig.Name = "btnAgregar_Asig";
            this.btnAgregar_Asig.Size = new System.Drawing.Size(82, 26);
            this.btnAgregar_Asig.TabIndex = 32;
            this.btnAgregar_Asig.Text = "Agregar";
            this.btnAgregar_Asig.UseVisualStyleBackColor = false;
            this.btnAgregar_Asig.Click += new System.EventHandler(this.btnAgregar_Asig_Click);
            // 
            // Alta_Carreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(70)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(713, 556);
            this.Controls.Add(this.btnAgregar_Asig);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cboMateria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cboTitulo);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNom_Carrera);
            this.Controls.Add(this.dgvAsignaturas);
            this.Controls.Add(this.nudCuatrimestre);
            this.Controls.Add(this.nudAñosCursado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Alta_Carreras";
            this.Text = "Nueva Carrera";
            this.Load += new System.EventHandler(this.Alta_Carreras_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCuatrimestre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAñosCursado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarreraNro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboMateria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboTitulo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNom_Carrera;
        private System.Windows.Forms.DataGridView dgvAsignaturas;
        private System.Windows.Forms.NumericUpDown nudCuatrimestre;
        private System.Windows.Forms.NumericUpDown nudAñosCursado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar_Asig;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Asignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_año;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cuatrimestre;
        private System.Windows.Forms.DataGridViewButtonColumn btn_quitar;
    }
}