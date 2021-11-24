using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace Presentacion
{
    public partial class RegistarPlantilla : Form
    {
        serviceAlimento serviceAlimentos;
        public RegistarPlantilla()
        {
            serviceAlimentos = new serviceAlimento(CadenaConexion.ConnectionString);
            InitializeComponent();
        }

        private void consultarAlimentos()
        {

        }

        private void textNombrePlantilla_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
