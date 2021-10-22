﻿
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
            this.HomeContenedor = new System.Windows.Forms.Panel();
            this.botonRegistarPaciente = new System.Windows.Forms.Button();
            this.panelCabeza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonCerrar)).BeginInit();
            this.VentanaMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCabeza
            // 
            this.panelCabeza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelCabeza.Controls.Add(this.botonRestaurar);
            this.panelCabeza.Controls.Add(this.botonMinimizar);
            this.panelCabeza.Controls.Add(this.botonMaximizar);
            this.panelCabeza.Controls.Add(this.botonCerrar);
            this.panelCabeza.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabeza.Location = new System.Drawing.Point(0, 0);
            this.panelCabeza.Name = "panelCabeza";
            this.panelCabeza.Size = new System.Drawing.Size(1300, 35);
            this.panelCabeza.TabIndex = 0;
            this.panelCabeza.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            this.panelCabeza.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCabeza_MouseDown);
            // 
            // botonRestaurar
            // 
            this.botonRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("botonRestaurar.Image")));
            this.botonRestaurar.Location = new System.Drawing.Point(1241, 3);
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
            this.botonMinimizar.Location = new System.Drawing.Point(1210, 4);
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
            this.botonMaximizar.Location = new System.Drawing.Point(1241, 4);
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
            this.botonCerrar.Location = new System.Drawing.Point(1272, 4);
            this.botonCerrar.Name = "botonCerrar";
            this.botonCerrar.Size = new System.Drawing.Size(25, 25);
            this.botonCerrar.TabIndex = 0;
            this.botonCerrar.TabStop = false;
            this.botonCerrar.Click += new System.EventHandler(this.botonCerrar_Click);
            // 
            // VentanaMenu
            // 
            this.VentanaMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.VentanaMenu.Controls.Add(this.botonRegistarPaciente);
            this.VentanaMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.VentanaMenu.Location = new System.Drawing.Point(0, 35);
            this.VentanaMenu.Name = "VentanaMenu";
            this.VentanaMenu.Size = new System.Drawing.Size(200, 615);
            this.VentanaMenu.TabIndex = 1;
            // 
            // HomeContenedor
            // 
            this.HomeContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.HomeContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeContenedor.Location = new System.Drawing.Point(200, 35);
            this.HomeContenedor.Name = "HomeContenedor";
            this.HomeContenedor.Size = new System.Drawing.Size(1100, 615);
            this.HomeContenedor.TabIndex = 2;
            // 
            // botonRegistarPaciente
            // 
            this.botonRegistarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.botonRegistarPaciente.FlatAppearance.BorderSize = 0;
            this.botonRegistarPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.botonRegistarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRegistarPaciente.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRegistarPaciente.ForeColor = System.Drawing.Color.White;
            this.botonRegistarPaciente.Image = ((System.Drawing.Image)(resources.GetObject("botonRegistarPaciente.Image")));
            this.botonRegistarPaciente.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.botonRegistarPaciente.Location = new System.Drawing.Point(3, 119);
            this.botonRegistarPaciente.Name = "botonRegistarPaciente";
            this.botonRegistarPaciente.Size = new System.Drawing.Size(197, 38);
            this.botonRegistarPaciente.TabIndex = 0;
            this.botonRegistarPaciente.Text = "RegistarPaciente";
            this.botonRegistarPaciente.UseVisualStyleBackColor = false;
            // 
            // PresentacionPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.HomeContenedor);
            this.Controls.Add(this.VentanaMenu);
            this.Controls.Add(this.panelCabeza);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PresentacionPrincipal";
            this.Text = "PresentacionPrincipal";
            this.Load += new System.EventHandler(this.PresentacionPrincipal_Load);
            this.panelCabeza.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.botonRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonCerrar)).EndInit();
            this.VentanaMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCabeza;
        private System.Windows.Forms.PictureBox botonRestaurar;
        private System.Windows.Forms.PictureBox botonMinimizar;
        private System.Windows.Forms.PictureBox botonMaximizar;
        private System.Windows.Forms.PictureBox botonCerrar;
        private System.Windows.Forms.Panel VentanaMenu;
        private System.Windows.Forms.Panel HomeContenedor;
        private System.Windows.Forms.Button botonRegistarPaciente;
    }
}