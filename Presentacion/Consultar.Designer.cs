
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textNombrePaciente = new System.Windows.Forms.TextBox();
            this.dataGridViewConsultarDeportista = new System.Windows.Forms.DataGridView();
            this.ConsultaIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultaApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultaTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultaEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultaDeporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identificacion = new System.Windows.Forms.Label();
            this.TextboxIdentificacion = new System.Windows.Forms.TextBox();
            this.buttonBuscarDeportista = new System.Windows.Forms.Button();
            this.PanelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultarDeportista)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.PanelPrincipal.Controls.Add(this.buttonBuscarDeportista);
            this.PanelPrincipal.Controls.Add(this.label2);
            this.PanelPrincipal.Controls.Add(this.label1);
            this.PanelPrincipal.Controls.Add(this.textNombrePaciente);
            this.PanelPrincipal.Controls.Add(this.dataGridViewConsultarDeportista);
            this.PanelPrincipal.Controls.Add(this.Identificacion);
            this.PanelPrincipal.Controls.Add(this.TextboxIdentificacion);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(800, 450);
            this.PanelPrincipal.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(266, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "CONSULTA DEPORTISTA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(440, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre Paciente";
            // 
            // textNombrePaciente
            // 
            this.textNombrePaciente.Location = new System.Drawing.Point(431, 95);
            this.textNombrePaciente.Name = "textNombrePaciente";
            this.textNombrePaciente.Size = new System.Drawing.Size(140, 20);
            this.textNombrePaciente.TabIndex = 4;
            // 
            // dataGridViewConsultarDeportista
            // 
            this.dataGridViewConsultarDeportista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsultarDeportista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConsultaIdentificacion,
            this.ConsultaNombre,
            this.ConsultaApellido,
            this.ConsultaTelefono,
            this.ConsultaEdad,
            this.ConsultaDeporte});
            this.dataGridViewConsultarDeportista.Location = new System.Drawing.Point(84, 145);
            this.dataGridViewConsultarDeportista.Name = "dataGridViewConsultarDeportista";
            this.dataGridViewConsultarDeportista.Size = new System.Drawing.Size(641, 290);
            this.dataGridViewConsultarDeportista.TabIndex = 2;
            this.dataGridViewConsultarDeportista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConsultarDeportista_CellContentClick);
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
            // Identificacion
            // 
            this.Identificacion.AutoSize = true;
            this.Identificacion.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Identificacion.ForeColor = System.Drawing.Color.White;
            this.Identificacion.Location = new System.Drawing.Point(246, 72);
            this.Identificacion.Name = "Identificacion";
            this.Identificacion.Size = new System.Drawing.Size(100, 20);
            this.Identificacion.TabIndex = 1;
            this.Identificacion.Text = "Identificacion";
            // 
            // TextboxIdentificacion
            // 
            this.TextboxIdentificacion.Location = new System.Drawing.Point(247, 95);
            this.TextboxIdentificacion.Name = "TextboxIdentificacion";
            this.TextboxIdentificacion.Size = new System.Drawing.Size(100, 20);
            this.TextboxIdentificacion.TabIndex = 0;
            this.TextboxIdentificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextboxIdentificacion_KeyPress);
            // 
            // buttonBuscarDeportista
            // 
            this.buttonBuscarDeportista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.buttonBuscarDeportista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuscarDeportista.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonBuscarDeportista.FlatAppearance.BorderSize = 7;
            this.buttonBuscarDeportista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.buttonBuscarDeportista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.buttonBuscarDeportista.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarDeportista.ForeColor = System.Drawing.Color.White;
            this.buttonBuscarDeportista.Location = new System.Drawing.Point(626, 86);
            this.buttonBuscarDeportista.Name = "buttonBuscarDeportista";
            this.buttonBuscarDeportista.Size = new System.Drawing.Size(75, 29);
            this.buttonBuscarDeportista.TabIndex = 7;
            this.buttonBuscarDeportista.Text = "Buscar";
            this.buttonBuscarDeportista.UseVisualStyleBackColor = false;
            this.buttonBuscarDeportista.Click += new System.EventHandler(this.buttonBuscarDeportista_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultarDeportista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Label Identificacion;
        private System.Windows.Forms.TextBox TextboxIdentificacion;
        private System.Windows.Forms.DataGridView dataGridViewConsultarDeportista;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultaIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultaApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultaTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultaEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultaDeporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNombrePaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBuscarDeportista;
    }
}