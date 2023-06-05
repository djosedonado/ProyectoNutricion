
namespace Presentacion
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.ContenedorPrincipal = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BotonGuardarRegistro = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxTipoEntrenamiento = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxDeporte = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxAlturaRegistar = new System.Windows.Forms.TextBox();
            this.textBoxPesoRegistar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ContenedorPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonGuardarRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ContenedorPrincipal
            // 
            this.ContenedorPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.ContenedorPrincipal.Controls.Add(this.pictureBox2);
            this.ContenedorPrincipal.Controls.Add(this.BotonGuardarRegistro);
            this.ContenedorPrincipal.Controls.Add(this.label11);
            this.ContenedorPrincipal.Controls.Add(this.comboBoxTipoEntrenamiento);
            this.ContenedorPrincipal.Controls.Add(this.label12);
            this.ContenedorPrincipal.Controls.Add(this.textBoxDeporte);
            this.ContenedorPrincipal.Controls.Add(this.label18);
            this.ContenedorPrincipal.Controls.Add(this.label19);
            this.ContenedorPrincipal.Controls.Add(this.textBoxAlturaRegistar);
            this.ContenedorPrincipal.Controls.Add(this.textBoxPesoRegistar);
            this.ContenedorPrincipal.Controls.Add(this.label4);
            this.ContenedorPrincipal.Controls.Add(this.pictureBox1);
            this.ContenedorPrincipal.Controls.Add(this.label7);
            this.ContenedorPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorPrincipal.Location = new System.Drawing.Point(0, 0);
            this.ContenedorPrincipal.Name = "ContenedorPrincipal";
            this.ContenedorPrincipal.Size = new System.Drawing.Size(797, 529);
            this.ContenedorPrincipal.TabIndex = 25;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(505, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 70);
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // BotonGuardarRegistro
            // 
            this.BotonGuardarRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonGuardarRegistro.Image = global::Presentacion.Properties.Resources.salvar;
            this.BotonGuardarRegistro.Location = new System.Drawing.Point(491, 341);
            this.BotonGuardarRegistro.Name = "BotonGuardarRegistro";
            this.BotonGuardarRegistro.Size = new System.Drawing.Size(64, 64);
            this.BotonGuardarRegistro.TabIndex = 42;
            this.BotonGuardarRegistro.TabStop = false;
            this.BotonGuardarRegistro.Click += new System.EventHandler(this.BotonGuardarRegistro_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(316, 230);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 19);
            this.label11.TabIndex = 41;
            this.label11.Text = "Tipo de Entrenamiento";
            // 
            // comboBoxTipoEntrenamiento
            // 
            this.comboBoxTipoEntrenamiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxTipoEntrenamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoEntrenamiento.FormattingEnabled = true;
            this.comboBoxTipoEntrenamiento.Items.AddRange(new object[] {
            "Leve",
            "Moderado",
            "Intenso",
            "Extremo"});
            this.comboBoxTipoEntrenamiento.Location = new System.Drawing.Point(345, 259);
            this.comboBoxTipoEntrenamiento.Name = "comboBoxTipoEntrenamiento";
            this.comboBoxTipoEntrenamiento.Size = new System.Drawing.Size(98, 21);
            this.comboBoxTipoEntrenamiento.TabIndex = 40;
            this.comboBoxTipoEntrenamiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxTipoEntrenamiento_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(366, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 19);
            this.label12.TabIndex = 39;
            this.label12.Text = "Deporte";
            // 
            // textBoxDeporte
            // 
            this.textBoxDeporte.Location = new System.Drawing.Point(345, 196);
            this.textBoxDeporte.Name = "textBoxDeporte";
            this.textBoxDeporte.Size = new System.Drawing.Size(96, 20);
            this.textBoxDeporte.TabIndex = 38;
            this.textBoxDeporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDeporte_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(211, 230);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 19);
            this.label18.TabIndex = 36;
            this.label18.Text = "Altura";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(211, 174);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 19);
            this.label19.TabIndex = 35;
            this.label19.Text = "Peso";
            // 
            // textBoxAlturaRegistar
            // 
            this.textBoxAlturaRegistar.Location = new System.Drawing.Point(183, 259);
            this.textBoxAlturaRegistar.Name = "textBoxAlturaRegistar";
            this.textBoxAlturaRegistar.Size = new System.Drawing.Size(96, 20);
            this.textBoxAlturaRegistar.TabIndex = 33;
            this.textBoxAlturaRegistar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAlturaRegistar_KeyPress);
            // 
            // textBoxPesoRegistar
            // 
            this.textBoxPesoRegistar.Location = new System.Drawing.Point(183, 196);
            this.textBoxPesoRegistar.Name = "textBoxPesoRegistar";
            this.textBoxPesoRegistar.Size = new System.Drawing.Size(96, 20);
            this.textBoxPesoRegistar.TabIndex = 32;
            this.textBoxPesoRegistar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPesoRegistar_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 346);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 59);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(176, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(267, 37);
            this.label7.TabIndex = 13;
            this.label7.Text = "Registrar Deportista";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 529);
            this.Controls.Add(this.ContenedorPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro";
            this.Text = "Registrar";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.ContenedorPrincipal.ResumeLayout(false);
            this.ContenedorPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonGuardarRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ContenedorPrincipal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox BotonGuardarRegistro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxTipoEntrenamiento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxDeporte;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxAlturaRegistar;
        private System.Windows.Forms.TextBox textBoxPesoRegistar;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}