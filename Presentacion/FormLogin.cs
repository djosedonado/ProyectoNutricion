using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Logica;
using Entidad.Cache;

namespace Presentacion
{
    public partial class FormLogin : Form
    {
        public readonly ValidacionesPresentacion validaciones;
        public FormLogin()
        {
            InitializeComponent();
            validaciones = new ValidacionesPresentacion();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if(textBoxEmail.Text == "Email")
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.LightGray;
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text=="")
            {
                textBoxEmail.Text = "Email";
                textBoxEmail.ForeColor = Color.DimGray;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Password")
            {
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = Color.LightGray;
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "Password";
                textBoxPassword.ForeColor = Color.LightGray;
                textBoxPassword.UseSystemPasswordChar = false;
            }
        }

        private void pictureBoxCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonSession_Click(object sender, EventArgs e)
        {
            Continuar();
        }

        private void MessegeError(string message)
        {
            labelError.Text = "     "+message;
            labelError.Visible = true;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister register = new FormRegister();
            register.Show();
            this.Hide();
        }

        private void Logoup(object sender, FormClosedEventArgs e)
        {
            textBoxEmail.Text = "Email";
            textBoxPassword.UseSystemPasswordChar = false;
            textBoxPassword.Text = "Password";
            labelError.Visible = false;
            this.Show();
        }

        private void buttonSession_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Continuar();
            }
        }

        private void Continuar()
        {
            if (textBoxEmail.Text != "Email")
            {
                pictureBoxErrorEmail.Visible = false;
                if (textBoxPassword.Text != "Password")
                {
                    pictureBoxErrorPassword.Visible = false;
                    personServices personServices = new personServices();
                    var respose = personServices.LoginPerson(textBoxEmail.Text, textBoxPassword.Text);
                    if (respose == true)
                    {
                        if (validaciones.ValidacionEmail(textBoxEmail.Text) == false)
                        {
                            labelError.Text = "Direccion de Correo Invalida";
                        }
                        else
                        {
                            if (UserLoginCache.Rol==1) 
                            {
                                PresentacionPrincipal mainMenu = new PresentacionPrincipal();
                                mainMenu.Show();
                                mainMenu.FormClosed += Logoup;
                                this.Hide();
                            }else if (UserLoginCache.Rol==0)
                            {
                                FormCliente formCliente = new FormCliente();
                                formCliente.Show();
                                formCliente.FormClosed += Logoup;
                                this.Hide();
                            }
                            
                        }
                    }
                    else
                    {
                        MessegeError("Correo o Contraseña Incorrecta");
                        textBoxPassword.Text = "Password";
                        textBoxPassword.Focus();
                    }
                }
                else
                {
                    MessegeError("Ingrese su Password");
                    pictureBoxErrorPassword.Visible = true;
                }

            }
            else
            {
                MessegeError("Ingrese su Email");
                pictureBoxErrorEmail.Visible = true;
            }
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Continuar();
            }
        }

        private void textBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Continuar();
            }
        }
    }
}
