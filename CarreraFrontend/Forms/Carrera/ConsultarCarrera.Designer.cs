
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
            this.col_Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_años = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cuatrimestres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.cboBuscarCarrera = new System.Windows.Forms.ComboBox();
            this.chkBaja = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConsultar_Carrera = new System.Windows.Forms.Button();
            this.gbResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultar_Carrera)).BeginInit();
            this.gbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.Location = new System.Drawing.Point(543, 324);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 27);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "S&alir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnEliminar_Carrera
            // 
            this.btnEliminar_Carrera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminar_Carrera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar_Carrera.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar_Carrera.Location = new System.Drawing.Point(120, 325);
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
            this.btnEditar_Carrera.Location = new System.Drawing.Point(13, 325);
            this.btnEditar_Carrera.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditar_Carrera.Name = "btnEditar_Carrera";
            this.btnEditar_Carrera.Size = new System.Drawing.Size(88, 27);
            this.btnEditar_Carrera.TabIndex = 7;
            this.btnEditar_Carrera.Text = "Editar";
            this.btnEditar_Carrera.UseVisualStyleBackColor = false;
            // 
            // gbResultados
            // 
            this.gbResultados.Controls.Add(this.dgvConsultar_Carrera);
            this.gbResultados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbResultados.Location = new System.Drawing.Point(13, 139);
            this.gbResultados.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbResultados.Name = "gbResultados";
            this.gbResultados.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbResultados.Size = new System.Drawing.Size(618, 179);
            this.gbResultados.TabIndex = 6;
            this.gbResultados.TabStop = false;
            this.gbResultados.Text = "Resultados";
            // 
            // dgvConsultar_Carrera
            // 
            this.dgvConsultar_Carrera.AllowUserToAddRows = false;
            this.dgvConsultar_Carrera.AllowUserToDeleteRows = false;
            this.dgvConsultar_Carrera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultar_Carrera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Carrera,
            this.col_años,
            this.col_cuatrimestres});
            this.dgvConsultar_Carrera.Location = new System.Drawing.Point(8, 23);
            this.dgvConsultar_Carrera.Name = "dgvConsultar_Carrera";
            this.dgvConsultar_Carrera.ReadOnly = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvConsultar_Carrera.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsultar_Carrera.RowTemplate.Height = 25;
            this.dgvConsultar_Carrera.Size = new System.Drawing.Size(603, 150);
            this.dgvConsultar_Carrera.TabIndex = 0;
            // 
            // col_Carrera
            // 
            this.col_Carrera.HeaderText = "Carrera";
            this.col_Carrera.Name = "col_Carrera";
            this.col_Carrera.ReadOnly = true;
            this.col_Carrera.Width = 200;
            // 
            // col_años
            // 
            this.col_años.HeaderText = "Cantidad de Años";
            this.col_años.Name = "col_años";
            this.col_años.ReadOnly = true;
            this.col_años.Width = 200;
            // 
            // col_cuatrimestres
            // 
            this.col_cuatrimestres.HeaderText = "Cantidad de Cuatrimestres";
            this.col_cuatrimestres.Name = "col_cuatrimestres";
            this.col_cuatrimestres.ReadOnly = true;
            this.col_cuatrimestres.Width = 200;
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.cboBuscarCarrera);
            this.gbFiltros.Controls.Add(this.chkBaja);
            this.gbFiltros.Controls.Add(this.label3);
            this.gbFiltros.Controls.Add(this.btnConsultar_Carrera);
            this.gbFiltros.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbFiltros.Location = new System.Drawing.Point(13, 12);
            this.gbFiltros.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbFiltros.Size = new System.Drawing.Size(451, 121);
            this.gbFiltros.TabIndex = 5;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Criterios de búsqueda";
            // 
            // cboBuscarCarrera
            // 
            this.cboBuscarCarrera.FormattingEnabled = true;
            this.cboBuscarCarrera.Location = new System.Drawing.Point(94, 29);
            this.cboBuscarCarrera.Name = "cboBuscarCarrera";
            this.cboBuscarCarrera.Size = new System.Drawing.Size(195, 23);
            this.cboBuscarCarrera.TabIndex = 8;
            // 
            // chkBaja
            // 
            this.chkBaja.AutoSize = true;
            this.chkBaja.Location = new System.Drawing.Point(40, 58);
            this.chkBaja.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkBaja.Name = "chkBaja";
            this.chkBaja.Size = new System.Drawing.Size(155, 19);
            this.chkBaja.TabIndex = 7;
            this.chkBaja.Text = "Incluir con datos de baja";
            this.chkBaja.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Carrera:";
            // 
            // btnConsultar_Carrera
            // 
            this.btnConsultar_Carrera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConsultar_Carrera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar_Carrera.Location = new System.Drawing.Point(334, 27);
            this.btnConsultar_Carrera.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConsultar_Carrera.Name = "btnConsultar_Carrera";
            this.btnConsultar_Carrera.Size = new System.Drawing.Size(88, 27);
            this.btnConsultar_Carrera.TabIndex = 0;
            this.btnConsultar_Carrera.Text = "Consultar";
            this.btnConsultar_Carrera.UseVisualStyleBackColor = false;
            // 
            // ConsultarCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(70)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(642, 364);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar_Carrera);
            this.Controls.Add(this.btnEditar_Carrera);
            this.Controls.Add(this.gbResultados);
            this.Controls.Add(this.gbFiltros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultarCarrera";
            this.Text = "Consultar Carrera";
            this.gbResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultar_Carrera)).EndInit();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar_Carrera;
        private System.Windows.Forms.Button btnEditar_Carrera;
        private System.Windows.Forms.GroupBox gbResultados;
        private System.Windows.Forms.DataGridView dgvConsultar_Carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_años;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cuatrimestres;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.ComboBox cboBuscarCarrera;
        private System.Windows.Forms.CheckBox chkBaja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConsultar_Carrera;
    }
}