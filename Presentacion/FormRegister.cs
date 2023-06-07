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
        public readonly serviceDeportista serviceDeportista;
        public bool continuar;
        public FormRegister()
        {
            InitializeComponent();
            panelAviso.Visible = false;
            validaciones = new ValidacionesPresentacion();
            serviceDeportista = new serviceDeportista();
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

        private Deportista MaperarPerson()
        {
            Deportista deportista = new Deportista();
            deportista.id = textBoxIdentificacion.Text.ToUpper();
            deportista.TipoId = comboBoxTipoIndetificacion.Text.ToUpper();
            deportista.Nombre = textBoxNombre.Text.ToUpper();
            deportista.Apellidó = textBoxApellido.Text.ToUpper();
            deportista.Sexo = comboBoxSexo.Text.ToUpper();
            deportista.Fecha_Nacimiento = DateTime.Parse(dateTimePickerFechaNacimiento.Text);
            deportista.Telefono = textBoxTelefono.Text.ToUpper();
            deportista.Correo = textBoxEmial.Text.ToUpper();
            deportista.Password = textBoxPassword.Text;
            deportista.Peso = double.Parse(textBoxPeso.Text);
            deportista.Altura = double.Parse(textBoxAltura.Text);
            deportista.Deporte = textBoxDeporte.Text.ToUpper();
            deportista.TermogenesisActividadFisica = comboBoxTipoEntrenamiento.Text.ToUpper();
            deportista.FechaEgreso = DateTime.Now;
            return deportista;
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GuardarDatos();
        }

        private void GuardarDatos()
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
                    panelRegistrarUserNext.Visible = true;
                    buttonNext.Visible = false;
                }
            }
        }

        private void buttonRegistrar_Click_1(object sender, EventArgs e)
        {
            if (textBoxPeso.Text.Equals("Peso")
                || textBoxAltura.Text.Equals("Altura")
                || textBoxDeporte.Text.Equals("Deporte")
                || comboBoxTipoEntrenamiento.SelectedIndex.Equals(-1))
            {
                panelAviso2.Visible = true;
                labelError2.Text = "Campos Vacios";
            }
            else
            {
                Deportista persona = MaperarPerson();
                var message = serviceDeportista.Guardar(persona);
                panelAviso2.Visible = true;
                labelError2.Text = message;
                labelError2.ForeColor = Color.White;
                LimpiarCampos();
            }
            
        }

        private void LimpiarCampos()
        {
            textBoxIdentificacion.Text = "Identificacion";
            textBoxNombre.Text = "Nombre";
            textBoxApellido.Text = "Apellido";
            textBoxPassword.Text = "Password";
            textBoxAltura.Text = "Altura";
            textBoxTelefono.Text = "Telefono";
            textBoxPeso.Text = "Peso";
            textBoxEmial.Text = "Email";
            textBoxDeporte.Text = "Deporte";
            comboBoxSexo.SelectedIndex = -1;
            comboBoxTipoEntrenamiento.SelectedIndex = -1;
            comboBoxTipoIndetificacion.SelectedIndex = -1;
        }

        private void textBoxPeso_Enter(object sender, EventArgs e)
        {
            StyleTextBox("Peso",1,textBoxPeso);
        }

        private void textBoxPeso_Leave(object sender, EventArgs e)
        {
            StyleTextBox("Peso", 2, textBoxPeso);
        }

        private void textBoxAltura_Enter(object sender, EventArgs e)
        {
            StyleTextBox("Altura", 1, textBoxAltura);
        }

        private void textBoxAltura_Leave(object sender, EventArgs e)
        {
            StyleTextBox("Altura", 2, textBoxAltura);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panelRegistrarUserNext.Visible = false;
            buttonNext.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panelAviso2.Visible = false;
        }

        private void textBoxIdentificacion_TextChanged(object sender, EventArgs e)
        {
            //changed
            continuar = validaciones.RangoCampos(textBoxIdentificacion,"Identificacion",labelIdentificacion,continuar,6);
        }

        private void textBoxDeporte_Enter(object sender, EventArgs e)
        {
            StyleTextBox("Deporte", 1, textBoxDeporte);
        }

        private void textBoxDeporte_Leave(object sender, EventArgs e)
        {
            StyleTextBox("Deporte", 2, textBoxDeporte);
        }

        private void textBoxDeporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.validacion(e, 2, panelAviso, labelError);
        }

        private void textBoxPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.validacion(e, 3, panelAviso, labelError);
        }

        private void textBoxAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.validacion(e, 3, panelAviso, labelError);
        }

        private void labelError2_Click(object sender, EventArgs e)
        {

        }
    }
}
