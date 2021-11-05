
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
            this.botonRestaurar = new System.Windows.Forms.PictureBox();
            this.botonMinimizar = new System.Windows.Forms.PictureBox();
            this.botonMaximizar = new System.Windows.Forms.PictureBox();
            this.botonCerrar = new System.Windows.Forms.PictureBox();
            this.VentanaMenu = new System.Windows.Forms.Panel();
            this.LogoHome = new System.Windows.Forms.PictureBox();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.botonRegistarPacinetes = new System.Windows.Forms.Button();
            this.botonAlimentos = new System.Windows.Forms.Button();
            this.SubMenuAlimentos = new System.Windows.Forms.Panel();
            this.subBotonRegistarAlimentos = new System.Windows.Forms.Button();
            this.subBotonRegistarDietas = new System.Windows.Forms.Button();
            this.botonConsultar = new System.Windows.Forms.Button();
            this.SubMenuConsultar = new System.Windows.Forms.Panel();
            this.subBotonConsultarDatosPacientes = new System.Windows.Forms.Button();
            this.subBotonConsultarTasaMetabolicaBasal = new System.Windows.Forms.Button();
            this.subBotonConsultarRecomendacionNutricional = new System.Windows.Forms.Button();
            this.panelCabeza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonCerrar)).BeginInit();
            this.VentanaMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoHome)).BeginInit();
            this.PanelLogo.SuspendLayout();
            this.SubMenuAlimentos.SuspendLayout();
            this.SubMenuConsultar.SuspendLayout();
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
            // VentanaMenu
            // 
            this.VentanaMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(164)))));
            this.VentanaMenu.Controls.Add(this.SubMenuConsultar);
            this.VentanaMenu.Controls.Add(this.botonConsultar);
            this.VentanaMenu.Controls.Add(this.SubMenuAlimentos);
            this.VentanaMenu.Controls.Add(this.botonAlimentos);
            this.VentanaMenu.Controls.Add(this.botonRegistarPacinetes);
            this.VentanaMenu.Controls.Add(this.PanelLogo);
            this.VentanaMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.VentanaMenu.Location = new System.Drawing.Point(0, 35);
            this.VentanaMenu.Name = "VentanaMenu";
            this.VentanaMenu.Size = new System.Drawing.Size(200, 615);
            this.VentanaMenu.TabIndex = 1;
            // 
            // LogoHome
            // 
            this.LogoHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogoHome.Image = global::Presentacion.Properties.Resources.Logo_NutriSoft;
            this.LogoHome.Location = new System.Drawing.Point(0, 0);
            this.LogoHome.Name = "LogoHome";
            this.LogoHome.Size = new System.Drawing.Size(200, 100);
            this.LogoHome.TabIndex = 1;
            this.LogoHome.TabStop = false;
            this.LogoHome.Click += new System.EventHandler(this.LogoHome_Click);
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
            // PanelLogo
            // 
            this.PanelLogo.Controls.Add(this.LogoHome);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(200, 100);
            this.PanelLogo.TabIndex = 8;
            // 
            // botonRegistarPacinetes
            // 
            this.botonRegistarPacinetes.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonRegistarPacinetes.FlatAppearance.BorderSize = 0;
            this.botonRegistarPacinetes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(133)))));
            this.botonRegistarPacinetes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRegistarPacinetes.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRegistarPacinetes.ForeColor = System.Drawing.Color.White;
            this.botonRegistarPacinetes.Location = new System.Drawing.Point(0, 100);
            this.botonRegistarPacinetes.Name = "botonRegistarPacinetes";
            this.botonRegistarPacinetes.Size = new System.Drawing.Size(200, 40);
            this.botonRegistarPacinetes.TabIndex = 9;
            this.botonRegistarPacinetes.Text = "Registar Paciente";
            this.botonRegistarPacinetes.UseVisualStyleBackColor = true;
            this.botonRegistarPacinetes.Click += new System.EventHandler(this.botonRegistarPacinetes_Click);
            // 
            // botonAlimentos
            // 
            this.botonAlimentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonAlimentos.FlatAppearance.BorderSize = 0;
            this.botonAlimentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(133)))));
            this.botonAlimentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAlimentos.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAlimentos.ForeColor = System.Drawing.Color.White;
            this.botonAlimentos.Location = new System.Drawing.Point(0, 140);
            this.botonAlimentos.Name = "botonAlimentos";
            this.botonAlimentos.Size = new System.Drawing.Size(200, 40);
            this.botonAlimentos.TabIndex = 10;
            this.botonAlimentos.Text = "Alimentos";
            this.botonAlimentos.UseVisualStyleBackColor = true;
            this.botonAlimentos.Click += new System.EventHandler(this.botonAlimentos_Click);
            // 
            // SubMenuAlimentos
            // 
            this.SubMenuAlimentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(164)))));
            this.SubMenuAlimentos.Controls.Add(this.subBotonRegistarDietas);
            this.SubMenuAlimentos.Controls.Add(this.subBotonRegistarAlimentos);
            this.SubMenuAlimentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubMenuAlimentos.Location = new System.Drawing.Point(0, 180);
            this.SubMenuAlimentos.Name = "SubMenuAlimentos";
            this.SubMenuAlimentos.Size = new System.Drawing.Size(200, 72);
            this.SubMenuAlimentos.TabIndex = 11;
            // 
            // subBotonRegistarAlimentos
            // 
            this.subBotonRegistarAlimentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.subBotonRegistarAlimentos.FlatAppearance.BorderSize = 0;
            this.subBotonRegistarAlimentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(133)))));
            this.subBotonRegistarAlimentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subBotonRegistarAlimentos.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subBotonRegistarAlimentos.ForeColor = System.Drawing.Color.White;
            this.subBotonRegistarAlimentos.Location = new System.Drawing.Point(0, 0);
            this.subBotonRegistarAlimentos.Name = "subBotonRegistarAlimentos";
            this.subBotonRegistarAlimentos.Size = new System.Drawing.Size(200, 35);
            this.subBotonRegistarAlimentos.TabIndex = 0;
            this.subBotonRegistarAlimentos.Text = "Registar Alimentos";
            this.subBotonRegistarAlimentos.UseVisualStyleBackColor = true;
            this.subBotonRegistarAlimentos.Click += new System.EventHandler(this.subBotonRegistarAlimentos_Click);
            // 
            // subBotonRegistarDietas
            // 
            this.subBotonRegistarDietas.Dock = System.Windows.Forms.DockStyle.Top;
            this.subBotonRegistarDietas.FlatAppearance.BorderSize = 0;
            this.subBotonRegistarDietas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(133)))));
            this.subBotonRegistarDietas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subBotonRegistarDietas.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subBotonRegistarDietas.ForeColor = System.Drawing.Color.White;
            this.subBotonRegistarDietas.Location = new System.Drawing.Point(0, 35);
            this.subBotonRegistarDietas.Name = "subBotonRegistarDietas";
            this.subBotonRegistarDietas.Size = new System.Drawing.Size(200, 35);
            this.subBotonRegistarDietas.TabIndex = 1;
            this.subBotonRegistarDietas.Text = "Registar Dietas";
            this.subBotonRegistarDietas.UseVisualStyleBackColor = true;
            this.subBotonRegistarDietas.Click += new System.EventHandler(this.subBotonRegistarDietas_Click);
            // 
            // botonConsultar
            // 
            this.botonConsultar.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonConsultar.FlatAppearance.BorderSize = 0;
            this.botonConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(133)))));
            this.botonConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonConsultar.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonConsultar.ForeColor = System.Drawing.Color.White;
            this.botonConsultar.Location = new System.Drawing.Point(0, 252);
            this.botonConsultar.Name = "botonConsultar";
            this.botonConsultar.Size = new System.Drawing.Size(200, 40);
            this.botonConsultar.TabIndex = 12;
            this.botonConsultar.Text = "Consultar";
            this.botonConsultar.UseVisualStyleBackColor = true;
            this.botonConsultar.Click += new System.EventHandler(this.botonConsultar_Click);
            // 
            // SubMenuConsultar
            // 
            this.SubMenuConsultar.Controls.Add(this.subBotonConsultarRecomendacionNutricional);
            this.SubMenuConsultar.Controls.Add(this.subBotonConsultarTasaMetabolicaBasal);
            this.SubMenuConsultar.Controls.Add(this.subBotonConsultarDatosPacientes);
            this.SubMenuConsultar.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubMenuConsultar.Location = new System.Drawing.Point(0, 292);
            this.SubMenuConsultar.Name = "SubMenuConsultar";
            this.SubMenuConsultar.Size = new System.Drawing.Size(200, 107);
            this.SubMenuConsultar.TabIndex = 13;
            // 
            // subBotonConsultarDatosPacientes
            // 
            this.subBotonConsultarDatosPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.subBotonConsultarDatosPacientes.FlatAppearance.BorderSize = 0;
            this.subBotonConsultarDatosPacientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(133)))));
            this.subBotonConsultarDatosPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subBotonConsultarDatosPacientes.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subBotonConsultarDatosPacientes.ForeColor = System.Drawing.Color.White;
            this.subBotonConsultarDatosPacientes.Location = new System.Drawing.Point(0, 0);
            this.subBotonConsultarDatosPacientes.Name = "subBotonConsultarDatosPacientes";
            this.subBotonConsultarDatosPacientes.Size = new System.Drawing.Size(200, 35);
            this.subBotonConsultarDatosPacientes.TabIndex = 0;
            this.subBotonConsultarDatosPacientes.Text = "Datos Personales Pacientes";
            this.subBotonConsultarDatosPacientes.UseVisualStyleBackColor = true;
            this.subBotonConsultarDatosPacientes.Click += new System.EventHandler(this.subBotonConsultarDatosPacientes_Click);
            // 
            // subBotonConsultarTasaMetabolicaBasal
            // 
            this.subBotonConsultarTasaMetabolicaBasal.Dock = System.Windows.Forms.DockStyle.Top;
            this.subBotonConsultarTasaMetabolicaBasal.FlatAppearance.BorderSize = 0;
            this.subBotonConsultarTasaMetabolicaBasal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(133)))));
            this.subBotonConsultarTasaMetabolicaBasal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subBotonConsultarTasaMetabolicaBasal.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subBotonConsultarTasaMetabolicaBasal.ForeColor = System.Drawing.Color.White;
            this.subBotonConsultarTasaMetabolicaBasal.Location = new System.Drawing.Point(0, 35);
            this.subBotonConsultarTasaMetabolicaBasal.Name = "subBotonConsultarTasaMetabolicaBasal";
            this.subBotonConsultarTasaMetabolicaBasal.Size = new System.Drawing.Size(200, 35);
            this.subBotonConsultarTasaMetabolicaBasal.TabIndex = 1;
            this.subBotonConsultarTasaMetabolicaBasal.Text = "Tasa Metabolistica Basal";
            this.subBotonConsultarTasaMetabolicaBasal.UseVisualStyleBackColor = true;
            this.subBotonConsultarTasaMetabolicaBasal.Click += new System.EventHandler(this.subBotonConsultarTasaMetabolicaBasal_Click);
            // 
            // subBotonConsultarRecomendacionNutricional
            // 
            this.subBotonConsultarRecomendacionNutricional.Dock = System.Windows.Forms.DockStyle.Top;
            this.subBotonConsultarRecomendacionNutricional.FlatAppearance.BorderSize = 0;
            this.subBotonConsultarRecomendacionNutricional.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(133)))));
            this.subBotonConsultarRecomendacionNutricional.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subBotonConsultarRecomendacionNutricional.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subBotonConsultarRecomendacionNutricional.ForeColor = System.Drawing.Color.White;
            this.subBotonConsultarRecomendacionNutricional.Location = new System.Drawing.Point(0, 70);
            this.subBotonConsultarRecomendacionNutricional.Name = "subBotonConsultarRecomendacionNutricional";
            this.subBotonConsultarRecomendacionNutricional.Size = new System.Drawing.Size(200, 35);
            this.subBotonConsultarRecomendacionNutricional.TabIndex = 2;
            this.subBotonConsultarRecomendacionNutricional.Text = "Recomendacion Nutricional";
            this.subBotonConsultarRecomendacionNutricional.UseVisualStyleBackColor = true;
            this.subBotonConsultarRecomendacionNutricional.Click += new System.EventHandler(this.subBotonConsultarRecomendacionNutricional_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.botonRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonCerrar)).EndInit();
            this.VentanaMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoHome)).EndInit();
            this.PanelLogo.ResumeLayout(false);
            this.SubMenuAlimentos.ResumeLayout(false);
            this.SubMenuConsultar.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox LogoHome;
        private System.Windows.Forms.Panel SubMenuConsultar;
        private System.Windows.Forms.Button subBotonConsultarRecomendacionNutricional;
        private System.Windows.Forms.Button subBotonConsultarTasaMetabolicaBasal;
        private System.Windows.Forms.Button subBotonConsultarDatosPacientes;
        private System.Windows.Forms.Button botonConsultar;
        private System.Windows.Forms.Panel SubMenuAlimentos;
        private System.Windows.Forms.Button subBotonRegistarDietas;
        private System.Windows.Forms.Button subBotonRegistarAlimentos;
        private System.Windows.Forms.Button botonAlimentos;
        private System.Windows.Forms.Button botonRegistarPacinetes;
        private System.Windows.Forms.Panel PanelLogo;
    }
}