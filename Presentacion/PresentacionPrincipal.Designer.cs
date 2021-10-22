
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
            this.HomeContenedor = new System.Windows.Forms.Panel();
            this.ContenidoRegistroPaciente = new System.Windows.Forms.Panel();
            this.ValidacionTerminos = new System.Windows.Forms.CheckBox();
            this.comoboRegistroSexo = new System.Windows.Forms.ComboBox();
            this.labelRegistroTelefono = new System.Windows.Forms.Label();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.textEdad = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textIdentificacion = new System.Windows.Forms.TextBox();
            this.labelRegistroSexo = new System.Windows.Forms.Label();
            this.labelRegistroEdad = new System.Windows.Forms.Label();
            this.labelRegistroApellido = new System.Windows.Forms.Label();
            this.labelRegistroNombre = new System.Windows.Forms.Label();
            this.labelRegistroIdentificacion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.botonHome = new System.Windows.Forms.Button();
            this.LogoHome = new System.Windows.Forms.PictureBox();
            this.botonRegistarPaciente = new System.Windows.Forms.Button();
            this.botonRestaurar = new System.Windows.Forms.PictureBox();
            this.botonMinimizar = new System.Windows.Forms.PictureBox();
            this.botonMaximizar = new System.Windows.Forms.PictureBox();
            this.botonCerrar = new System.Windows.Forms.PictureBox();
            this.panelCabeza.SuspendLayout();
            this.VentanaMenu.SuspendLayout();
            this.HomeContenedor.SuspendLayout();
            this.ContenidoRegistroPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panelCabeza.Size = new System.Drawing.Size(1300, 35);
            this.panelCabeza.TabIndex = 0;
            this.panelCabeza.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            this.panelCabeza.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCabeza_MouseDown);
            // 
            // VentanaMenu
            // 
            this.VentanaMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(164)))));
            this.VentanaMenu.Controls.Add(this.button1);
            this.VentanaMenu.Controls.Add(this.botonHome);
            this.VentanaMenu.Controls.Add(this.LogoHome);
            this.VentanaMenu.Controls.Add(this.botonRegistarPaciente);
            this.VentanaMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.VentanaMenu.Location = new System.Drawing.Point(0, 35);
            this.VentanaMenu.Name = "VentanaMenu";
            this.VentanaMenu.Size = new System.Drawing.Size(200, 615);
            this.VentanaMenu.TabIndex = 1;
            // 
            // HomeContenedor
            // 
            this.HomeContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.HomeContenedor.Controls.Add(this.ContenidoRegistroPaciente);
            this.HomeContenedor.Controls.Add(this.pictureBox1);
            this.HomeContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeContenedor.Location = new System.Drawing.Point(200, 35);
            this.HomeContenedor.Name = "HomeContenedor";
            this.HomeContenedor.Size = new System.Drawing.Size(1100, 615);
            this.HomeContenedor.TabIndex = 2;
            // 
            // ContenidoRegistroPaciente
            // 
            this.ContenidoRegistroPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.ContenidoRegistroPaciente.Controls.Add(this.ValidacionTerminos);
            this.ContenidoRegistroPaciente.Controls.Add(this.comoboRegistroSexo);
            this.ContenidoRegistroPaciente.Controls.Add(this.labelRegistroTelefono);
            this.ContenidoRegistroPaciente.Controls.Add(this.textTelefono);
            this.ContenidoRegistroPaciente.Controls.Add(this.textEdad);
            this.ContenidoRegistroPaciente.Controls.Add(this.textApellido);
            this.ContenidoRegistroPaciente.Controls.Add(this.textNombre);
            this.ContenidoRegistroPaciente.Controls.Add(this.textIdentificacion);
            this.ContenidoRegistroPaciente.Controls.Add(this.labelRegistroSexo);
            this.ContenidoRegistroPaciente.Controls.Add(this.labelRegistroEdad);
            this.ContenidoRegistroPaciente.Controls.Add(this.labelRegistroApellido);
            this.ContenidoRegistroPaciente.Controls.Add(this.labelRegistroNombre);
            this.ContenidoRegistroPaciente.Controls.Add(this.labelRegistroIdentificacion);
            this.ContenidoRegistroPaciente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenidoRegistroPaciente.Location = new System.Drawing.Point(0, 0);
            this.ContenidoRegistroPaciente.Name = "ContenidoRegistroPaciente";
            this.ContenidoRegistroPaciente.Size = new System.Drawing.Size(1100, 615);
            this.ContenidoRegistroPaciente.TabIndex = 0;
            this.ContenidoRegistroPaciente.Visible = false;
            // 
            // ValidacionTerminos
            // 
            this.ValidacionTerminos.AutoSize = true;
            this.ValidacionTerminos.ForeColor = System.Drawing.Color.White;
            this.ValidacionTerminos.Location = new System.Drawing.Point(180, 395);
            this.ValidacionTerminos.Name = "ValidacionTerminos";
            this.ValidacionTerminos.Size = new System.Drawing.Size(186, 17);
            this.ValidacionTerminos.TabIndex = 12;
            this.ValidacionTerminos.Text = "Acepte los terminos y condiciones";
            this.ValidacionTerminos.UseVisualStyleBackColor = true;
            // 
            // comoboRegistroSexo
            // 
            this.comoboRegistroSexo.FormattingEnabled = true;
            this.comoboRegistroSexo.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.comoboRegistroSexo.Location = new System.Drawing.Point(193, 306);
            this.comoboRegistroSexo.Name = "comoboRegistroSexo";
            this.comoboRegistroSexo.Size = new System.Drawing.Size(100, 21);
            this.comoboRegistroSexo.TabIndex = 11;
            // 
            // labelRegistroTelefono
            // 
            this.labelRegistroTelefono.AutoSize = true;
            this.labelRegistroTelefono.ForeColor = System.Drawing.Color.White;
            this.labelRegistroTelefono.Location = new System.Drawing.Point(117, 346);
            this.labelRegistroTelefono.Name = "labelRegistroTelefono";
            this.labelRegistroTelefono.Size = new System.Drawing.Size(49, 13);
            this.labelRegistroTelefono.TabIndex = 10;
            this.labelRegistroTelefono.Text = "Telefono";
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(193, 346);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(100, 20);
            this.textTelefono.TabIndex = 9;
            // 
            // textEdad
            // 
            this.textEdad.Location = new System.Drawing.Point(193, 268);
            this.textEdad.Name = "textEdad";
            this.textEdad.Size = new System.Drawing.Size(100, 20);
            this.textEdad.TabIndex = 8;
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(193, 230);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(100, 20);
            this.textApellido.TabIndex = 7;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(193, 192);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 20);
            this.textNombre.TabIndex = 6;
            // 
            // textIdentificacion
            // 
            this.textIdentificacion.Location = new System.Drawing.Point(193, 153);
            this.textIdentificacion.Name = "textIdentificacion";
            this.textIdentificacion.Size = new System.Drawing.Size(100, 20);
            this.textIdentificacion.TabIndex = 5;
            // 
            // labelRegistroSexo
            // 
            this.labelRegistroSexo.AutoSize = true;
            this.labelRegistroSexo.ForeColor = System.Drawing.Color.White;
            this.labelRegistroSexo.Location = new System.Drawing.Point(117, 306);
            this.labelRegistroSexo.Name = "labelRegistroSexo";
            this.labelRegistroSexo.Size = new System.Drawing.Size(31, 13);
            this.labelRegistroSexo.TabIndex = 4;
            this.labelRegistroSexo.Text = "Sexo";
            // 
            // labelRegistroEdad
            // 
            this.labelRegistroEdad.AutoSize = true;
            this.labelRegistroEdad.ForeColor = System.Drawing.Color.White;
            this.labelRegistroEdad.Location = new System.Drawing.Point(116, 268);
            this.labelRegistroEdad.Name = "labelRegistroEdad";
            this.labelRegistroEdad.Size = new System.Drawing.Size(32, 13);
            this.labelRegistroEdad.TabIndex = 3;
            this.labelRegistroEdad.Text = "Edad";
            // 
            // labelRegistroApellido
            // 
            this.labelRegistroApellido.AutoSize = true;
            this.labelRegistroApellido.ForeColor = System.Drawing.Color.White;
            this.labelRegistroApellido.Location = new System.Drawing.Point(117, 230);
            this.labelRegistroApellido.Name = "labelRegistroApellido";
            this.labelRegistroApellido.Size = new System.Drawing.Size(44, 13);
            this.labelRegistroApellido.TabIndex = 2;
            this.labelRegistroApellido.Text = "Apellido";
            // 
            // labelRegistroNombre
            // 
            this.labelRegistroNombre.AutoSize = true;
            this.labelRegistroNombre.ForeColor = System.Drawing.Color.White;
            this.labelRegistroNombre.Location = new System.Drawing.Point(116, 192);
            this.labelRegistroNombre.Name = "labelRegistroNombre";
            this.labelRegistroNombre.Size = new System.Drawing.Size(44, 13);
            this.labelRegistroNombre.TabIndex = 1;
            this.labelRegistroNombre.Text = "Nombre";
            // 
            // labelRegistroIdentificacion
            // 
            this.labelRegistroIdentificacion.AutoSize = true;
            this.labelRegistroIdentificacion.ForeColor = System.Drawing.Color.White;
            this.labelRegistroIdentificacion.Location = new System.Drawing.Point(116, 153);
            this.labelRegistroIdentificacion.Name = "labelRegistroIdentificacion";
            this.labelRegistroIdentificacion.Size = new System.Drawing.Size(70, 13);
            this.labelRegistroIdentificacion.TabIndex = 0;
            this.labelRegistroIdentificacion.Text = "Identificacion";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.HomeImagen1;
            this.pictureBox1.Location = new System.Drawing.Point(261, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(579, 483);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
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
            this.button1.Location = new System.Drawing.Point(3, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = " Consultar Paciente";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // botonHome
            // 
            this.botonHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(164)))));
            this.botonHome.FlatAppearance.BorderSize = 0;
            this.botonHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(133)))));
            this.botonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonHome.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonHome.ForeColor = System.Drawing.Color.White;
            this.botonHome.Image = global::Presentacion.Properties.Resources.home__1_;
            this.botonHome.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.botonHome.Location = new System.Drawing.Point(3, 109);
            this.botonHome.Name = "botonHome";
            this.botonHome.Size = new System.Drawing.Size(197, 38);
            this.botonHome.TabIndex = 2;
            this.botonHome.Text = "Home";
            this.botonHome.UseVisualStyleBackColor = false;
            this.botonHome.Click += new System.EventHandler(this.botonHome_Click);
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
            // 
            // botonRegistarPaciente
            // 
            this.botonRegistarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(164)))));
            this.botonRegistarPaciente.FlatAppearance.BorderSize = 0;
            this.botonRegistarPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(133)))));
            this.botonRegistarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRegistarPaciente.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRegistarPaciente.ForeColor = System.Drawing.Color.White;
            this.botonRegistarPaciente.Image = global::Presentacion.Properties.Resources.usuario;
            this.botonRegistarPaciente.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.botonRegistarPaciente.Location = new System.Drawing.Point(1, 153);
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
            this.VentanaMenu.ResumeLayout(false);
            this.HomeContenedor.ResumeLayout(false);
            this.ContenidoRegistroPaciente.ResumeLayout(false);
            this.ContenidoRegistroPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel HomeContenedor;
        private System.Windows.Forms.Button botonRegistarPaciente;
        private System.Windows.Forms.Panel ContenidoRegistroPaciente;
        private System.Windows.Forms.Label labelRegistroIdentificacion;
        private System.Windows.Forms.Label labelRegistroApellido;
        private System.Windows.Forms.Label labelRegistroNombre;
        private System.Windows.Forms.Label labelRegistroEdad;
        private System.Windows.Forms.Label labelRegistroSexo;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.TextBox textEdad;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textIdentificacion;
        private System.Windows.Forms.Label labelRegistroTelefono;
        private System.Windows.Forms.ComboBox comoboRegistroSexo;
        private System.Windows.Forms.PictureBox LogoHome;
        private System.Windows.Forms.CheckBox ValidacionTerminos;
        private System.Windows.Forms.Button botonHome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}