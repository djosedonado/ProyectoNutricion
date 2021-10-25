
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
            this.Identificacion = new System.Windows.Forms.Label();
            this.TextboxIdentificacion = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.botonConsultar = new System.Windows.Forms.Button();
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(560, 296);
            this.dataGridView1.TabIndex = 2;
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
    }
}