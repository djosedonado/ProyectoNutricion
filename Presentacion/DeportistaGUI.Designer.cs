﻿
namespace Presentacion
{
    partial class DeportistaGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeportistaGUI));
            this.textPeso = new System.Windows.Forms.TextBox();
            this.textAltura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimeHorasDiarias = new System.Windows.Forms.DateTimePicker();
            this.pictureAceptar = new System.Windows.Forms.PictureBox();
            this.pictureRegresar = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRegresar)).BeginInit();
            this.SuspendLayout();
            // 
            // textPeso
            // 
            this.textPeso.Location = new System.Drawing.Point(71, 157);
            this.textPeso.Name = "textPeso";
            this.textPeso.Size = new System.Drawing.Size(113, 20);
            this.textPeso.TabIndex = 0;
            // 
            // textAltura
            // 
            this.textAltura.Location = new System.Drawing.Point(71, 222);
            this.textAltura.Name = "textAltura";
            this.textAltura.Size = new System.Drawing.Size(113, 20);
            this.textAltura.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese su peso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(70, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese su altura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(43, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Horas practicadas diarias";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Futbol",
            "Tennis",
            "Basquet",
            "Microfutbol",
            "Atletismo",
            "Natacion",
            "Ciclismo"});
            this.comboBox1.Location = new System.Drawing.Point(317, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(348, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Deporte";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dateTimeHorasDiarias);
            this.panel1.Controls.Add(this.pictureAceptar);
            this.panel1.Controls.Add(this.pictureRegresar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textAltura);
            this.panel1.Controls.Add(this.textPeso);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 401);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dateTimeHorasDiarias
            // 
            this.dateTimeHorasDiarias.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeHorasDiarias.CalendarForeColor = System.Drawing.Color.LawnGreen;
            this.dateTimeHorasDiarias.CalendarMonthBackground = System.Drawing.Color.Navy;
            this.dateTimeHorasDiarias.Location = new System.Drawing.Point(33, 317);
            this.dateTimeHorasDiarias.MinDate = new System.DateTime(1979, 1, 1, 0, 0, 0, 0);
            this.dateTimeHorasDiarias.Name = "dateTimeHorasDiarias";
            this.dateTimeHorasDiarias.Size = new System.Drawing.Size(200, 20);
            this.dateTimeHorasDiarias.TabIndex = 11;
            this.dateTimeHorasDiarias.Value = new System.DateTime(2021, 12, 13, 0, 0, 0, 0);
            // 
            // pictureAceptar
            // 
            this.pictureAceptar.Image = ((System.Drawing.Image)(resources.GetObject("pictureAceptar.Image")));
            this.pictureAceptar.Location = new System.Drawing.Point(416, 239);
            this.pictureAceptar.Name = "pictureAceptar";
            this.pictureAceptar.Size = new System.Drawing.Size(48, 50);
            this.pictureAceptar.TabIndex = 9;
            this.pictureAceptar.TabStop = false;
            // 
            // pictureRegresar
            // 
            this.pictureRegresar.Image = ((System.Drawing.Image)(resources.GetObject("pictureRegresar.Image")));
            this.pictureRegresar.Location = new System.Drawing.Point(317, 239);
            this.pictureRegresar.Name = "pictureRegresar";
            this.pictureRegresar.Size = new System.Drawing.Size(49, 50);
            this.pictureRegresar.TabIndex = 8;
            this.pictureRegresar.TabStop = false;
            this.pictureRegresar.Click += new System.EventHandler(this.pictureRegresar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LawnGreen;
            this.label5.Location = new System.Drawing.Point(123, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(284, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "BIENVENIDO A NUTRISOFT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(314, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Regresar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(413, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Aceptar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 20);
            this.textBox1.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(68, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Ingrese Identificacion";
            // 
            // DeportistaGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 401);
            this.Controls.Add(this.panel1);
            this.Name = "DeportistaGUI";
            this.Text = "Deportista";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRegresar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textPeso;
        private System.Windows.Forms.TextBox textAltura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureRegresar;
        private System.Windows.Forms.PictureBox pictureAceptar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimeHorasDiarias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
    }
}