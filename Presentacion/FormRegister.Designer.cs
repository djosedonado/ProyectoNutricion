﻿namespace Presentacion
{
    partial class FormRegister
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
            this.panelRegisterUser = new System.Windows.Forms.Panel();
            this.panelAviso = new System.Windows.Forms.Panel();
            this.labelSave = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelError = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.dateTimePickerFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.comboBoxSexo = new System.Windows.Forms.ComboBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxEmial = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.comboBoxTipoIndetificacion = new System.Windows.Forms.ComboBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxIdentificacion = new System.Windows.Forms.TextBox();
            this.pictureBoxMinimizar = new System.Windows.Forms.PictureBox();
            this.pictureBoxCerrar = new System.Windows.Forms.PictureBox();
            this.panelRegisterUser.SuspendLayout();
            this.panelAviso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRegisterUser
            // 
            this.panelRegisterUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(52)))));
            this.panelRegisterUser.Controls.Add(this.panelAviso);
            this.panelRegisterUser.Controls.Add(this.dateTimePickerFechaNacimiento);
            this.panelRegisterUser.Controls.Add(this.comboBoxSexo);
            this.panelRegisterUser.Controls.Add(this.textBoxPassword);
            this.panelRegisterUser.Controls.Add(this.textBoxEmial);
            this.panelRegisterUser.Controls.Add(this.textBoxTelefono);
            this.panelRegisterUser.Controls.Add(this.textBoxApellido);
            this.panelRegisterUser.Controls.Add(this.comboBoxTipoIndetificacion);
            this.panelRegisterUser.Controls.Add(this.textBoxNombre);
            this.panelRegisterUser.Controls.Add(this.buttonRegistrar);
            this.panelRegisterUser.Controls.Add(this.label1);
            this.panelRegisterUser.Controls.Add(this.pictureBox1);
            this.panelRegisterUser.Controls.Add(this.textBoxIdentificacion);
            this.panelRegisterUser.Controls.Add(this.pictureBoxMinimizar);
            this.panelRegisterUser.Controls.Add(this.pictureBoxCerrar);
            this.panelRegisterUser.Location = new System.Drawing.Point(12, 12);
            this.panelRegisterUser.Name = "panelRegisterUser";
            this.panelRegisterUser.Size = new System.Drawing.Size(776, 426);
            this.panelRegisterUser.TabIndex = 0;
            this.panelRegisterUser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelRegisterUser_MouseDown);
            // 
            // panelAviso
            // 
            this.panelAviso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.panelAviso.Controls.Add(this.labelSave);
            this.panelAviso.Controls.Add(this.pictureBox2);
            this.panelAviso.Controls.Add(this.labelError);
            this.panelAviso.Controls.Add(this.labelTitulo);
            this.panelAviso.Location = new System.Drawing.Point(213, 100);
            this.panelAviso.Name = "panelAviso";
            this.panelAviso.Size = new System.Drawing.Size(350, 150);
            this.panelAviso.TabIndex = 12;
            // 
            // labelSave
            // 
            this.labelSave.AutoSize = true;
            this.labelSave.Location = new System.Drawing.Point(76, 49);
            this.labelSave.Name = "labelSave";
            this.labelSave.Size = new System.Drawing.Size(0, 13);
            this.labelSave.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Presentacion.Properties.Resources.continuar;
            this.pictureBox2.Location = new System.Drawing.Point(293, 106);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(14, 44);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(44, 20);
            this.labelError.TabIndex = 1;
            this.labelError.Text = "Error";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelTitulo.Location = new System.Drawing.Point(139, 2);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(70, 25);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Aviso";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimePickerFechaNacimiento
            // 
            this.dateTimePickerFechaNacimiento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaNacimiento.Location = new System.Drawing.Point(547, 107);
            this.dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            this.dateTimePickerFechaNacimiento.Size = new System.Drawing.Size(168, 22);
            this.dateTimePickerFechaNacimiento.TabIndex = 9;
            // 
            // comboBoxSexo
            // 
            this.comboBoxSexo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(52)))));
            this.comboBoxSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSexo.ForeColor = System.Drawing.Color.White;
            this.comboBoxSexo.FormattingEnabled = true;
            this.comboBoxSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.comboBoxSexo.Location = new System.Drawing.Point(347, 106);
            this.comboBoxSexo.Name = "comboBoxSexo";
            this.comboBoxSexo.Size = new System.Drawing.Size(144, 21);
            this.comboBoxSexo.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(52)))));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.White;
            this.textBoxPassword.Location = new System.Drawing.Point(347, 256);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(144, 26);
            this.textBoxPassword.TabIndex = 8;
            this.textBoxPassword.Text = "Password";
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            // 
            // textBoxEmial
            // 
            this.textBoxEmial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(52)))));
            this.textBoxEmial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmial.ForeColor = System.Drawing.Color.White;
            this.textBoxEmial.Location = new System.Drawing.Point(347, 203);
            this.textBoxEmial.Name = "textBoxEmial";
            this.textBoxEmial.Size = new System.Drawing.Size(144, 26);
            this.textBoxEmial.TabIndex = 7;
            this.textBoxEmial.Text = "Email";
            this.textBoxEmial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxEmial.Enter += new System.EventHandler(this.textBoxEmial_Enter);
            this.textBoxEmial.Leave += new System.EventHandler(this.textBoxEmial_Leave);
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(52)))));
            this.textBoxTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelefono.ForeColor = System.Drawing.Color.White;
            this.textBoxTelefono.Location = new System.Drawing.Point(347, 150);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(144, 26);
            this.textBoxTelefono.TabIndex = 6;
            this.textBoxTelefono.Text = "Telefono";
            this.textBoxTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxTelefono.Enter += new System.EventHandler(this.textBoxTelefono_Enter);
            this.textBoxTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTelefono_KeyPress);
            this.textBoxTelefono.Leave += new System.EventHandler(this.textBoxTelefono_Leave);
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(52)))));
            this.textBoxApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApellido.ForeColor = System.Drawing.Color.White;
            this.textBoxApellido.Location = new System.Drawing.Point(113, 256);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(144, 26);
            this.textBoxApellido.TabIndex = 4;
            this.textBoxApellido.Text = "Apellido";
            this.textBoxApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxApellido.Enter += new System.EventHandler(this.textBoxApellido_Enter);
            this.textBoxApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxApellido_KeyPress);
            this.textBoxApellido.Leave += new System.EventHandler(this.textBoxApellido_Leave);
            // 
            // comboBoxTipoIndetificacion
            // 
            this.comboBoxTipoIndetificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(52)))));
            this.comboBoxTipoIndetificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoIndetificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTipoIndetificacion.ForeColor = System.Drawing.Color.White;
            this.comboBoxTipoIndetificacion.FormattingEnabled = true;
            this.comboBoxTipoIndetificacion.Items.AddRange(new object[] {
            "CEDULA CIUDADANIA",
            "CEDULA EXTRAJERIA",
            "TARJETA DE IDENTIDAD"});
            this.comboBoxTipoIndetificacion.Location = new System.Drawing.Point(113, 106);
            this.comboBoxTipoIndetificacion.Name = "comboBoxTipoIndetificacion";
            this.comboBoxTipoIndetificacion.Size = new System.Drawing.Size(144, 21);
            this.comboBoxTipoIndetificacion.TabIndex = 1;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(52)))));
            this.textBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.ForeColor = System.Drawing.Color.White;
            this.textBoxNombre.Location = new System.Drawing.Point(113, 203);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(144, 26);
            this.textBoxNombre.TabIndex = 3;
            this.textBoxNombre.Text = "Nombre";
            this.textBoxNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNombre.Enter += new System.EventHandler(this.textBoxNombre_Enter);
            this.textBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombre_KeyPress);
            this.textBoxNombre.Leave += new System.EventHandler(this.textBoxNombre_Leave);
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.buttonRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.buttonRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrar.ForeColor = System.Drawing.Color.White;
            this.buttonRegistrar.Location = new System.Drawing.Point(576, 346);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(139, 36);
            this.buttonRegistrar.TabIndex = 0;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(306, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Registrate";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.atras;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // textBoxIdentificacion
            // 
            this.textBoxIdentificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(52)))));
            this.textBoxIdentificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdentificacion.ForeColor = System.Drawing.Color.White;
            this.textBoxIdentificacion.Location = new System.Drawing.Point(113, 150);
            this.textBoxIdentificacion.Name = "textBoxIdentificacion";
            this.textBoxIdentificacion.Size = new System.Drawing.Size(144, 26);
            this.textBoxIdentificacion.TabIndex = 2;
            this.textBoxIdentificacion.Text = "Identificacion";
            this.textBoxIdentificacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxIdentificacion.Enter += new System.EventHandler(this.textBoxIdentificacion_Enter);
            this.textBoxIdentificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdentificacion_KeyPress);
            this.textBoxIdentificacion.Leave += new System.EventHandler(this.textBoxIdentificacion_Leave);
            // 
            // pictureBoxMinimizar
            // 
            this.pictureBoxMinimizar.Image = global::Presentacion.Properties.Resources.borrar1;
            this.pictureBoxMinimizar.Location = new System.Drawing.Point(710, 3);
            this.pictureBoxMinimizar.Name = "pictureBoxMinimizar";
            this.pictureBoxMinimizar.Size = new System.Drawing.Size(28, 23);
            this.pictureBoxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinimizar.TabIndex = 1;
            this.pictureBoxMinimizar.TabStop = false;
            this.pictureBoxMinimizar.Click += new System.EventHandler(this.pictureBoxMinimizar_Click);
            // 
            // pictureBoxCerrar
            // 
            this.pictureBoxCerrar.Image = global::Presentacion.Properties.Resources.Invalido;
            this.pictureBoxCerrar.Location = new System.Drawing.Point(744, 0);
            this.pictureBoxCerrar.Name = "pictureBoxCerrar";
            this.pictureBoxCerrar.Size = new System.Drawing.Size(29, 26);
            this.pictureBoxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCerrar.TabIndex = 0;
            this.pictureBoxCerrar.TabStop = false;
            this.pictureBoxCerrar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelRegisterUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegister";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegister";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormRegister_MouseDown);
            this.panelRegisterUser.ResumeLayout(false);
            this.panelRegisterUser.PerformLayout();
            this.panelAviso.ResumeLayout(false);
            this.panelAviso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRegisterUser;
        private System.Windows.Forms.PictureBox pictureBoxMinimizar;
        private System.Windows.Forms.PictureBox pictureBoxCerrar;
        private System.Windows.Forms.TextBox textBoxIdentificacion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.ComboBox comboBoxTipoIndetificacion;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxEmial;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaNacimiento;
        private System.Windows.Forms.ComboBox comboBoxSexo;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Panel panelAviso;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelSave;
    }
}