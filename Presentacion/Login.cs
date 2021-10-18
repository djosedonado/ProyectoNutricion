using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }


        private void linkRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Registro().Show();
            Hide();
        }

        private void pictureContinuar_Click(object sender, EventArgs e)
        {
            new PresentacionPrincipal().Show();
            Hide();
        }

        private void pictureSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
