
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
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.textIdentificacion = new System.Windows.Forms.TextBox();
            this.Identificacion = new System.Windows.Forms.Label();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.TituloLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.Location = new System.Drawing.Point(186, 249);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(75, 23);
            this.buttonRegresar.TabIndex = 0;
            this.buttonRegresar.Text = "Regresar";
            this.buttonRegresar.UseVisualStyleBackColor = true;
            // 
            // textIdentificacion
            // 
            this.textIdentificacion.Location = new System.Drawing.Point(255, 140);
            this.textIdentificacion.Name = "textIdentificacion";
            this.textIdentificacion.Size = new System.Drawing.Size(100, 20);
            this.textIdentificacion.TabIndex = 1;
            // 
            // Identificacion
            // 
            this.Identificacion.AutoSize = true;
            this.Identificacion.Location = new System.Drawing.Point(179, 143);
            this.Identificacion.Name = "Identificacion";
            this.Identificacion.Size = new System.Drawing.Size(70, 13);
            this.Identificacion.TabIndex = 2;
            this.Identificacion.Text = "Identificacion";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(349, 249);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 3;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            // 
            // TituloLogin
            // 
            this.TituloLogin.AutoSize = true;
            this.TituloLogin.Location = new System.Drawing.Point(198, 62);
            this.TituloLogin.Name = "TituloLogin";
            this.TituloLogin.Size = new System.Drawing.Size(192, 13);
            this.TituloLogin.TabIndex = 4;
            this.TituloLogin.Text = "Ingrese su identificacion para continuar";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 341);
            this.Controls.Add(this.TituloLogin);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.Identificacion);
            this.Controls.Add(this.textIdentificacion);
            this.Controls.Add(this.buttonRegresar);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegresar;
        private System.Windows.Forms.TextBox textIdentificacion;
        private System.Windows.Forms.Label Identificacion;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Label TituloLogin;
    }
}