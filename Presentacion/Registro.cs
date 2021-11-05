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

        private void botonSiguiente_Click_1(object sender, EventArgs e)
        {
            
            if (textIdentificacion.Text.Equals("") || textNombre.Text.Equals("") || textApellido.Text.Equals("") || textEdad.Text.Equals("") || textTelefono.Text.Equals("") || comboSexo.SelectedIndex.Equals(-1) || comboBoxTipoIdentidad.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Debe llenar todas las casillas ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                ContenedorSegundario.Visible = true;
            }
            
        }

        private void textIdentificacion_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textNombre_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten Letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten Letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void BotonGuardarRegistro_Click(object sender, EventArgs e)
        {
            if (textBoxPesoRegistar.Text.Equals("") || textBoxAlturaRegistar.Text.Equals("") || textBoxDeporte.Text.Equals("") || comboBoxTipoEntrenamiento.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Debe llenar todas las casillas ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                MessageBox.Show("Se a Guardado los datos correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textNombre.Text = "";
                textApellido.Text = "";
                textIdentificacion.Text = "";
                textEdad.Text = "";
                textTelefono.Text = "";
                comboSexo.SelectedIndex = -1;
                textBoxAlturaRegistar.Text = "";
                textBoxPesoRegistar.Text = "";
                textBoxDeporte.Text = "";
                comboBoxTipoEntrenamiento.SelectedIndex = -1;
                comboBoxTipoIdentidad.SelectedIndex = -1;
                ContenedorPrincipal.Visible = true;
                ContenedorSegundario.Visible = false;
            }
        }

        private void textBoxPesoRegistar_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBoxAlturaRegistar_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBoxDeporte_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten Letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
