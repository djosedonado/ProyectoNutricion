
namespace Presentacion
{
    partial class TasaMetablistica
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
            this.PanelFondoTasa = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxGastoEnergetico = new System.Windows.Forms.TextBox();
            this.LabelIdentificacion = new System.Windows.Forms.Label();
            this.textTasaIdentificacion = new System.Windows.Forms.TextBox();
            this.botonBuscarIdentificacion = new System.Windows.Forms.Button();
            this.dgvTasaMetabolicaBasal = new System.Windows.Forms.DataGridView();
            this.TasaBasalPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TasaBasalAltura = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TasaBasalEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MetabolicaBasal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelFondoTasa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasaMetabolicaBasal)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelFondoTasa
            // 
            this.PanelFondoTasa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.PanelFondoTasa.Controls.Add(this.label2);
            this.PanelFondoTasa.Controls.Add(this.label1);
            this.PanelFondoTasa.Controls.Add(this.textBoxGastoEnergetico);
            this.PanelFondoTasa.Controls.Add(this.LabelIdentificacion);
            this.PanelFondoTasa.Controls.Add(this.textTasaIdentificacion);
            this.PanelFondoTasa.Controls.Add(this.botonBuscarIdentificacion);
            this.PanelFondoTasa.Controls.Add(this.dgvTasaMetabolicaBasal);
            this.PanelFondoTasa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFondoTasa.Location = new System.Drawing.Point(0, 0);
            this.PanelFondoTasa.Name = "PanelFondoTasa";
            this.PanelFondoTasa.Size = new System.Drawing.Size(935, 480);
            this.PanelFondoTasa.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(291, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 37);
            this.label2.TabIndex = 13;
            this.label2.Text = "TASA METABOLICA BASAL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(388, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Gasto Energetico";
            // 
            // textBoxGastoEnergetico
            // 
            this.textBoxGastoEnergetico.Enabled = false;
            this.textBoxGastoEnergetico.Location = new System.Drawing.Point(380, 332);
            this.textBoxGastoEnergetico.Name = "textBoxGastoEnergetico";
            this.textBoxGastoEnergetico.Size = new System.Drawing.Size(132, 20);
            this.textBoxGastoEnergetico.TabIndex = 11;
            // 
            // LabelIdentificacion
            // 
            this.LabelIdentificacion.AutoSize = true;
            this.LabelIdentificacion.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIdentificacion.ForeColor = System.Drawing.Color.White;
            this.LabelIdentificacion.Location = new System.Drawing.Point(285, 117);
            this.LabelIdentificacion.Name = "LabelIdentificacion";
            this.LabelIdentificacion.Size = new System.Drawing.Size(96, 19);
            this.LabelIdentificacion.TabIndex = 3;
            this.LabelIdentificacion.Text = "Identificacion";
            // 
            // textTasaIdentificacion
            // 
            this.textTasaIdentificacion.Location = new System.Drawing.Point(378, 117);
            this.textTasaIdentificacion.Name = "textTasaIdentificacion";
            this.textTasaIdentificacion.Size = new System.Drawing.Size(100, 20);
            this.textTasaIdentificacion.TabIndex = 2;
            this.textTasaIdentificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTasaIdentificacion_KeyPress);
            // 
            // botonBuscarIdentificacion
            // 
            this.botonBuscarIdentificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.botonBuscarIdentificacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonBuscarIdentificacion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.botonBuscarIdentificacion.FlatAppearance.BorderSize = 7;
            this.botonBuscarIdentificacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.botonBuscarIdentificacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.botonBuscarIdentificacion.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonBuscarIdentificacion.ForeColor = System.Drawing.Color.White;
            this.botonBuscarIdentificacion.Location = new System.Drawing.Point(523, 112);
            this.botonBuscarIdentificacion.Name = "botonBuscarIdentificacion";
            this.botonBuscarIdentificacion.Size = new System.Drawing.Size(75, 29);
            this.botonBuscarIdentificacion.TabIndex = 1;
            this.botonBuscarIdentificacion.Text = "Buscar";
            this.botonBuscarIdentificacion.UseVisualStyleBackColor = false;
            this.botonBuscarIdentificacion.Click += new System.EventHandler(this.botonBuscarIdentificacion_Click);
            // 
            // dgvTasaMetabolicaBasal
            // 
            this.dgvTasaMetabolicaBasal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasaMetabolicaBasal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TasaBasalPeso,
            this.TasaBasalAltura,
            this.TasaBasalEdad,
            this.MetabolicaBasal});
            this.dgvTasaMetabolicaBasal.Location = new System.Drawing.Point(218, 159);
            this.dgvTasaMetabolicaBasal.Name = "dgvTasaMetabolicaBasal";
            this.dgvTasaMetabolicaBasal.Size = new System.Drawing.Size(443, 122);
            this.dgvTasaMetabolicaBasal.TabIndex = 0;
            this.dgvTasaMetabolicaBasal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TasaBasalPeso
            // 
            this.TasaBasalPeso.HeaderText = "PESO";
            this.TasaBasalPeso.Name = "TasaBasalPeso";
            // 
            // TasaBasalAltura
            // 
            this.TasaBasalAltura.HeaderText = "ALTURA";
            this.TasaBasalAltura.Name = "TasaBasalAltura";
            // 
            // TasaBasalEdad
            // 
            this.TasaBasalEdad.HeaderText = "EDAD";
            this.TasaBasalEdad.Name = "TasaBasalEdad";
            // 
            // MetabolicaBasal
            // 
            this.MetabolicaBasal.HeaderText = "Metabolica Basal";
            this.MetabolicaBasal.Name = "MetabolicaBasal";
            // 
            // TasaMetablistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 480);
            this.Controls.Add(this.PanelFondoTasa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TasaMetablistica";
            this.Text = "TasaMetablistica";
            this.PanelFondoTasa.ResumeLayout(false);
            this.PanelFondoTasa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasaMetabolicaBasal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelFondoTasa;
        private System.Windows.Forms.DataGridView dgvTasaMetabolicaBasal;
        private System.Windows.Forms.Label LabelIdentificacion;
        private System.Windows.Forms.TextBox textTasaIdentificacion;
        private System.Windows.Forms.Button botonBuscarIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TasaBasalPeso;
        private System.Windows.Forms.DataGridViewButtonColumn TasaBasalAltura;
        private System.Windows.Forms.DataGridViewTextBoxColumn TasaBasalEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn MetabolicaBasal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxGastoEnergetico;
        private System.Windows.Forms.Label label2;
    }
}