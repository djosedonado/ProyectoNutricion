
namespace Presentacion
{
    partial class PresentacionPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PresentacionPrincipal));
            this.PanelFondo = new System.Windows.Forms.Panel();
            this.BotonMenu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.mzButtonWindows1 = new BWCMM.MZButtonWindows();
            this.PanelFondo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelFondo
            // 
            this.PanelFondo.BackColor = System.Drawing.Color.White;
            this.PanelFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PanelFondo.Controls.Add(this.BotonMenu);
            this.PanelFondo.Controls.Add(this.panel1);
            this.PanelFondo.Controls.Add(this.mzButtonWindows1);
            this.PanelFondo.Location = new System.Drawing.Point(-1, 0);
            this.PanelFondo.Name = "PanelFondo";
            this.PanelFondo.Size = new System.Drawing.Size(679, 433);
            this.PanelFondo.TabIndex = 1;
            // 
            // BotonMenu
            // 
            this.BotonMenu.BackgroundImage = global::Presentacion.Properties.Resources.lista;
            this.BotonMenu.Location = new System.Drawing.Point(3, 3);
            this.BotonMenu.Name = "BotonMenu";
            this.BotonMenu.Size = new System.Drawing.Size(32, 32);
            this.BotonMenu.TabIndex = 1;
            this.BotonMenu.UseVisualStyleBackColor = true;
            this.BotonMenu.Click += new System.EventHandler(this.BotonMenu_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 433);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Location = new System.Drawing.Point(56, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Nutricionista";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Location = new System.Drawing.Point(56, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Deportistas";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mzButtonWindows1
            // 
            this.mzButtonWindows1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mzButtonWindows1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mzButtonWindows1.BackgroundImage")));
            this.mzButtonWindows1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mzButtonWindows1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mzButtonWindows1.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows;
            this.mzButtonWindows1.Location = new System.Drawing.Point(639, 0);
            this.mzButtonWindows1.Name = "mzButtonWindows1";
            this.mzButtonWindows1.ParentControl = this;
            this.mzButtonWindows1.Size = new System.Drawing.Size(40, 24);
            this.mzButtonWindows1.TabIndex = 0;
            this.mzButtonWindows1.TipoButton = BWCMM.MZButtonWindows.ModeButton.Close;
            this.mzButtonWindows1.Paint += new System.Windows.Forms.PaintEventHandler(this.mzButtonWindows1_Paint);
            // 
            // PresentacionPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(678, 430);
            this.Controls.Add(this.PanelFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PresentacionPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NutriSoft";
            this.Load += new System.EventHandler(this.PresentacionPrincipal_Load);
            this.PanelFondo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelFondo;
        private BWCMM.MZButtonWindows mzButtonWindows1;
        private System.Windows.Forms.Button BotonMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

