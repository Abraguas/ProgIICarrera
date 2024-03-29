﻿
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarAsignatura));
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbResultados = new System.Windows.Forms.GroupBox();
            this.dgvConsultar_Asignatura = new System.Windows.Forms.DataGridView();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultar_Asignatura)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.Location = new System.Drawing.Point(670, 243);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 27);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "S&alir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gbResultados
            // 
            this.gbResultados.Controls.Add(this.dgvConsultar_Asignatura);
            this.gbResultados.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbResultados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbResultados.Location = new System.Drawing.Point(13, 12);
            this.gbResultados.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbResultados.Name = "gbResultados";
            this.gbResultados.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbResultados.Size = new System.Drawing.Size(745, 223);
            this.gbResultados.TabIndex = 11;
            this.gbResultados.TabStop = false;
            this.gbResultados.Text = "Resultados";
            // 
            // dgvConsultar_Asignatura
            // 
            this.dgvConsultar_Asignatura.AllowUserToAddRows = false;
            this.dgvConsultar_Asignatura.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvConsultar_Asignatura.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsultar_Asignatura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultar_Asignatura.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultar_Asignatura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConsultar_Asignatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultar_Asignatura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.col_Nombre,
            this.col_editar,
            this.col_borrar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConsultar_Asignatura.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvConsultar_Asignatura.Location = new System.Drawing.Point(8, 23);
            this.dgvConsultar_Asignatura.Name = "dgvConsultar_Asignatura";
            this.dgvConsultar_Asignatura.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvConsultar_Asignatura.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvConsultar_Asignatura.RowTemplate.Height = 25;
            this.dgvConsultar_Asignatura.Size = new System.Drawing.Size(730, 191);
            this.dgvConsultar_Asignatura.TabIndex = 0;
            this.dgvConsultar_Asignatura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultar_Asignatura_CellContentClick);
            // 
            // col_id
            // 
            this.col_id.HeaderText = "Id";
            this.col_id.Name = "col_id";
            this.col_id.ReadOnly = true;
            this.col_id.Visible = false;
            // 
            // col_Nombre
            // 
            this.col_Nombre.HeaderText = "Nombre";
            this.col_Nombre.Name = "col_Nombre";
            this.col_Nombre.ReadOnly = true;
            // 
            // col_editar
            // 
            this.col_editar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.col_editar.HeaderText = "Editar";
            this.col_editar.Name = "col_editar";
            this.col_editar.ReadOnly = true;
            this.col_editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_editar.Text = "Editar Asignatura";
            this.col_editar.UseColumnTextForButtonValue = true;
            // 
            // col_borrar
            // 
            this.col_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.col_borrar.HeaderText = "Borrar";
            this.col_borrar.Name = "col_borrar";
            this.col_borrar.ReadOnly = true;
            this.col_borrar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_borrar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_borrar.Text = "Borrar Asignatura";
            this.col_borrar.UseColumnTextForButtonValue = true;
            // 
            // ConsultarAsignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(771, 284);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbResultados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConsultarAsignatura";
            this.Text = "Consultar Asignatura";
            this.Load += new System.EventHandler(this.ConsultarAsignatura_Load);
            this.gbResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultar_Asignatura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar_Asig;
        private System.Windows.Forms.Button btnEditar_Asig;
        private System.Windows.Forms.GroupBox gbResultados;
        private System.Windows.Forms.DataGridView dgvConsultar_Asignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Nombre;
        private System.Windows.Forms.DataGridViewButtonColumn col_editar;
        private System.Windows.Forms.DataGridViewButtonColumn col_borrar;
    }
}