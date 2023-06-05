using Entidad;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormRegister : Form
    {
        public readonly ValidacionesPresentacion validaciones;
        public readonly personServices personServices;
        public FormRegister()
        {
            InitializeComponent();
            panelAviso.Visible = false;
            validaciones = new ValidacionesPresentacion();
            personServices = new personServices();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void textBoxIdentificacion_Enter(object sender, EventArgs e)
        {
            StyleTextBox("Identificacion", 1, textBoxIdentificacion);
        }

        private void textBoxIdentificacion_Leave(object sender, EventArgs e)
        {
            StyleTextBox("Identificacion", 2, textBoxIdentificacion);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormRegister_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelRegisterUser_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBoxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panelAviso.Visible = false;
        }

        private void textBoxIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.validacion(e, 1,panelAviso,labelError);
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.validacion(e, 2, panelAviso, labelError);
        }

        private void textBoxNombre_Enter(object sender, EventArgs e)
        {
            StyleTextBox("Nombre",1, textBoxNombre);
        }

        private void textBoxNombre_Leave(object sender, EventArgs e)
        {
            StyleTextBox("Nombre", 2,textBoxNombre);
        }

        private void StyleTextBox(string text,int tipo,TextBox textBox)
        {
            if (tipo == 1) {
                if (textBox.Text == text)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.LightGray;
                    if (text.Equals("Password")) { textBox.UseSystemPasswordChar = true; }
                }
            }else if (tipo == 2)
            {
                if (textBox.Text == "")
                {
                    textBox.Text = text;
                    textBox.ForeColor = Color.LightGray;
                    if (text.Equals("Password")) { textBox.UseSystemPasswordChar = false; }
                }
            }
        }

        private void textBoxApellido_Enter(object sender, EventArgs e)
        {
            StyleTextBox("Apellido",1,textBoxApellido);
        }

        private void textBoxApellido_Leave(object sender, EventArgs e)
        {
            StyleTextBox("Apellido", 2, textBoxApellido);
        }

        private void textBoxTelefono_Enter(object sender, EventArgs e)
        {
            StyleTextBox("Telefono", 1, textBoxTelefono);
        }

        private void textBoxTelefono_Leave(object sender, EventArgs e)
        {
            StyleTextBox("Telefono", 2, textBoxTelefono);
        }

        private void textBoxEmial_Enter(object sender, EventArgs e)
        {
            StyleTextBox("Email", 1, textBoxEmial);
        }

        private void textBoxEmial_Leave(object sender, EventArgs e)
        {
            StyleTextBox("Email", 2, textBoxEmial);
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            StyleTextBox("Password", 1, textBoxPassword);
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            StyleTextBox("Password", 2, textBoxPassword);
            
        }

        private void textBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.validacion(e, 2, panelAviso, labelError);
        }

        private void textBoxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.validacion(e, 1, panelAviso, labelError);
        }

        private Persona MaperarPerson()
        {
            Persona persona = new Persona();
            persona.id = textBoxIdentificacion.Text;
            persona.TipoId = comboBoxTipoIndetificacion.Text;
            persona.Nombre = textBoxNombre.Text;
            persona.Apellidó = textBoxApellido.Text;
            persona.Sexo = comboBoxSexo.Text;
            persona.Fecha_Nacimiento = DateTime.Parse(dateTimePickerFechaNacimiento.Text);
            persona.Telefono = textBoxTelefono.Text;
            persona.Correo = textBoxEmial.Text;
            persona.Password = textBoxPassword.Text;
            return persona;
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {

            if (validaciones.ValidacionEmail(textBoxEmial.Text) == false)
            {
                panelAviso.Visible = true;
                labelError.Text = "Error Direccion de correo Invalida";
            }
            else
            {
                if (textBoxIdentificacion.Text.Equals("Identificacion")
                    || textBoxNombre.Text.Equals("Nombre")
                    || textBoxApellido.Text.Equals("Apellido")
                    || textBoxTelefono.Text.Equals("Telefono")
                    || textBoxEmial.Text.Equals("Email")
                    || textBoxPassword.Text.Equals("Password")
                    || comboBoxSexo.SelectedIndex.Equals(-1)
                    || comboBoxTipoIndetificacion.SelectedIndex.Equals(-1))
                {
                    panelAviso.Visible = true;
                    labelError.Text = "Error hay campos vacios";
                }
                else
                {
                    Persona persona = MaperarPerson();
                    var message = personServices.RegisterPerson(persona);
                    panelAviso.Visible = true;
                    labelError.Text = message;
                    labelError.ForeColor = Color.White;
                }
            }
        }
    }
}
