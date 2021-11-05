
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
            this.SuspendLayout();
            // 
            // ContenedorRegistroDietas
            // 
            this.ContenedorRegistroDietas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.ContenedorRegistroDietas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorRegistroDietas.Location = new System.Drawing.Point(0, 0);
            this.ContenedorRegistroDietas.Name = "ContenedorRegistroDietas";
            this.ContenedorRegistroDietas.Size = new System.Drawing.Size(800, 450);
            this.ContenedorRegistroDietas.TabIndex = 0;
            // 
            // RegistarDietas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ContenedorRegistroDietas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistarDietas";
            this.Text = "RegistarDietas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ContenedorRegistroDietas;
    }
}