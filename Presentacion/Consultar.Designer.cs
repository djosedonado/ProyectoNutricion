
namespace Presentacion
{
    partial class Consultar
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
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.botonConsultar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Identificacion = new System.Windows.Forms.Label();
            this.TextboxIdentificacion = new System.Windows.Forms.TextBox();
            this.ConsultaIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultaApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultaTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultaEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultaDeporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.PanelPrincipal.Controls.Add(this.botonConsultar);
            this.PanelPrincipal.Controls.Add(this.dataGridView1);
            this.PanelPrincipal.Controls.Add(this.Identificacion);
            this.PanelPrincipal.Controls.Add(this.TextboxIdentificacion);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(800, 450);
            this.PanelPrincipal.TabIndex = 0;
            // 
            // botonConsultar
            // 
            this.botonConsultar.Location = new System.Drawing.Point(222, 43);
            this.botonConsultar.Name = "botonConsultar";
            this.botonConsultar.Size = new System.Drawing.Size(86, 24);
            this.botonConsultar.TabIndex = 3;
            this.botonConsultar.Text = "Buscar";
            this.botonConsultar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConsultaIdentificacion,
            this.ConsultaNombre,
            this.ConsultaApellido,
            this.ConsultaTelefono,
            this.ConsultaEdad,
            this.ConsultaDeporte});
            this.dataGridView1.Location = new System.Drawing.Point(38, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 290);
            this.dataGridView1.TabIndex = 2;
            // 
            // Identificacion
            // 
            this.Identificacion.AutoSize = true;
            this.Identificacion.ForeColor = System.Drawing.Color.White;
            this.Identificacion.Location = new System.Drawing.Point(98, 31);
            this.Identificacion.Name = "Identificacion";
            this.Identificacion.Size = new System.Drawing.Size(70, 13);
            this.Identificacion.TabIndex = 1;
            this.Identificacion.Text = "Identificacion";
            // 
            // TextboxIdentificacion
            // 
            this.TextboxIdentificacion.Location = new System.Drawing.Point(79, 47);
            this.TextboxIdentificacion.Name = "TextboxIdentificacion";
            this.TextboxIdentificacion.Size = new System.Drawing.Size(100, 20);
            this.TextboxIdentificacion.TabIndex = 0;
            // 
            // ConsultaIdentificacion
            // 
            this.ConsultaIdentificacion.HeaderText = "Identificacion";
            this.ConsultaIdentificacion.Name = "ConsultaIdentificacion";
            // 
            // ConsultaNombre
            // 
            this.ConsultaNombre.HeaderText = "Nombre";
            this.ConsultaNombre.Name = "ConsultaNombre";
            // 
            // ConsultaApellido
            // 
            this.ConsultaApellido.HeaderText = "Apellido";
            this.ConsultaApellido.Name = "ConsultaApellido";
            // 
            // ConsultaTelefono
            // 
            this.ConsultaTelefono.HeaderText = "Telefono";
            this.ConsultaTelefono.Name = "ConsultaTelefono";
            // 
            // ConsultaEdad
            // 
            this.ConsultaEdad.HeaderText = "Edad";
            this.ConsultaEdad.Name = "ConsultaEdad";
            // 
            // ConsultaDeporte
            // 
            this.ConsultaDeporte.HeaderText = "Deporte";
            this.ConsultaDeporte.Name = "ConsultaDeporte";
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Consultar";
            this.Text = "Consultar";
            this.PanelPrincipal.ResumeLayout(false);
            this.PanelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Label Identificacion;
        private System.Windows.Forms.TextBox TextboxIdentificacion;
        private System.Windows.Forms.Button botonConsultar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultaIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultaApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultaTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultaEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultaDeporte;
    }
}