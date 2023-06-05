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
using Entidad.Cache;
using Logica;

namespace Presentacion
{
    public partial class Registro : Form
    {
        serviceDeportista service;
        private void Registro_Load(object sender, EventArgs e)
        {
            
        }
        public Registro()
        {
            InitializeComponent();
            service = new serviceDeportista();
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

        public Deportista MapearDeportista()
        {
            Deportista deportista = new Deportista();
            deportista.Identificacion = UserLoginCache.Id;
            deportista.Fecha_Nacimiento = UserLoginCache.Fecha_Nacimineto;
            deportista.Sexo = UserLoginCache.Sexo;
            deportista.Peso = double.Parse(textBoxPesoRegistar.Text);
            deportista.Altura = double.Parse(textBoxAlturaRegistar.Text);
            deportista.Deporte = textBoxDeporte.Text.ToUpper();
            deportista.TermogenesisActividadFisica = comboBoxTipoEntrenamiento.Text;
            deportista.FechaEgreso = DateTime.Now;
            return deportista;
        }

        private void BotonGuardarRegistro_Click_1(object sender, EventArgs e)
        {
            if (textBoxPesoRegistar.Text.Equals("") || textBoxAlturaRegistar.Text.Equals("") || textBoxDeporte.Text.Equals("") || comboBoxTipoEntrenamiento.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Debe llenar todas las casillas ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Deportista deportista = MapearDeportista();
                string mensaje = service.Guardar(deportista);
                MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                textBoxAlturaRegistar.Text = "";
                textBoxPesoRegistar.Text = "";
                textBoxDeporte.Text = "";
                comboBoxTipoEntrenamiento.SelectedIndex = -1;
            }
        }

        private void textBoxPesoRegistar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 58 && e.KeyChar <= 255) || (e.KeyChar <= 47 && e.KeyChar>=45))
            {
                MessageBox.Show("Solo se permiten Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBoxAlturaRegistar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 58 && e.KeyChar <= 255) || (e.KeyChar <= 47 && e.KeyChar >= 45))
            {
                MessageBox.Show("Solo se permiten Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBoxDeporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten Letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void comboBoxTipoEntrenamiento_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
