
namespace CarreraFrontend.Forms.Asignatura
{
    partial class ConsultarAsignatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarAsignatura));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar_Asig = new System.Windows.Forms.Button();
            this.btnEditar_Asig = new System.Windows.Forms.Button();
            this.gbResultados = new System.Windows.Forms.GroupBox();
            this.dgvConsultar_Asignatura = new System.Windows.Forms.DataGridView();
            this.col_Asignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cuatrimestre_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.cboBuscarAsignatura = new System.Windows.Forms.ComboBox();
            this.chkBaja = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConsultar_Asig = new System.Windows.Forms.Button();
            this.gbResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultar_Asignatura)).BeginInit();
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
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "S&alir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnEliminar_Asig
            // 
            this.btnEliminar_Asig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminar_Asig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar_Asig.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar_Asig.Location = new System.Drawing.Point(119, 324);
            this.btnEliminar_Asig.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminar_Asig.Name = "btnEliminar_Asig";
            this.btnEliminar_Asig.Size = new System.Drawing.Size(88, 27);
            this.btnEliminar_Asig.TabIndex = 13;
            this.btnEliminar_Asig.Text = "Eliminar";
            this.btnEliminar_Asig.UseVisualStyleBackColor = false;
            // 
            // btnEditar_Asig
            // 
            this.btnEditar_Asig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditar_Asig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar_Asig.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditar_Asig.Location = new System.Drawing.Point(13, 324);
            this.btnEditar_Asig.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditar_Asig.Name = "btnEditar_Asig";
            this.btnEditar_Asig.Size = new System.Drawing.Size(88, 27);
            this.btnEditar_Asig.TabIndex = 12;
            this.btnEditar_Asig.Text = "Editar";
            this.btnEditar_Asig.UseVisualStyleBackColor = false;
            // 
            // gbResultados
            // 
            this.gbResultados.Controls.Add(this.dgvConsultar_Asignatura);
            this.gbResultados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbResultados.Location = new System.Drawing.Point(13, 139);
            this.gbResultados.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbResultados.Name = "gbResultados";
            this.gbResultados.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbResultados.Size = new System.Drawing.Size(618, 179);
            this.gbResultados.TabIndex = 11;
            this.gbResultados.TabStop = false;
            this.gbResultados.Text = "Resultados";
            // 
            // dgvConsultar_Asignatura
            // 
            this.dgvConsultar_Asignatura.AllowUserToAddRows = false;
            this.dgvConsultar_Asignatura.AllowUserToDeleteRows = false;
            this.dgvConsultar_Asignatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultar_Asignatura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Asignatura,
            this.col_Carrera,
            this.col_cuatrimestre_num});
            this.dgvConsultar_Asignatura.Location = new System.Drawing.Point(8, 23);
            this.dgvConsultar_Asignatura.Name = "dgvConsultar_Asignatura";
            this.dgvConsultar_Asignatura.ReadOnly = true;
            this.dgvConsultar_Asignatura.RowTemplate.Height = 25;
            this.dgvConsultar_Asignatura.Size = new System.Drawing.Size(603, 150);
            this.dgvConsultar_Asignatura.TabIndex = 0;
            // 
            // col_Asignatura
            // 
            this.col_Asignatura.HeaderText = "Asignatura";
            this.col_Asignatura.Name = "col_Asignatura";
            this.col_Asignatura.ReadOnly = true;
            this.col_Asignatura.Width = 200;
            // 
            // col_Carrera
            // 
            this.col_Carrera.HeaderText = "Carrera";
            this.col_Carrera.Name = "col_Carrera";
            this.col_Carrera.ReadOnly = true;
            this.col_Carrera.Width = 200;
            // 
            // col_cuatrimestre_num
            // 
            this.col_cuatrimestre_num.HeaderText = "Numero de Cuatrimestre";
            this.col_cuatrimestre_num.Name = "col_cuatrimestre_num";
            this.col_cuatrimestre_num.ReadOnly = true;
            this.col_cuatrimestre_num.Width = 200;
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.cboBuscarAsignatura);
            this.gbFiltros.Controls.Add(this.chkBaja);
            this.gbFiltros.Controls.Add(this.label3);
            this.gbFiltros.Controls.Add(this.btnConsultar_Asig);
            this.gbFiltros.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbFiltros.Location = new System.Drawing.Point(13, 12);
            this.gbFiltros.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbFiltros.Size = new System.Drawing.Size(449, 121);
            this.gbFiltros.TabIndex = 10;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Criterios de búsqueda";
            // 
            // cboBuscarAsignatura
            // 
            this.cboBuscarAsignatura.FormattingEnabled = true;
            this.cboBuscarAsignatura.Location = new System.Drawing.Point(94, 29);
            this.cboBuscarAsignatura.Name = "cboBuscarAsignatura";
            this.cboBuscarAsignatura.Size = new System.Drawing.Size(195, 23);
            this.cboBuscarAsignatura.TabIndex = 8;
            // 
            // chkBaja
            // 
            this.chkBaja.AutoSize = true;
            this.chkBaja.Location = new System.Drawing.Point(20, 58);
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
            this.label3.Location = new System.Drawing.Point(20, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Asignatura:";
            // 
            // btnConsultar_Asig
            // 
            this.btnConsultar_Asig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConsultar_Asig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar_Asig.Location = new System.Drawing.Point(339, 29);
            this.btnConsultar_Asig.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConsultar_Asig.Name = "btnConsultar_Asig";
            this.btnConsultar_Asig.Size = new System.Drawing.Size(88, 27);
            this.btnConsultar_Asig.TabIndex = 0;
            this.btnConsultar_Asig.Text = "Consultar";
            this.btnConsultar_Asig.UseVisualStyleBackColor = false;
            // 
            // ConsultarAsignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(646, 359);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar_Asig);
            this.Controls.Add(this.btnEditar_Asig);
            this.Controls.Add(this.gbResultados);
            this.Controls.Add(this.gbFiltros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultarAsignatura";
            this.Text = "Consultar Asignatura";
            this.gbResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultar_Asignatura)).EndInit();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar_Asig;
        private System.Windows.Forms.Button btnEditar_Asig;
        private System.Windows.Forms.GroupBox gbResultados;
        private System.Windows.Forms.DataGridView dgvConsultar_Asignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Asignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cuatrimestre_num;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.ComboBox cboBuscarAsignatura;
        private System.Windows.Forms.CheckBox chkBaja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConsultar_Asig;
    }
}