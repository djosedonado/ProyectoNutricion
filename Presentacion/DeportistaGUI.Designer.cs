
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
            this.ContenedorDeportista = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureAceptar = new System.Windows.Forms.PictureBox();
            this.ContenedorDeportista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAceptar)).BeginInit();
            this.SuspendLayout();
            // 
            // textPeso
            // 
            this.textPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPeso.Location = new System.Drawing.Point(71, 157);
            this.textPeso.Name = "textPeso";
            this.textPeso.Size = new System.Drawing.Size(113, 21);
            this.textPeso.TabIndex = 0;
            // 
            // textAltura
            // 
            this.textAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAltura.Location = new System.Drawing.Point(71, 222);
            this.textAltura.Name = "textAltura";
            this.textAltura.Size = new System.Drawing.Size(113, 21);
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
            this.label3.Location = new System.Drawing.Point(68, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Horas practicadas diarias";
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Futbol",
            "Tennis",
            "Basquet",
            "Microfutbol",
            "Atletismo",
            "Natacion",
            "Ciclismo"});
            this.comboBox1.Location = new System.Drawing.Point(332, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 23);
            this.comboBox1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(363, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Deporte";
            // 
            // ContenedorDeportista
            // 
            this.ContenedorDeportista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.ContenedorDeportista.Controls.Add(this.comboBox2);
            this.ContenedorDeportista.Controls.Add(this.pictureBox1);
            this.ContenedorDeportista.Controls.Add(this.label8);
            this.ContenedorDeportista.Controls.Add(this.textBox1);
            this.ContenedorDeportista.Controls.Add(this.label7);
            this.ContenedorDeportista.Controls.Add(this.label5);
            this.ContenedorDeportista.Controls.Add(this.pictureAceptar);
            this.ContenedorDeportista.Controls.Add(this.label4);
            this.ContenedorDeportista.Controls.Add(this.comboBox1);
            this.ContenedorDeportista.Controls.Add(this.label3);
            this.ContenedorDeportista.Controls.Add(this.label2);
            this.ContenedorDeportista.Controls.Add(this.label1);
            this.ContenedorDeportista.Controls.Add(this.textAltura);
            this.ContenedorDeportista.Controls.Add(this.textPeso);
            this.ContenedorDeportista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorDeportista.Location = new System.Drawing.Point(0, 0);
            this.ContenedorDeportista.Name = "ContenedorDeportista";
            this.ContenedorDeportista.Size = new System.Drawing.Size(532, 401);
            this.ContenedorDeportista.TabIndex = 11;
            this.ContenedorDeportista.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboBox2
            // 
            this.comboBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Entre 1 y 3 veces a la semana",
            "Entre 3 y 5 veces a la semana",
            "Entre 6 y 7 veces a la semana",
            "Entrenamiento fuerte y dos veces al dia"});
            this.comboBox2.Location = new System.Drawing.Point(71, 304);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(225, 23);
            this.comboBox2.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(366, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 73);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(71, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 21);
            this.textBox1.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(424, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Aceptar";
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
            // pictureAceptar
            // 
            this.pictureAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureAceptar.Image = ((System.Drawing.Image)(resources.GetObject("pictureAceptar.Image")));
            this.pictureAceptar.Location = new System.Drawing.Point(427, 286);
            this.pictureAceptar.Name = "pictureAceptar";
            this.pictureAceptar.Size = new System.Drawing.Size(48, 50);
            this.pictureAceptar.TabIndex = 9;
            this.pictureAceptar.TabStop = false;
            this.pictureAceptar.Click += new System.EventHandler(this.pictureAceptar_Click);
            // 
            // DeportistaGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 401);
            this.Controls.Add(this.ContenedorDeportista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeportistaGUI";
            this.Text = "Deportista";
            this.ContenedorDeportista.ResumeLayout(false);
            this.ContenedorDeportista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAceptar)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureAceptar;
        private System.Windows.Forms.Panel ContenedorDeportista;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}