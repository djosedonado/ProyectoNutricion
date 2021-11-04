
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.PanelFondoTasa = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.LabelIdentificacion = new System.Windows.Forms.Label();
            this.textTasaIdentificacion = new System.Windows.Forms.TextBox();
            this.botonBuscarIdentificacion = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TasaBasalPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TasaBasalAltura = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TasaBasalEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MetabolicaBasal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxGastoEnergetico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxSemana1 = new System.Windows.Forms.CheckBox();
            this.checkBoxSemana2 = new System.Windows.Forms.CheckBox();
            this.checkBoxSemana3 = new System.Windows.Forms.CheckBox();
            this.checkBoxSemana4 = new System.Windows.Forms.CheckBox();
            this.checkBoxSemana5 = new System.Windows.Forms.CheckBox();
            this.textBoxSemana1 = new System.Windows.Forms.TextBox();
            this.textBoxSemana2 = new System.Windows.Forms.TextBox();
            this.textBoxSemana3 = new System.Windows.Forms.TextBox();
            this.textBoxSemana4 = new System.Windows.Forms.TextBox();
            this.textBoxSemana5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PanelFondoTasa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelFondoTasa
            // 
            this.PanelFondoTasa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.PanelFondoTasa.Controls.Add(this.chart1);
            this.PanelFondoTasa.Controls.Add(this.label2);
            this.PanelFondoTasa.Controls.Add(this.textBoxSemana5);
            this.PanelFondoTasa.Controls.Add(this.textBoxSemana4);
            this.PanelFondoTasa.Controls.Add(this.textBoxSemana3);
            this.PanelFondoTasa.Controls.Add(this.textBoxSemana2);
            this.PanelFondoTasa.Controls.Add(this.textBoxSemana1);
            this.PanelFondoTasa.Controls.Add(this.checkBoxSemana5);
            this.PanelFondoTasa.Controls.Add(this.checkBoxSemana4);
            this.PanelFondoTasa.Controls.Add(this.checkBoxSemana3);
            this.PanelFondoTasa.Controls.Add(this.checkBoxSemana2);
            this.PanelFondoTasa.Controls.Add(this.checkBoxSemana1);
            this.PanelFondoTasa.Controls.Add(this.label1);
            this.PanelFondoTasa.Controls.Add(this.textBoxGastoEnergetico);
            this.PanelFondoTasa.Controls.Add(this.button1);
            this.PanelFondoTasa.Controls.Add(this.LabelIdentificacion);
            this.PanelFondoTasa.Controls.Add(this.textTasaIdentificacion);
            this.PanelFondoTasa.Controls.Add(this.botonBuscarIdentificacion);
            this.PanelFondoTasa.Controls.Add(this.dataGridView1);
            this.PanelFondoTasa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFondoTasa.Location = new System.Drawing.Point(0, 0);
            this.PanelFondoTasa.Name = "PanelFondoTasa";
            this.PanelFondoTasa.Size = new System.Drawing.Size(935, 480);
            this.PanelFondoTasa.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LabelIdentificacion
            // 
            this.LabelIdentificacion.AutoSize = true;
            this.LabelIdentificacion.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIdentificacion.ForeColor = System.Drawing.Color.White;
            this.LabelIdentificacion.Location = new System.Drawing.Point(181, 38);
            this.LabelIdentificacion.Name = "LabelIdentificacion";
            this.LabelIdentificacion.Size = new System.Drawing.Size(75, 16);
            this.LabelIdentificacion.TabIndex = 3;
            this.LabelIdentificacion.Text = "Identificacion";
            // 
            // textTasaIdentificacion
            // 
            this.textTasaIdentificacion.Location = new System.Drawing.Point(274, 34);
            this.textTasaIdentificacion.Name = "textTasaIdentificacion";
            this.textTasaIdentificacion.Size = new System.Drawing.Size(100, 20);
            this.textTasaIdentificacion.TabIndex = 2;
            this.textTasaIdentificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTasaIdentificacion_KeyPress);
            // 
            // botonBuscarIdentificacion
            // 
            this.botonBuscarIdentificacion.Location = new System.Drawing.Point(402, 34);
            this.botonBuscarIdentificacion.Name = "botonBuscarIdentificacion";
            this.botonBuscarIdentificacion.Size = new System.Drawing.Size(75, 23);
            this.botonBuscarIdentificacion.TabIndex = 1;
            this.botonBuscarIdentificacion.Text = "Buscar";
            this.botonBuscarIdentificacion.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TasaBasalPeso,
            this.TasaBasalAltura,
            this.TasaBasalEdad,
            this.MetabolicaBasal});
            this.dataGridView1.Location = new System.Drawing.Point(35, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 104);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // textBoxGastoEnergetico
            // 
            this.textBoxGastoEnergetico.Enabled = false;
            this.textBoxGastoEnergetico.Location = new System.Drawing.Point(80, 220);
            this.textBoxGastoEnergetico.Name = "textBoxGastoEnergetico";
            this.textBoxGastoEnergetico.Size = new System.Drawing.Size(122, 20);
            this.textBoxGastoEnergetico.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(94, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Gasto Energetico";
            // 
            // checkBoxSemana1
            // 
            this.checkBoxSemana1.AutoSize = true;
            this.checkBoxSemana1.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSemana1.ForeColor = System.Drawing.Color.White;
            this.checkBoxSemana1.Location = new System.Drawing.Point(66, 286);
            this.checkBoxSemana1.Name = "checkBoxSemana1";
            this.checkBoxSemana1.Size = new System.Drawing.Size(79, 21);
            this.checkBoxSemana1.TabIndex = 13;
            this.checkBoxSemana1.Text = "1 Semana";
            this.checkBoxSemana1.UseVisualStyleBackColor = true;
            // 
            // checkBoxSemana2
            // 
            this.checkBoxSemana2.AutoSize = true;
            this.checkBoxSemana2.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSemana2.ForeColor = System.Drawing.Color.White;
            this.checkBoxSemana2.Location = new System.Drawing.Point(66, 312);
            this.checkBoxSemana2.Name = "checkBoxSemana2";
            this.checkBoxSemana2.Size = new System.Drawing.Size(81, 21);
            this.checkBoxSemana2.TabIndex = 14;
            this.checkBoxSemana2.Text = "2 Semana";
            this.checkBoxSemana2.UseVisualStyleBackColor = true;
            // 
            // checkBoxSemana3
            // 
            this.checkBoxSemana3.AutoSize = true;
            this.checkBoxSemana3.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSemana3.ForeColor = System.Drawing.Color.White;
            this.checkBoxSemana3.Location = new System.Drawing.Point(66, 338);
            this.checkBoxSemana3.Name = "checkBoxSemana3";
            this.checkBoxSemana3.Size = new System.Drawing.Size(81, 21);
            this.checkBoxSemana3.TabIndex = 15;
            this.checkBoxSemana3.Text = "3 Semana";
            this.checkBoxSemana3.UseVisualStyleBackColor = true;
            // 
            // checkBoxSemana4
            // 
            this.checkBoxSemana4.AutoSize = true;
            this.checkBoxSemana4.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSemana4.ForeColor = System.Drawing.Color.White;
            this.checkBoxSemana4.Location = new System.Drawing.Point(66, 364);
            this.checkBoxSemana4.Name = "checkBoxSemana4";
            this.checkBoxSemana4.Size = new System.Drawing.Size(81, 21);
            this.checkBoxSemana4.TabIndex = 16;
            this.checkBoxSemana4.Text = "4 Semana";
            this.checkBoxSemana4.UseVisualStyleBackColor = true;
            // 
            // checkBoxSemana5
            // 
            this.checkBoxSemana5.AutoSize = true;
            this.checkBoxSemana5.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSemana5.ForeColor = System.Drawing.Color.White;
            this.checkBoxSemana5.Location = new System.Drawing.Point(66, 390);
            this.checkBoxSemana5.Name = "checkBoxSemana5";
            this.checkBoxSemana5.Size = new System.Drawing.Size(81, 21);
            this.checkBoxSemana5.TabIndex = 17;
            this.checkBoxSemana5.Text = "5 Semana";
            this.checkBoxSemana5.UseVisualStyleBackColor = true;
            // 
            // textBoxSemana1
            // 
            this.textBoxSemana1.Location = new System.Drawing.Point(145, 283);
            this.textBoxSemana1.Name = "textBoxSemana1";
            this.textBoxSemana1.Size = new System.Drawing.Size(82, 20);
            this.textBoxSemana1.TabIndex = 18;
            this.textBoxSemana1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSemana1_KeyPress);
            // 
            // textBoxSemana2
            // 
            this.textBoxSemana2.Location = new System.Drawing.Point(146, 309);
            this.textBoxSemana2.Name = "textBoxSemana2";
            this.textBoxSemana2.Size = new System.Drawing.Size(82, 20);
            this.textBoxSemana2.TabIndex = 19;
            this.textBoxSemana2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSemana2_KeyPress);
            // 
            // textBoxSemana3
            // 
            this.textBoxSemana3.Location = new System.Drawing.Point(145, 335);
            this.textBoxSemana3.Name = "textBoxSemana3";
            this.textBoxSemana3.Size = new System.Drawing.Size(82, 20);
            this.textBoxSemana3.TabIndex = 20;
            this.textBoxSemana3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSemana3_KeyPress);
            // 
            // textBoxSemana4
            // 
            this.textBoxSemana4.Location = new System.Drawing.Point(145, 361);
            this.textBoxSemana4.Name = "textBoxSemana4";
            this.textBoxSemana4.Size = new System.Drawing.Size(82, 20);
            this.textBoxSemana4.TabIndex = 21;
            this.textBoxSemana4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSemana4_KeyPress);
            // 
            // textBoxSemana5
            // 
            this.textBoxSemana5.Location = new System.Drawing.Point(145, 387);
            this.textBoxSemana5.Name = "textBoxSemana5";
            this.textBoxSemana5.Size = new System.Drawing.Size(82, 20);
            this.textBoxSemana5.TabIndex = 22;
            this.textBoxSemana5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSemana5_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(76, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Peso por Semana";
            // 
            // chart1
            // 
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(496, 38);
            this.chart1.Name = "chart1";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(416, 403);
            this.chart1.TabIndex = 24;
            this.chart1.Text = "chart1";
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelFondoTasa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LabelIdentificacion;
        private System.Windows.Forms.TextBox textTasaIdentificacion;
        private System.Windows.Forms.Button botonBuscarIdentificacion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TasaBasalPeso;
        private System.Windows.Forms.DataGridViewButtonColumn TasaBasalAltura;
        private System.Windows.Forms.DataGridViewTextBoxColumn TasaBasalEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn MetabolicaBasal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxGastoEnergetico;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSemana5;
        private System.Windows.Forms.TextBox textBoxSemana4;
        private System.Windows.Forms.TextBox textBoxSemana3;
        private System.Windows.Forms.TextBox textBoxSemana2;
        private System.Windows.Forms.TextBox textBoxSemana1;
        private System.Windows.Forms.CheckBox checkBoxSemana5;
        private System.Windows.Forms.CheckBox checkBoxSemana4;
        private System.Windows.Forms.CheckBox checkBoxSemana3;
        private System.Windows.Forms.CheckBox checkBoxSemana2;
        private System.Windows.Forms.CheckBox checkBoxSemana1;
    }
}