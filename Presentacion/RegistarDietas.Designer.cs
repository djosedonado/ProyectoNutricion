﻿
namespace Presentacion
{
    partial class RegistarDietas
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
            this.ContenedorRegistroDietas = new System.Windows.Forms.Panel();
            this.botonAgregarListado = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTotalLiquidos = new System.Windows.Forms.Label();
            this.labelTotalProteinas = new System.Windows.Forms.Label();
            this.labelTotalCarbohidratos = new System.Windows.Forms.Label();
            this.labelTotalCalorias = new System.Windows.Forms.Label();
            this.labelLiquidos = new System.Windows.Forms.Label();
            this.labelProteinas = new System.Windows.Forms.Label();
            this.labelCarbohidrato = new System.Windows.Forms.Label();
            this.labelCalorias = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textNombrePlantilla = new System.Windows.Forms.TextBox();
            this.ContenedorRegistroDietas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonAgregarListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ContenedorRegistroDietas
            // 
            this.ContenedorRegistroDietas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.ContenedorRegistroDietas.Controls.Add(this.botonAgregarListado);
            this.ContenedorRegistroDietas.Controls.Add(this.dataGridView1);
            this.ContenedorRegistroDietas.Controls.Add(this.label5);
            this.ContenedorRegistroDietas.Controls.Add(this.label4);
            this.ContenedorRegistroDietas.Controls.Add(this.textBox1);
            this.ContenedorRegistroDietas.Controls.Add(this.panel1);
            this.ContenedorRegistroDietas.Controls.Add(this.label3);
            this.ContenedorRegistroDietas.Controls.Add(this.comboBox2);
            this.ContenedorRegistroDietas.Controls.Add(this.label2);
            this.ContenedorRegistroDietas.Controls.Add(this.comboBox1);
            this.ContenedorRegistroDietas.Controls.Add(this.pictureBox1);
            this.ContenedorRegistroDietas.Controls.Add(this.label1);
            this.ContenedorRegistroDietas.Controls.Add(this.textNombrePlantilla);
            this.ContenedorRegistroDietas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorRegistroDietas.Location = new System.Drawing.Point(0, 0);
            this.ContenedorRegistroDietas.Name = "ContenedorRegistroDietas";
            this.ContenedorRegistroDietas.Size = new System.Drawing.Size(842, 502);
            this.ContenedorRegistroDietas.TabIndex = 0;
            // 
            // botonAgregarListado
            // 
            this.botonAgregarListado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonAgregarListado.Image = global::Presentacion.Properties.Resources.agregar_archivo;
            this.botonAgregarListado.Location = new System.Drawing.Point(428, 49);
            this.botonAgregarListado.Name = "botonAgregarListado";
            this.botonAgregarListado.Size = new System.Drawing.Size(65, 65);
            this.botonAgregarListado.TabIndex = 16;
            this.botonAgregarListado.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(77, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 199);
            this.dataGridView1.TabIndex = 15;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ingrediente";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Categoria";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad";
            this.Column4.Name = "Column4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(671, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Total (g)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(98, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cantidad";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 20);
            this.textBox1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.labelTotalLiquidos);
            this.panel1.Controls.Add(this.labelTotalProteinas);
            this.panel1.Controls.Add(this.labelTotalCarbohidratos);
            this.panel1.Controls.Add(this.labelTotalCalorias);
            this.panel1.Controls.Add(this.labelLiquidos);
            this.panel1.Controls.Add(this.labelProteinas);
            this.panel1.Controls.Add(this.labelCarbohidrato);
            this.panel1.Controls.Add(this.labelCalorias);
            this.panel1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.panel1.Location = new System.Drawing.Point(536, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 177);
            this.panel1.TabIndex = 7;
            // 
            // labelTotalLiquidos
            // 
            this.labelTotalLiquidos.AutoSize = true;
            this.labelTotalLiquidos.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalLiquidos.ForeColor = System.Drawing.Color.White;
            this.labelTotalLiquidos.Location = new System.Drawing.Point(135, 118);
            this.labelTotalLiquidos.Name = "labelTotalLiquidos";
            this.labelTotalLiquidos.Size = new System.Drawing.Size(28, 19);
            this.labelTotalLiquidos.TabIndex = 18;
            this.labelTotalLiquidos.Text = "0.0";
            // 
            // labelTotalProteinas
            // 
            this.labelTotalProteinas.AutoSize = true;
            this.labelTotalProteinas.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalProteinas.ForeColor = System.Drawing.Color.White;
            this.labelTotalProteinas.Location = new System.Drawing.Point(135, 87);
            this.labelTotalProteinas.Name = "labelTotalProteinas";
            this.labelTotalProteinas.Size = new System.Drawing.Size(28, 19);
            this.labelTotalProteinas.TabIndex = 17;
            this.labelTotalProteinas.Text = "0.0";
            // 
            // labelTotalCarbohidratos
            // 
            this.labelTotalCarbohidratos.AutoSize = true;
            this.labelTotalCarbohidratos.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalCarbohidratos.ForeColor = System.Drawing.Color.White;
            this.labelTotalCarbohidratos.Location = new System.Drawing.Point(135, 54);
            this.labelTotalCarbohidratos.Name = "labelTotalCarbohidratos";
            this.labelTotalCarbohidratos.Size = new System.Drawing.Size(28, 19);
            this.labelTotalCarbohidratos.TabIndex = 16;
            this.labelTotalCarbohidratos.Text = "0.0";
            // 
            // labelTotalCalorias
            // 
            this.labelTotalCalorias.AutoSize = true;
            this.labelTotalCalorias.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalCalorias.ForeColor = System.Drawing.Color.White;
            this.labelTotalCalorias.Location = new System.Drawing.Point(135, 19);
            this.labelTotalCalorias.Name = "labelTotalCalorias";
            this.labelTotalCalorias.Size = new System.Drawing.Size(28, 19);
            this.labelTotalCalorias.TabIndex = 15;
            this.labelTotalCalorias.Text = "0.0";
            // 
            // labelLiquidos
            // 
            this.labelLiquidos.AutoSize = true;
            this.labelLiquidos.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLiquidos.ForeColor = System.Drawing.Color.White;
            this.labelLiquidos.Location = new System.Drawing.Point(25, 118);
            this.labelLiquidos.Name = "labelLiquidos";
            this.labelLiquidos.Size = new System.Drawing.Size(62, 19);
            this.labelLiquidos.TabIndex = 13;
            this.labelLiquidos.Text = "Liquidos";
            // 
            // labelProteinas
            // 
            this.labelProteinas.AutoSize = true;
            this.labelProteinas.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProteinas.ForeColor = System.Drawing.Color.White;
            this.labelProteinas.Location = new System.Drawing.Point(24, 87);
            this.labelProteinas.Name = "labelProteinas";
            this.labelProteinas.Size = new System.Drawing.Size(70, 19);
            this.labelProteinas.TabIndex = 12;
            this.labelProteinas.Text = "Proteinas";
            // 
            // labelCarbohidrato
            // 
            this.labelCarbohidrato.AutoSize = true;
            this.labelCarbohidrato.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarbohidrato.ForeColor = System.Drawing.Color.White;
            this.labelCarbohidrato.Location = new System.Drawing.Point(24, 54);
            this.labelCarbohidrato.Name = "labelCarbohidrato";
            this.labelCarbohidrato.Size = new System.Drawing.Size(99, 19);
            this.labelCarbohidrato.TabIndex = 11;
            this.labelCarbohidrato.Text = "Carbohidratos";
            // 
            // labelCalorias
            // 
            this.labelCalorias.AutoSize = true;
            this.labelCalorias.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCalorias.ForeColor = System.Drawing.Color.White;
            this.labelCalorias.Location = new System.Drawing.Point(24, 19);
            this.labelCalorias.Name = "labelCalorias";
            this.labelCalorias.Size = new System.Drawing.Size(69, 19);
            this.labelCalorias.TabIndex = 10;
            this.labelCalorias.Text = "KCalorias";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(264, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ingrediente";
            // 
            // comboBox2
            // 
            this.comboBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(256, 130);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(92, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(264, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Categoria";
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(256, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.salvar;
            this.pictureBox1.Location = new System.Drawing.Point(565, 373);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 65);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de la Plantilla";
            // 
            // textNombrePlantilla
            // 
            this.textNombrePlantilla.Location = new System.Drawing.Point(88, 71);
            this.textNombrePlantilla.Name = "textNombrePlantilla";
            this.textNombrePlantilla.Size = new System.Drawing.Size(119, 20);
            this.textNombrePlantilla.TabIndex = 0;
            this.textNombrePlantilla.TextChanged += new System.EventHandler(this.textNombrePlantilla_TextChanged);
            // 
            // RegistarDietas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 502);
            this.Controls.Add(this.ContenedorRegistroDietas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistarDietas";
            this.Text = "RegistarDietas";
            this.ContenedorRegistroDietas.ResumeLayout(false);
            this.ContenedorRegistroDietas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonAgregarListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ContenedorRegistroDietas;
        private System.Windows.Forms.TextBox textNombrePlantilla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox botonAgregarListado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTotalLiquidos;
        private System.Windows.Forms.Label labelTotalProteinas;
        private System.Windows.Forms.Label labelTotalCarbohidratos;
        private System.Windows.Forms.Label labelTotalCalorias;
        private System.Windows.Forms.Label labelLiquidos;
        private System.Windows.Forms.Label labelProteinas;
        private System.Windows.Forms.Label labelCarbohidrato;
        private System.Windows.Forms.Label labelCalorias;
    }
}