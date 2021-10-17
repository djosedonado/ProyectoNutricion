
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
            this.pictureRegresar = new System.Windows.Forms.PictureBox();
            this.pictureContinuar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRegresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureContinuar)).BeginInit();
            this.SuspendLayout();
            // 
            // textIdentificacion
            // 
            this.textIdentificacion.Location = new System.Drawing.Point(253, 127);
            this.textIdentificacion.Name = "textIdentificacion";
            this.textIdentificacion.Size = new System.Drawing.Size(100, 20);
            this.textIdentificacion.TabIndex = 1;
            // 
            // Identificacion
            // 
            this.Identificacion.AutoSize = true;
            this.Identificacion.Location = new System.Drawing.Point(177, 130);
            this.Identificacion.Name = "Identificacion";
            this.Identificacion.Size = new System.Drawing.Size(70, 13);
            this.Identificacion.TabIndex = 2;
            this.Identificacion.Text = "Identificacion";
            // 
            // TituloLogin
            // 
            this.TituloLogin.AutoSize = true;
            this.TituloLogin.Location = new System.Drawing.Point(196, 49);
            this.TituloLogin.Name = "TituloLogin";
            this.TituloLogin.Size = new System.Drawing.Size(192, 13);
            this.TituloLogin.TabIndex = 4;
            this.TituloLogin.Text = "Ingrese su identificacion para continuar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Regresar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Continuar";
            // 
            // pictureRegresar
            // 
            this.pictureRegresar.Image = ((System.Drawing.Image)(resources.GetObject("pictureRegresar.Image")));
            this.pictureRegresar.Location = new System.Drawing.Point(165, 203);
            this.pictureRegresar.Name = "pictureRegresar";
            this.pictureRegresar.Size = new System.Drawing.Size(100, 50);
            this.pictureRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureRegresar.TabIndex = 9;
            this.pictureRegresar.TabStop = false;
            // 
            // pictureContinuar
            // 
            this.pictureContinuar.Image = ((System.Drawing.Image)(resources.GetObject("pictureContinuar.Image")));
            this.pictureContinuar.Location = new System.Drawing.Point(333, 203);
            this.pictureContinuar.Name = "pictureContinuar";
            this.pictureContinuar.Size = new System.Drawing.Size(100, 50);
            this.pictureContinuar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureContinuar.TabIndex = 10;
            this.pictureContinuar.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 341);
            this.Controls.Add(this.pictureContinuar);
            this.Controls.Add(this.pictureRegresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TituloLogin);
            this.Controls.Add(this.Identificacion);
            this.Controls.Add(this.textIdentificacion);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureRegresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureContinuar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textIdentificacion;
        private System.Windows.Forms.Label Identificacion;
        private System.Windows.Forms.Label TituloLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureRegresar;
        private System.Windows.Forms.PictureBox pictureContinuar;
    }
}