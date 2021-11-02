
namespace CarreraFrontend.Forms.Carrera
{
    partial class ConsultarCarrera
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarCarrera));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar_Carrera = new System.Windows.Forms.Button();
            this.btnEditar_Carrera = new System.Windows.Forms.Button();
            this.gbResultados = new System.Windows.Forms.GroupBox();
            this.dgvConsultar_Carrera = new System.Windows.Forms.DataGridView();
            this.col_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultar_Carrera)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.Location = new System.Drawing.Point(659, 278);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 27);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "S&alir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar_Carrera
            // 
            this.btnEliminar_Carrera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminar_Carrera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar_Carrera.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar_Carrera.Location = new System.Drawing.Point(109, 278);
            this.btnEliminar_Carrera.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminar_Carrera.Name = "btnEliminar_Carrera";
            this.btnEliminar_Carrera.Size = new System.Drawing.Size(88, 27);
            this.btnEliminar_Carrera.TabIndex = 8;
            this.btnEliminar_Carrera.Text = "Eliminar";
            this.btnEliminar_Carrera.UseVisualStyleBackColor = false;
            // 
            // btnEditar_Carrera
            // 
            this.btnEditar_Carrera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditar_Carrera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar_Carrera.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditar_Carrera.Location = new System.Drawing.Point(13, 278);
            this.btnEditar_Carrera.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditar_Carrera.Name = "btnEditar_Carrera";
            this.btnEditar_Carrera.Size = new System.Drawing.Size(88, 27);
            this.btnEditar_Carrera.TabIndex = 7;
            this.btnEditar_Carrera.Text = "Editar";
            this.btnEditar_Carrera.UseVisualStyleBackColor = false;
            this.btnEditar_Carrera.Click += new System.EventHandler(this.btnEditar_Carrera_Click);
            // 
            // gbResultados
            // 
            this.gbResultados.Controls.Add(this.dgvConsultar_Carrera);
            this.gbResultados.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbResultados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbResultados.Location = new System.Drawing.Point(13, 21);
            this.gbResultados.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbResultados.Name = "gbResultados";
            this.gbResultados.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbResultados.Size = new System.Drawing.Size(734, 236);
            this.gbResultados.TabIndex = 6;
            this.gbResultados.TabStop = false;
            this.gbResultados.Text = "Resultados";
            // 
            // dgvConsultar_Carrera
            // 
            this.dgvConsultar_Carrera.AllowUserToAddRows = false;
            this.dgvConsultar_Carrera.AllowUserToDeleteRows = false;
            this.dgvConsultar_Carrera.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultar_Carrera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultar_Carrera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Id,
            this.col_Carrera,
            this.col_titulo,
            this.col_editar,
            this.col_borrar});
            this.dgvConsultar_Carrera.Location = new System.Drawing.Point(8, 24);
            this.dgvConsultar_Carrera.Name = "dgvConsultar_Carrera";
            this.dgvConsultar_Carrera.ReadOnly = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvConsultar_Carrera.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsultar_Carrera.RowTemplate.Height = 25;
            this.dgvConsultar_Carrera.Size = new System.Drawing.Size(719, 204);
            this.dgvConsultar_Carrera.TabIndex = 0;
            this.dgvConsultar_Carrera.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultar_Carrera_CellContentClick);
            // 
            // col_Id
            // 
            this.col_Id.HeaderText = "Id";
            this.col_Id.Name = "col_Id";
            this.col_Id.ReadOnly = true;
            this.col_Id.Visible = false;
            // 
            // col_Carrera
            // 
            this.col_Carrera.HeaderText = "Carrera";
            this.col_Carrera.Name = "col_Carrera";
            this.col_Carrera.ReadOnly = true;
            // 
            // col_titulo
            // 
            this.col_titulo.HeaderText = "Titulo";
            this.col_titulo.Name = "col_titulo";
            this.col_titulo.ReadOnly = true;
            // 
            // col_editar
            // 
            this.col_editar.HeaderText = "Editar";
            this.col_editar.Name = "col_editar";
            this.col_editar.ReadOnly = true;
            this.col_editar.Text = "Editar Carrera";
            this.col_editar.UseColumnTextForButtonValue = true;
            // 
            // col_borrar
            // 
            this.col_borrar.HeaderText = "Borrar";
            this.col_borrar.Name = "col_borrar";
            this.col_borrar.ReadOnly = true;
            this.col_borrar.Text = "Borrar Carrera";
            this.col_borrar.UseColumnTextForButtonValue = true;
            // 
            // ConsultarCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(70)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(760, 465);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar_Carrera);
            this.Controls.Add(this.btnEditar_Carrera);
            this.Controls.Add(this.gbResultados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConsultarCarrera";
            this.Text = "Consultar Carrera";
            this.Load += new System.EventHandler(this.ConsultarCarrera_Load);
            this.gbResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultar_Carrera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar_Carrera;
        private System.Windows.Forms.Button btnEditar_Carrera;
        private System.Windows.Forms.GroupBox gbResultados;
        private System.Windows.Forms.DataGridView dgvConsultar_Carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_titulo;
        private System.Windows.Forms.DataGridViewButtonColumn col_editar;
        private System.Windows.Forms.DataGridViewButtonColumn col_borrar;
    }
}