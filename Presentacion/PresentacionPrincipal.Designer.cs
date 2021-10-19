
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
            this.buttonNutricionista = new System.Windows.Forms.Button();
            this.buttonDeportista = new System.Windows.Forms.Button();
            this.mzButtonWindows1 = new BWCMM.MZButtonWindows();
            this.linkRegistrar = new System.Windows.Forms.LinkLabel();
            this.PanelFondo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelFondo
            // 
            this.PanelFondo.BackColor = System.Drawing.Color.LawnGreen;
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
            this.panel1.Controls.Add(this.linkRegistrar);
            this.panel1.Controls.Add(this.buttonNutricionista);
            this.panel1.Controls.Add(this.buttonDeportista);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 433);
            this.panel1.TabIndex = 2;
            // 
            // buttonNutricionista
            // 
            this.buttonNutricionista.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonNutricionista.ForeColor = System.Drawing.Color.White;
            this.buttonNutricionista.Location = new System.Drawing.Point(56, 135);
            this.buttonNutricionista.Name = "buttonNutricionista";
            this.buttonNutricionista.Size = new System.Drawing.Size(105, 47);
            this.buttonNutricionista.TabIndex = 3;
            this.buttonNutricionista.Text = "Nutricionista";
            this.buttonNutricionista.UseVisualStyleBackColor = false;
            this.buttonNutricionista.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDeportista
            // 
            this.buttonDeportista.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonDeportista.ForeColor = System.Drawing.Color.White;
            this.buttonDeportista.Location = new System.Drawing.Point(56, 212);
            this.buttonDeportista.Name = "buttonDeportista";
            this.buttonDeportista.Size = new System.Drawing.Size(105, 47);
            this.buttonDeportista.TabIndex = 0;
            this.buttonDeportista.Text = "Deportistas";
            this.buttonDeportista.UseVisualStyleBackColor = false;
            this.buttonDeportista.Click += new System.EventHandler(this.button2_Click);
            // 
            // mzButtonWindows1
            // 
            this.mzButtonWindows1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mzButtonWindows1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mzButtonWindows1.BackgroundImage")));
            this.mzButtonWindows1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mzButtonWindows1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mzButtonWindows1.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows;
            this.mzButtonWindows1.Location = new System.Drawing.Point(638, 0);
            this.mzButtonWindows1.Name = "mzButtonWindows1";
            this.mzButtonWindows1.ParentControl = this;
            this.mzButtonWindows1.Size = new System.Drawing.Size(40, 24);
            this.mzButtonWindows1.TabIndex = 0;
            this.mzButtonWindows1.TipoButton = BWCMM.MZButtonWindows.ModeButton.Close;
            this.mzButtonWindows1.Paint += new System.Windows.Forms.PaintEventHandler(this.mzButtonWindows1_Paint);
            // 
            // linkRegistrar
            // 
            this.linkRegistrar.AutoSize = true;
            this.linkRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkRegistrar.LinkColor = System.Drawing.Color.White;
            this.linkRegistrar.Location = new System.Drawing.Point(43, 321);
            this.linkRegistrar.Name = "linkRegistrar";
            this.linkRegistrar.Size = new System.Drawing.Size(127, 17);
            this.linkRegistrar.TabIndex = 4;
            this.linkRegistrar.TabStop = true;
            this.linkRegistrar.Text = "Click para registrar";
            this.linkRegistrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegistrar_LinkClicked);
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
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelFondo;
        private BWCMM.MZButtonWindows mzButtonWindows1;
        private System.Windows.Forms.Button BotonMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonNutricionista;
        private System.Windows.Forms.Button buttonDeportista;
        private System.Windows.Forms.LinkLabel linkRegistrar;
    }
}

