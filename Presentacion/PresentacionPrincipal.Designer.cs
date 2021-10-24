
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
            this.button1 = new System.Windows.Forms.Button();
            this.botonHome = new System.Windows.Forms.Button();
            this.LogoHome = new System.Windows.Forms.PictureBox();
            this.botonRegistarPaciente = new System.Windows.Forms.Button();
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
            this.textPeso = new System.Windows.Forms.TextBox();
            this.textAltura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboDeporte = new System.Windows.Forms.ComboBox();
            this.comboHorasPracticas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureGuardar = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelCabeza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonCerrar)).BeginInit();
            this.VentanaMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoHome)).BeginInit();
            this.HomeContenedor.SuspendLayout();
            this.ContenidoRegistroPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGuardar)).BeginInit();
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
            this.ContenidoRegistroPaciente.Controls.Add(this.label5);
            this.ContenidoRegistroPaciente.Controls.Add(this.pictureGuardar);
            this.ContenidoRegistroPaciente.Controls.Add(this.label4);
            this.ContenidoRegistroPaciente.Controls.Add(this.label3);
            this.ContenidoRegistroPaciente.Controls.Add(this.comboHorasPracticas);
            this.ContenidoRegistroPaciente.Controls.Add(this.comboDeporte);
            this.ContenidoRegistroPaciente.Controls.Add(this.label2);
            this.ContenidoRegistroPaciente.Controls.Add(this.label1);
            this.ContenidoRegistroPaciente.Controls.Add(this.textAltura);
            this.ContenidoRegistroPaciente.Controls.Add(this.textPeso);
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
            this.ValidacionTerminos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ValidacionTerminos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidacionTerminos.ForeColor = System.Drawing.Color.White;
            this.ValidacionTerminos.Location = new System.Drawing.Point(261, 367);
            this.ValidacionTerminos.Name = "ValidacionTerminos";
            this.ValidacionTerminos.Size = new System.Drawing.Size(241, 21);
            this.ValidacionTerminos.TabIndex = 12;
            this.ValidacionTerminos.Text = "Acepte los terminos y condiciones";
            this.ValidacionTerminos.UseVisualStyleBackColor = true;
            this.ValidacionTerminos.CheckedChanged += new System.EventHandler(this.ValidacionTerminos_CheckedChanged);
            // 
            // comoboRegistroSexo
            // 
            this.comoboRegistroSexo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comoboRegistroSexo.FormattingEnabled = true;
            this.comoboRegistroSexo.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.comoboRegistroSexo.Location = new System.Drawing.Point(159, 260);
            this.comoboRegistroSexo.Name = "comoboRegistroSexo";
            this.comoboRegistroSexo.Size = new System.Drawing.Size(100, 21);
            this.comoboRegistroSexo.TabIndex = 11;
            // 
            // labelRegistroTelefono
            // 
            this.labelRegistroTelefono.AutoSize = true;
            this.labelRegistroTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistroTelefono.ForeColor = System.Drawing.Color.White;
            this.labelRegistroTelefono.Location = new System.Drawing.Point(89, 300);
            this.labelRegistroTelefono.Name = "labelRegistroTelefono";
            this.labelRegistroTelefono.Size = new System.Drawing.Size(64, 17);
            this.labelRegistroTelefono.TabIndex = 10;
            this.labelRegistroTelefono.Text = "Telefono";
            // 
            // textTelefono
            // 
            this.textTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTelefono.Location = new System.Drawing.Point(159, 300);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(100, 23);
            this.textTelefono.TabIndex = 9;
            // 
            // textEdad
            // 
            this.textEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdad.Location = new System.Drawing.Point(159, 222);
            this.textEdad.Name = "textEdad";
            this.textEdad.Size = new System.Drawing.Size(100, 23);
            this.textEdad.TabIndex = 8;
            // 
            // textApellido
            // 
            this.textApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApellido.Location = new System.Drawing.Point(159, 184);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(100, 23);
            this.textApellido.TabIndex = 7;
            // 
            // textNombre
            // 
            this.textNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.Location = new System.Drawing.Point(159, 146);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 23);
            this.textNombre.TabIndex = 6;
            // 
            // textIdentificacion
            // 
            this.textIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIdentificacion.Location = new System.Drawing.Point(159, 107);
            this.textIdentificacion.Name = "textIdentificacion";
            this.textIdentificacion.Size = new System.Drawing.Size(100, 23);
            this.textIdentificacion.TabIndex = 5;
            // 
            // labelRegistroSexo
            // 
            this.labelRegistroSexo.AutoSize = true;
            this.labelRegistroSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistroSexo.ForeColor = System.Drawing.Color.White;
            this.labelRegistroSexo.Location = new System.Drawing.Point(114, 260);
            this.labelRegistroSexo.Name = "labelRegistroSexo";
            this.labelRegistroSexo.Size = new System.Drawing.Size(39, 17);
            this.labelRegistroSexo.TabIndex = 4;
            this.labelRegistroSexo.Text = "Sexo";
            // 
            // labelRegistroEdad
            // 
            this.labelRegistroEdad.AutoSize = true;
            this.labelRegistroEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistroEdad.ForeColor = System.Drawing.Color.White;
            this.labelRegistroEdad.Location = new System.Drawing.Point(112, 222);
            this.labelRegistroEdad.Name = "labelRegistroEdad";
            this.labelRegistroEdad.Size = new System.Drawing.Size(41, 17);
            this.labelRegistroEdad.TabIndex = 3;
            this.labelRegistroEdad.Text = "Edad";
            // 
            // labelRegistroApellido
            // 
            this.labelRegistroApellido.AutoSize = true;
            this.labelRegistroApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistroApellido.ForeColor = System.Drawing.Color.White;
            this.labelRegistroApellido.Location = new System.Drawing.Point(95, 184);
            this.labelRegistroApellido.Name = "labelRegistroApellido";
            this.labelRegistroApellido.Size = new System.Drawing.Size(58, 17);
            this.labelRegistroApellido.TabIndex = 2;
            this.labelRegistroApellido.Text = "Apellido";
            // 
            // labelRegistroNombre
            // 
            this.labelRegistroNombre.AutoSize = true;
            this.labelRegistroNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistroNombre.ForeColor = System.Drawing.Color.White;
            this.labelRegistroNombre.Location = new System.Drawing.Point(95, 146);
            this.labelRegistroNombre.Name = "labelRegistroNombre";
            this.labelRegistroNombre.Size = new System.Drawing.Size(58, 17);
            this.labelRegistroNombre.TabIndex = 1;
            this.labelRegistroNombre.Text = "Nombre";
            // 
            // labelRegistroIdentificacion
            // 
            this.labelRegistroIdentificacion.AutoSize = true;
            this.labelRegistroIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistroIdentificacion.ForeColor = System.Drawing.Color.White;
            this.labelRegistroIdentificacion.Location = new System.Drawing.Point(63, 107);
            this.labelRegistroIdentificacion.Name = "labelRegistroIdentificacion";
            this.labelRegistroIdentificacion.Size = new System.Drawing.Size(90, 17);
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
            // textPeso
            // 
            this.textPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPeso.Location = new System.Drawing.Point(567, 257);
            this.textPeso.Name = "textPeso";
            this.textPeso.Size = new System.Drawing.Size(100, 23);
            this.textPeso.TabIndex = 13;
            // 
            // textAltura
            // 
            this.textAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAltura.Location = new System.Drawing.Point(567, 301);
            this.textAltura.Name = "textAltura";
            this.textAltura.Size = new System.Drawing.Size(100, 23);
            this.textAltura.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(516, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Peso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(516, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Altura";
            // 
            // comboDeporte
            // 
            this.comboDeporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDeporte.FormattingEnabled = true;
            this.comboDeporte.Items.AddRange(new object[] {
            "Futbol",
            "Tennis",
            "Atletismo",
            "Natacion",
            "Patinaje",
            "Ciclismo"});
            this.comboDeporte.Location = new System.Drawing.Point(567, 107);
            this.comboDeporte.Name = "comboDeporte";
            this.comboDeporte.Size = new System.Drawing.Size(145, 23);
            this.comboDeporte.TabIndex = 18;
            // 
            // comboHorasPracticas
            // 
            this.comboHorasPracticas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboHorasPracticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboHorasPracticas.FormattingEnabled = true;
            this.comboHorasPracticas.Items.AddRange(new object[] {
            "Entre 1 y 3 veces a la semana",
            "Entre 3 y 5 veces a la semana",
            "Entre 6 y 7 veces a la semana",
            "Entrenamiento fuerte y dos veces al dia"});
            this.comboHorasPracticas.Location = new System.Drawing.Point(567, 163);
            this.comboHorasPracticas.Name = "comboHorasPracticas";
            this.comboHorasPracticas.Size = new System.Drawing.Size(231, 23);
            this.comboHorasPracticas.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(497, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Deporte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(434, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Horas de practicas";
            // 
            // pictureGuardar
            // 
            this.pictureGuardar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.pictureGuardar.Enabled = false;
            this.pictureGuardar.Image = ((System.Drawing.Image)(resources.GetObject("pictureGuardar.Image")));
            this.pictureGuardar.Location = new System.Drawing.Point(349, 429);
            this.pictureGuardar.Name = "pictureGuardar";
            this.pictureGuardar.Size = new System.Drawing.Size(63, 66);
            this.pictureGuardar.TabIndex = 22;
            this.pictureGuardar.TabStop = false;
            this.pictureGuardar.Click += new System.EventHandler(this.pictureGuardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(351, 498);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Guardar";
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
            ((System.ComponentModel.ISupportInitialize)(this.LogoHome)).EndInit();
            this.HomeContenedor.ResumeLayout(false);
            this.ContenidoRegistroPaciente.ResumeLayout(false);
            this.ContenidoRegistroPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGuardar)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textAltura;
        private System.Windows.Forms.TextBox textPeso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboHorasPracticas;
        private System.Windows.Forms.ComboBox comboDeporte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureGuardar;
    }
}