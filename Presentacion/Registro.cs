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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void pictureRegresar_Click(object sender, EventArgs e)
        {
            new Login().Show();
            Hide();
        }

        private void pictureContinuar_Click(object sender, EventArgs e)
        {
            new Login().Show();
            Hide();
        }
    }
}
