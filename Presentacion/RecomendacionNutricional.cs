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
    public partial class RecomendacionNutricional : Form
    {
        public RecomendacionNutricional()
        {
            InitializeComponent();
        }

        private void botonGuardarRecomendacion_Click(object sender, EventArgs e)
        {
            if(textIdentificacionRecomendacion.Text.Equals("") || TextRecomendacionNutricional.Text.Equals("") || TextRecomendacionAlimentario.Text.Equals("") || comboBoxDieta.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Los campos estan Vacios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Los datos estan Guardados Correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textIdentificacionRecomendacion.Text = "";
                textNombrePaciente.Text = "";
                TextRecomendacionAlimentario.Text = "";
                TextRecomendacionNutricional.Text = "";
            }
        }

        private void textIdentificacionRecomendacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void botonBuscarPaciente_Click(object sender, EventArgs e)
        {
            if (textIdentificacionRecomendacion.Text.Equals(""))
            {
                MessageBox.Show("Campo de Identificacion Vacio","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                textNombrePaciente.Text = "Danilo Donado";
            }
            
        }

        private void textPorcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void ContenedorRecomendacioNutricional_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
