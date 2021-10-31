
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.PanelFondoTasa = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.GraficaBarraEnergetica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LabelIdentificacion = new System.Windows.Forms.Label();
            this.textTasaIdentificacion = new System.Windows.Forms.TextBox();
            this.botonBuscarIdentificacion = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TasaBasalPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TasaBasalAltura = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TasaBasalEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TasaBasalTMB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelFondoTasa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraficaBarraEnergetica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelFondoTasa
            // 
            this.PanelFondoTasa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.PanelFondoTasa.Controls.Add(this.button1);
            this.PanelFondoTasa.Controls.Add(this.GraficaBarraEnergetica);
            this.PanelFondoTasa.Controls.Add(this.LabelIdentificacion);
            this.PanelFondoTasa.Controls.Add(this.textTasaIdentificacion);
            this.PanelFondoTasa.Controls.Add(this.botonBuscarIdentificacion);
            this.PanelFondoTasa.Controls.Add(this.dataGridView1);
            this.PanelFondoTasa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFondoTasa.Location = new System.Drawing.Point(0, 0);
            this.PanelFondoTasa.Name = "PanelFondoTasa";
            this.PanelFondoTasa.Size = new System.Drawing.Size(1123, 613);
            this.PanelFondoTasa.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(435, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // GraficaBarraEnergetica
            // 
            chartArea1.Name = "GRAFO";
            this.GraficaBarraEnergetica.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.GraficaBarraEnergetica.Legends.Add(legend1);
            this.GraficaBarraEnergetica.Location = new System.Drawing.Point(612, 34);
            this.GraficaBarraEnergetica.Name = "GraficaBarraEnergetica";
            this.GraficaBarraEnergetica.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "GRAFO";
            series1.Legend = "Legend1";
            series1.Name = "Lunes";
            series2.ChartArea = "GRAFO";
            series2.Legend = "Legend1";
            series2.Name = "Martes";
            series3.ChartArea = "GRAFO";
            series3.Legend = "Legend1";
            series3.Name = "Miercoles";
            series4.ChartArea = "GRAFO";
            series4.Legend = "Legend1";
            series4.Name = "Jueves";
            series5.ChartArea = "GRAFO";
            series5.Legend = "Legend1";
            series5.Name = "Viernes";
            series6.ChartArea = "GRAFO";
            series6.Legend = "Legend1";
            series6.Name = "Sabado";
            series7.ChartArea = "GRAFO";
            series7.Legend = "Legend1";
            series7.Name = "Domingo";
            this.GraficaBarraEnergetica.Series.Add(series1);
            this.GraficaBarraEnergetica.Series.Add(series2);
            this.GraficaBarraEnergetica.Series.Add(series3);
            this.GraficaBarraEnergetica.Series.Add(series4);
            this.GraficaBarraEnergetica.Series.Add(series5);
            this.GraficaBarraEnergetica.Series.Add(series6);
            this.GraficaBarraEnergetica.Series.Add(series7);
            this.GraficaBarraEnergetica.Size = new System.Drawing.Size(467, 263);
            this.GraficaBarraEnergetica.TabIndex = 4;
            this.GraficaBarraEnergetica.Text = "chart1";
            // 
            // LabelIdentificacion
            // 
            this.LabelIdentificacion.AutoSize = true;
            this.LabelIdentificacion.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIdentificacion.ForeColor = System.Drawing.Color.White;
            this.LabelIdentificacion.Location = new System.Drawing.Point(88, 34);
            this.LabelIdentificacion.Name = "LabelIdentificacion";
            this.LabelIdentificacion.Size = new System.Drawing.Size(75, 16);
            this.LabelIdentificacion.TabIndex = 3;
            this.LabelIdentificacion.Text = "Identificacion";
            // 
            // textTasaIdentificacion
            // 
            this.textTasaIdentificacion.Location = new System.Drawing.Point(169, 34);
            this.textTasaIdentificacion.Name = "textTasaIdentificacion";
            this.textTasaIdentificacion.Size = new System.Drawing.Size(100, 20);
            this.textTasaIdentificacion.TabIndex = 2;
            this.textTasaIdentificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTasaIdentificacion_KeyPress);
            // 
            // botonBuscarIdentificacion
            // 
            this.botonBuscarIdentificacion.Location = new System.Drawing.Point(292, 34);
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
            this.TasaBasalTMB});
            this.dataGridView1.Location = new System.Drawing.Point(43, 73);
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
            // TasaBasalTMB
            // 
            this.TasaBasalTMB.HeaderText = "TMB";
            this.TasaBasalTMB.Name = "TasaBasalTMB";
            // 
            // TasaMetablistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 613);
            this.Controls.Add(this.PanelFondoTasa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TasaMetablistica";
            this.Text = "TasaMetablistica";
            this.PanelFondoTasa.ResumeLayout(false);
            this.PanelFondoTasa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraficaBarraEnergetica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelFondoTasa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TasaBasalPeso;
        private System.Windows.Forms.DataGridViewButtonColumn TasaBasalAltura;
        private System.Windows.Forms.DataGridViewTextBoxColumn TasaBasalEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn TasaBasalTMB;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraficaBarraEnergetica;
        private System.Windows.Forms.Label LabelIdentificacion;
        private System.Windows.Forms.TextBox textTasaIdentificacion;
        private System.Windows.Forms.Button botonBuscarIdentificacion;
        private System.Windows.Forms.Button button1;
    }
}