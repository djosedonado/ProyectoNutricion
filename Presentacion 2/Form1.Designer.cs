
namespace Presentacion_2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.botonMinimizar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.botonMaximizar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.botonRestaurar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.botonCerrar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.botonRestaurar);
            this.guna2Panel1.Controls.Add(this.botonMinimizar);
            this.guna2Panel1.Controls.Add(this.botonCerrar);
            this.guna2Panel1.Controls.Add(this.botonMaximizar);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(800, 40);
            this.guna2Panel1.TabIndex = 1;
            // 
            // botonMinimizar
            // 
            this.botonMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonMinimizar.BackgroundImage = global::Presentacion_2.Properties.Resources.minimizar;
            this.botonMinimizar.Image = global::Presentacion_2.Properties.Resources.minimizar;
            this.botonMinimizar.ImageRotate = 0F;
            this.botonMinimizar.Location = new System.Drawing.Point(683, 0);
            this.botonMinimizar.Name = "botonMinimizar";
            this.botonMinimizar.ShadowDecoration.Parent = this.botonMinimizar;
            this.botonMinimizar.Size = new System.Drawing.Size(35, 35);
            this.botonMinimizar.TabIndex = 5;
            this.botonMinimizar.TabStop = false;
            this.botonMinimizar.Click += new System.EventHandler(this.botonMinimizar_Click);
            // 
            // botonMaximizar
            // 
            this.botonMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonMaximizar.Image = global::Presentacion_2.Properties.Resources.maximizar;
            this.botonMaximizar.ImageRotate = 0F;
            this.botonMaximizar.Location = new System.Drawing.Point(724, 3);
            this.botonMaximizar.Name = "botonMaximizar";
            this.botonMaximizar.ShadowDecoration.Parent = this.botonMaximizar;
            this.botonMaximizar.Size = new System.Drawing.Size(35, 35);
            this.botonMaximizar.TabIndex = 4;
            this.botonMaximizar.TabStop = false;
            this.botonMaximizar.Click += new System.EventHandler(this.botonMaximizar_Click);
            // 
            // botonRestaurar
            // 
            this.botonRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonRestaurar.Image = global::Presentacion_2.Properties.Resources.minimizar__1_;
            this.botonRestaurar.ImageRotate = 0F;
            this.botonRestaurar.Location = new System.Drawing.Point(724, 2);
            this.botonRestaurar.Name = "botonRestaurar";
            this.botonRestaurar.ShadowDecoration.Parent = this.botonRestaurar;
            this.botonRestaurar.Size = new System.Drawing.Size(35, 35);
            this.botonRestaurar.TabIndex = 3;
            this.botonRestaurar.TabStop = false;
            this.botonRestaurar.Visible = false;
            this.botonRestaurar.Click += new System.EventHandler(this.botonRestaurar_Click);
            // 
            // botonCerrar
            // 
            this.botonCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonCerrar.Image = global::Presentacion_2.Properties.Resources.puerta_de_salida;
            this.botonCerrar.ImageRotate = 0F;
            this.botonCerrar.Location = new System.Drawing.Point(765, 0);
            this.botonCerrar.Name = "botonCerrar";
            this.botonCerrar.ShadowDecoration.Parent = this.botonCerrar;
            this.botonCerrar.Size = new System.Drawing.Size(35, 35);
            this.botonCerrar.TabIndex = 2;
            this.botonCerrar.TabStop = false;
            this.botonCerrar.Click += new System.EventHandler(this.botonCerrar_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 40);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(160, 410);
            this.guna2Panel2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.botonMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox botonCerrar;
        private Guna.UI2.WinForms.Guna2PictureBox botonRestaurar;
        private Guna.UI2.WinForms.Guna2PictureBox botonMaximizar;
        private Guna.UI2.WinForms.Guna2PictureBox botonMinimizar;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    }
}

