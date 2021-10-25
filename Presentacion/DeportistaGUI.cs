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
    public partial class DeportistaGUI : Form
    {
        public DeportistaGUI()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureRegresar_Click(object sender, EventArgs e)
        {
            new PresentacionPrincipal().Show();
            Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
