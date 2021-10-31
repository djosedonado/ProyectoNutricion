
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextEntrenamientoAerobicos = new System.Windows.Forms.TextBox();
            this.textEntrenamientoFuerza = new System.Windows.Forms.TextBox();
            this.GraficaBarraEnergetica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LabelIdentificacion = new System.Windows.Forms.Label();
            this.textTasaIdentificacion = new System.Windows.Forms.TextBox();
            this.botonBuscarIdentificacion = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TasaBasalPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TasaBasalAltura = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TasaBasalEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TasaBasalTMB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisaSemanaFuerza = new System.Windows.Forms.CheckedListBox();
            this.DiasSemanaAerobico = new System.Windows.Forms.CheckedListBox();
            this.HorasEntrenamientosFuerza = new System.Windows.Forms.ComboBox();
            this.HorasEntremanientoAerobicos = new System.Windows.Forms.ComboBox();
            this.PanelFondoTasa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraficaBarraEnergetica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelFondoTasa
            // 
            this.PanelFondoTasa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.PanelFondoTasa.Controls.Add(this.HorasEntremanientoAerobicos);
            this.PanelFondoTasa.Controls.Add(this.HorasEntrenamientosFuerza);
            this.PanelFondoTasa.Controls.Add(this.DiasSemanaAerobico);
            this.PanelFondoTasa.Controls.Add(this.DisaSemanaFuerza);
            this.PanelFondoTasa.Controls.Add(this.button1);
            this.PanelFondoTasa.Controls.Add(this.label2);
            this.PanelFondoTasa.Controls.Add(this.label1);
            this.PanelFondoTasa.Controls.Add(this.TextEntrenamientoAerobicos);
            this.PanelFondoTasa.Controls.Add(this.textEntrenamientoFuerza);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(194, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Entrenamineto Aerobicos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Entrenamiento de Fuerza";
            // 
            // TextEntrenamientoAerobicos
            // 
            this.TextEntrenamientoAerobicos.Location = new System.Drawing.Point(209, 225);
            this.TextEntrenamientoAerobicos.Name = "TextEntrenamientoAerobicos";
            this.TextEntrenamientoAerobicos.Size = new System.Drawing.Size(100, 20);
            this.TextEntrenamientoAerobicos.TabIndex = 7;
            this.TextEntrenamientoAerobicos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextEntrenamientoAerobicos_KeyPress);
            // 
            // textEntrenamientoFuerza
            // 
            this.textEntrenamientoFuerza.Location = new System.Drawing.Point(50, 225);
            this.textEntrenamientoFuerza.Name = "textEntrenamientoFuerza";
            this.textEntrenamientoFuerza.Size = new System.Drawing.Size(99, 20);
            this.textEntrenamientoFuerza.TabIndex = 6;
            this.textEntrenamientoFuerza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEntrenamientoFuerza_KeyPress);
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
            // DisaSemanaFuerza
            // 
            this.DisaSemanaFuerza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.DisaSemanaFuerza.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisaSemanaFuerza.ForeColor = System.Drawing.Color.White;
            this.DisaSemanaFuerza.FormattingEnabled = true;
            this.DisaSemanaFuerza.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes"});
            this.DisaSemanaFuerza.Location = new System.Drawing.Point(50, 251);
            this.DisaSemanaFuerza.Name = "DisaSemanaFuerza";
            this.DisaSemanaFuerza.Size = new System.Drawing.Size(77, 89);
            this.DisaSemanaFuerza.TabIndex = 21;
            // 
            // DiasSemanaAerobico
            // 
            this.DiasSemanaAerobico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.DiasSemanaAerobico.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiasSemanaAerobico.ForeColor = System.Drawing.Color.White;
            this.DiasSemanaAerobico.FormattingEnabled = true;
            this.DiasSemanaAerobico.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes"});
            this.DiasSemanaAerobico.Location = new System.Drawing.Point(209, 251);
            this.DiasSemanaAerobico.Name = "DiasSemanaAerobico";
            this.DiasSemanaAerobico.Size = new System.Drawing.Size(77, 89);
            this.DiasSemanaAerobico.TabIndex = 22;
            // 
            // HorasEntrenamientosFuerza
            // 
            this.HorasEntrenamientosFuerza.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.HorasEntrenamientosFuerza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HorasEntrenamientosFuerza.FormattingEnabled = true;
            this.HorasEntrenamientosFuerza.Location = new System.Drawing.Point(50, 346);
            this.HorasEntrenamientosFuerza.Name = "HorasEntrenamientosFuerza";
            this.HorasEntrenamientosFuerza.Size = new System.Drawing.Size(79, 21);
            this.HorasEntrenamientosFuerza.TabIndex = 23;
            this.HorasEntrenamientosFuerza.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // HorasEntremanientoAerobicos
            // 
            this.HorasEntremanientoAerobicos.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.HorasEntremanientoAerobicos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HorasEntremanientoAerobicos.FormattingEnabled = true;
            this.HorasEntremanientoAerobicos.Location = new System.Drawing.Point(209, 351);
            this.HorasEntremanientoAerobicos.Name = "HorasEntremanientoAerobicos";
            this.HorasEntremanientoAerobicos.Size = new System.Drawing.Size(79, 21);
            this.HorasEntremanientoAerobicos.TabIndex = 24;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextEntrenamientoAerobicos;
        private System.Windows.Forms.TextBox textEntrenamientoFuerza;
        private System.Windows.Forms.ComboBox HorasEntrenamientosFuerza;
        private System.Windows.Forms.CheckedListBox DiasSemanaAerobico;
        private System.Windows.Forms.CheckedListBox DisaSemanaFuerza;
        private System.Windows.Forms.ComboBox HorasEntremanientoAerobicos;
    }
}