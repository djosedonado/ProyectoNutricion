
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TasaBasalPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TasaBasalAltura = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TasaBasalEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TasaBasalTMB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botonBuscarIdentificacion = new System.Windows.Forms.Button();
            this.textTasaIdentificacion = new System.Windows.Forms.TextBox();
            this.LabelIdentificacion = new System.Windows.Forms.Label();
            this.GraficaBarraEnergetica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Lunes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Martes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miercoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jueves = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Viernes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sabado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domingo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textEntrenamientoFuerza = new System.Windows.Forms.TextBox();
            this.TextEntrenamientoAerobicos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PanelFondoTasa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraficaBarraEnergetica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelFondoTasa
            // 
            this.PanelFondoTasa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.PanelFondoTasa.Controls.Add(this.button1);
            this.PanelFondoTasa.Controls.Add(this.label2);
            this.PanelFondoTasa.Controls.Add(this.label1);
            this.PanelFondoTasa.Controls.Add(this.TextEntrenamientoAerobicos);
            this.PanelFondoTasa.Controls.Add(this.textEntrenamientoFuerza);
            this.PanelFondoTasa.Controls.Add(this.dataGridView2);
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
            // botonBuscarIdentificacion
            // 
            this.botonBuscarIdentificacion.Location = new System.Drawing.Point(292, 34);
            this.botonBuscarIdentificacion.Name = "botonBuscarIdentificacion";
            this.botonBuscarIdentificacion.Size = new System.Drawing.Size(75, 23);
            this.botonBuscarIdentificacion.TabIndex = 1;
            this.botonBuscarIdentificacion.Text = "Buscar";
            this.botonBuscarIdentificacion.UseVisualStyleBackColor = true;
            // 
            // textTasaIdentificacion
            // 
            this.textTasaIdentificacion.Location = new System.Drawing.Point(169, 34);
            this.textTasaIdentificacion.Name = "textTasaIdentificacion";
            this.textTasaIdentificacion.Size = new System.Drawing.Size(100, 20);
            this.textTasaIdentificacion.TabIndex = 2;
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
            // GraficaBarraEnergetica
            // 
            chartArea1.Name = "GRAFO";
            this.GraficaBarraEnergetica.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.GraficaBarraEnergetica.Legends.Add(legend1);
            this.GraficaBarraEnergetica.Location = new System.Drawing.Point(603, 73);
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
            this.GraficaBarraEnergetica.Click += new System.EventHandler(this.chart1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lunes,
            this.Martes,
            this.Miercoles,
            this.Jueves,
            this.Viernes,
            this.Sabado,
            this.Domingo});
            this.dataGridView2.Location = new System.Drawing.Point(33, 364);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(740, 211);
            this.dataGridView2.TabIndex = 5;
            // 
            // Lunes
            // 
            this.Lunes.HeaderText = "Lunes";
            this.Lunes.Name = "Lunes";
            // 
            // Martes
            // 
            this.Martes.HeaderText = "Martes";
            this.Martes.Name = "Martes";
            // 
            // Miercoles
            // 
            this.Miercoles.HeaderText = "Miercoles";
            this.Miercoles.Name = "Miercoles";
            // 
            // Jueves
            // 
            this.Jueves.HeaderText = "Jueves";
            this.Jueves.Name = "Jueves";
            // 
            // Viernes
            // 
            this.Viernes.HeaderText = "Viernes";
            this.Viernes.Name = "Viernes";
            // 
            // Sabado
            // 
            this.Sabado.HeaderText = "Sabado";
            this.Sabado.Name = "Sabado";
            // 
            // Domingo
            // 
            this.Domingo.HeaderText = "Domingo";
            this.Domingo.Name = "Domingo";
            // 
            // textEntrenamientoFuerza
            // 
            this.textEntrenamientoFuerza.Location = new System.Drawing.Point(77, 304);
            this.textEntrenamientoFuerza.Name = "textEntrenamientoFuerza";
            this.textEntrenamientoFuerza.Size = new System.Drawing.Size(99, 20);
            this.textEntrenamientoFuerza.TabIndex = 6;
            // 
            // TextEntrenamientoAerobicos
            // 
            this.TextEntrenamientoAerobicos.Location = new System.Drawing.Point(267, 304);
            this.TextEntrenamientoAerobicos.Name = "TextEntrenamientoAerobicos";
            this.TextEntrenamientoAerobicos.Size = new System.Drawing.Size(100, 20);
            this.TextEntrenamientoAerobicos.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(65, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Entrenamiento de Fuerza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(254, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Entrenamineto Aerobicos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(410, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraficaBarraEnergetica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lunes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Martes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miercoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jueves;
        private System.Windows.Forms.DataGridViewTextBoxColumn Viernes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sabado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domingo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextEntrenamientoAerobicos;
        private System.Windows.Forms.TextBox textEntrenamientoFuerza;
    }
}