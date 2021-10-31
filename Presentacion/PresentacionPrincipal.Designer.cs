
namespace Presentacion
{
    partial class PresentacionPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PresentacionPrincipal));
            this.panelCabeza = new System.Windows.Forms.Panel();
            this.VentanaMenu = new System.Windows.Forms.Panel();
            this.botonConsultaBasal = new System.Windows.Forms.Button();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.LogoHome = new System.Windows.Forms.PictureBox();
            this.botonRegistarPaciente = new System.Windows.Forms.Button();
            this.botonRestaurar = new System.Windows.Forms.PictureBox();
            this.botonMinimizar = new System.Windows.Forms.PictureBox();
            this.botonMaximizar = new System.Windows.Forms.PictureBox();
            this.botonCerrar = new System.Windows.Forms.PictureBox();
            this.panelCabeza.SuspendLayout();
            this.VentanaMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCabeza
            // 
            this.panelCabeza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(133)))));
            this.panelCabeza.Controls.Add(this.botonRestaurar);
            this.panelCabeza.Controls.Add(this.botonMinimizar);
            this.panelCabeza.Controls.Add(this.botonMaximizar);
            this.panelCabeza.Controls.Add(this.botonCerrar);
            this.panelCabeza.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabeza.Location = new System.Drawing.Point(0, 0);
            this.panelCabeza.Name = "panelCabeza";
            this.panelCabeza.Size = new System.Drawing.Size(1080, 35);
            this.panelCabeza.TabIndex = 0;
            this.panelCabeza.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCabeza_MouseDown);
            // 
            // VentanaMenu
            // 
            this.VentanaMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(164)))));
            this.VentanaMenu.Controls.Add(this.botonConsultaBasal);
            this.VentanaMenu.Controls.Add(this.button1);
            this.VentanaMenu.Controls.Add(this.LogoHome);
            this.VentanaMenu.Controls.Add(this.botonRegistarPaciente);
            this.VentanaMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.VentanaMenu.Location = new System.Drawing.Point(0, 35);
            this.VentanaMenu.Name = "VentanaMenu";
            this.VentanaMenu.Size = new System.Drawing.Size(200, 615);
            this.VentanaMenu.TabIndex = 1;
            // 
            // botonConsultaBasal
            // 
            this.botonConsultaBasal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(164)))));
            this.botonConsultaBasal.FlatAppearance.BorderSize = 0;
            this.botonConsultaBasal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(133)))));
            this.botonConsultaBasal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonConsultaBasal.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonConsultaBasal.ForeColor = System.Drawing.Color.White;
            this.botonConsultaBasal.Location = new System.Drawing.Point(49, 207);
            this.botonConsultaBasal.Name = "botonConsultaBasal";
            this.botonConsultaBasal.Size = new System.Drawing.Size(150, 32);
            this.botonConsultaBasal.TabIndex = 4;
            this.botonConsultaBasal.Text = "Tasa Metabolistica Basal";
            this.botonConsultaBasal.UseVisualStyleBackColor = false;
            this.botonConsultaBasal.Click += new System.EventHandler(this.botonConsultaBasal_Click);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(200, 35);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(880, 615);
            this.PanelContenedor.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(164)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(133)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Presentacion.Properties.Resources.Lupa_de_Busqueda;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(3, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = " Consultar Paciente";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LogoHome
            // 
            this.LogoHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoHome.Image = global::Presentacion.Properties.Resources.Logo_NutriSoft;
            this.LogoHome.Location = new System.Drawing.Point(0, 0);
            this.LogoHome.Name = "LogoHome";
            this.LogoHome.Size = new System.Drawing.Size(200, 113);
            this.LogoHome.TabIndex = 1;
            this.LogoHome.TabStop = false;
            this.LogoHome.Click += new System.EventHandler(this.LogoHome_Click);
            // 
            // botonRegistarPaciente
            // 
            this.botonRegistarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(164)))));
            this.botonRegistarPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonRegistarPaciente.FlatAppearance.BorderSize = 0;
            this.botonRegistarPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(133)))));
            this.botonRegistarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRegistarPaciente.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRegistarPaciente.ForeColor = System.Drawing.Color.White;
            this.botonRegistarPaciente.Image = global::Presentacion.Properties.Resources.usuario;
            this.botonRegistarPaciente.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.botonRegistarPaciente.Location = new System.Drawing.Point(0, 119);
            this.botonRegistarPaciente.Name = "botonRegistarPaciente";
            this.botonRegistarPaciente.Size = new System.Drawing.Size(197, 38);
            this.botonRegistarPaciente.TabIndex = 0;
            this.botonRegistarPaciente.Text = "RegistarPaciente";
            this.botonRegistarPaciente.UseVisualStyleBackColor = false;
            this.botonRegistarPaciente.Click += new System.EventHandler(this.botonRegistarPaciente_Click);
            // 
            // botonRestaurar
            // 
            this.botonRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("botonRestaurar.Image")));
            this.botonRestaurar.Location = new System.Drawing.Point(1021, 3);
            this.botonRestaurar.Name = "botonRestaurar";
            this.botonRestaurar.Size = new System.Drawing.Size(25, 25);
            this.botonRestaurar.TabIndex = 0;
            this.botonRestaurar.TabStop = false;
            this.botonRestaurar.Visible = false;
            this.botonRestaurar.Click += new System.EventHandler(this.botonRestaurar_Click);
            // 
            // botonMinimizar
            // 
            this.botonMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("botonMinimizar.Image")));
            this.botonMinimizar.Location = new System.Drawing.Point(990, 4);
            this.botonMinimizar.Name = "botonMinimizar";
            this.botonMinimizar.Size = new System.Drawing.Size(25, 25);
            this.botonMinimizar.TabIndex = 0;
            this.botonMinimizar.TabStop = false;
            this.botonMinimizar.Click += new System.EventHandler(this.botonMinimizar_Click);
            // 
            // botonMaximizar
            // 
            this.botonMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("botonMaximizar.Image")));
            this.botonMaximizar.Location = new System.Drawing.Point(1021, 4);
            this.botonMaximizar.Name = "botonMaximizar";
            this.botonMaximizar.Size = new System.Drawing.Size(25, 25);
            this.botonMaximizar.TabIndex = 0;
            this.botonMaximizar.TabStop = false;
            this.botonMaximizar.Click += new System.EventHandler(this.botonMaximizar_Click);
            // 
            // botonCerrar
            // 
            this.botonCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonCerrar.Image = ((System.Drawing.Image)(resources.GetObject("botonCerrar.Image")));
            this.botonCerrar.Location = new System.Drawing.Point(1052, 4);
            this.botonCerrar.Name = "botonCerrar";
            this.botonCerrar.Size = new System.Drawing.Size(25, 25);
            this.botonCerrar.TabIndex = 0;
            this.botonCerrar.TabStop = false;
            this.botonCerrar.Click += new System.EventHandler(this.botonCerrar_Click);
            // 
            // PresentacionPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 650);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.VentanaMenu);
            this.Controls.Add(this.panelCabeza);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PresentacionPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PresentacionPrincipal";
            this.panelCabeza.ResumeLayout(false);
            this.VentanaMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCabeza;
        private System.Windows.Forms.PictureBox botonRestaurar;
        private System.Windows.Forms.PictureBox botonMinimizar;
        private System.Windows.Forms.PictureBox botonMaximizar;
        private System.Windows.Forms.PictureBox botonCerrar;
        private System.Windows.Forms.Panel VentanaMenu;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Button botonRegistarPaciente;
        private System.Windows.Forms.PictureBox LogoHome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button botonConsultaBasal;
    }
}