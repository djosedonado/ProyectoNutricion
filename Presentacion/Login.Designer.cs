
namespace Presentacion
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.textIdentificacion = new System.Windows.Forms.TextBox();
            this.Identificacion = new System.Windows.Forms.Label();
            this.TituloLogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkRegistrar = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureSalir = new System.Windows.Forms.PictureBox();
            this.pictureContinuar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureContinuar)).BeginInit();
            this.SuspendLayout();
            // 
            // textIdentificacion
            // 
            this.textIdentificacion.Location = new System.Drawing.Point(269, 127);
            this.textIdentificacion.Name = "textIdentificacion";
            this.textIdentificacion.Size = new System.Drawing.Size(100, 20);
            this.textIdentificacion.TabIndex = 1;
            // 
            // Identificacion
            // 
            this.Identificacion.AutoSize = true;
            this.Identificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Identificacion.ForeColor = System.Drawing.Color.White;
            this.Identificacion.Location = new System.Drawing.Point(173, 127);
            this.Identificacion.Name = "Identificacion";
            this.Identificacion.Size = new System.Drawing.Size(90, 17);
            this.Identificacion.TabIndex = 2;
            this.Identificacion.Text = "Identificacion";
            // 
            // TituloLogin
            // 
            this.TituloLogin.AutoSize = true;
            this.TituloLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloLogin.ForeColor = System.Drawing.Color.LawnGreen;
            this.TituloLogin.Location = new System.Drawing.Point(133, 53);
            this.TituloLogin.Name = "TituloLogin";
            this.TituloLogin.Size = new System.Drawing.Size(322, 22);
            this.TituloLogin.TabIndex = 4;
            this.TituloLogin.Text = "Ingrese su identificacion para continuar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(226, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Salir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(331, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Continuar";
            // 
            // linkRegistrar
            // 
            this.linkRegistrar.AutoSize = true;
            this.linkRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkRegistrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.linkRegistrar.LinkColor = System.Drawing.Color.White;
            this.linkRegistrar.Location = new System.Drawing.Point(184, 183);
            this.linkRegistrar.Name = "linkRegistrar";
            this.linkRegistrar.Size = new System.Drawing.Size(237, 17);
            this.linkRegistrar.TabIndex = 11;
            this.linkRegistrar.TabStop = true;
            this.linkRegistrar.Text = "Si no esta registrado haga click aqui";
            this.linkRegistrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegistrar_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.pictureSalir);
            this.panel1.Controls.Add(this.linkRegistrar);
            this.panel1.Controls.Add(this.pictureContinuar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TituloLogin);
            this.panel1.Controls.Add(this.Identificacion);
            this.panel1.Controls.Add(this.textIdentificacion);
            this.panel1.Location = new System.Drawing.Point(-3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 340);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureSalir
            // 
            this.pictureSalir.Image = ((System.Drawing.Image)(resources.GetObject("pictureSalir.Image")));
            this.pictureSalir.Location = new System.Drawing.Point(215, 225);
            this.pictureSalir.Name = "pictureSalir";
            this.pictureSalir.Size = new System.Drawing.Size(48, 50);
            this.pictureSalir.TabIndex = 12;
            this.pictureSalir.TabStop = false;
            this.pictureSalir.Click += new System.EventHandler(this.pictureSalir_Click);
            // 
            // pictureContinuar
            // 
            this.pictureContinuar.BackColor = System.Drawing.Color.Navy;
            this.pictureContinuar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureContinuar.Enabled = false;
            this.pictureContinuar.Image = ((System.Drawing.Image)(resources.GetObject("pictureContinuar.Image")));
            this.pictureContinuar.Location = new System.Drawing.Point(334, 225);
            this.pictureContinuar.Name = "pictureContinuar";
            this.pictureContinuar.Size = new System.Drawing.Size(53, 50);
            this.pictureContinuar.TabIndex = 10;
            this.pictureContinuar.TabStop = false;
            this.pictureContinuar.Click += new System.EventHandler(this.pictureContinuar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 341);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureContinuar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textIdentificacion;
        private System.Windows.Forms.Label Identificacion;
        private System.Windows.Forms.Label TituloLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureContinuar;
        private System.Windows.Forms.LinkLabel linkRegistrar;
        private System.Windows.Forms.PictureBox pictureSalir;
        private System.Windows.Forms.Panel panel1;
    }
}