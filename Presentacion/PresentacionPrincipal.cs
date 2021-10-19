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
    public partial class PresentacionPrincipal : Form
    {
        public PresentacionPrincipal()
        {
            InitializeComponent();
        }

        private void PresentacionPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void mzButtonWindows1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new DeportistaGUI().Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Login().Show();
            Hide();
        }

        private void BotonMenu_Click(object sender, EventArgs e)
        {

        }

        private void linkRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Registro().Show();
            Hide();
        }
    }
}
