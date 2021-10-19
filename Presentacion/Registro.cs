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
        private void checkTerminoCondiciones_CheckedChanged(object sender, EventArgs e)
        {
            pictureGuardar.Enabled = true;
        }
        private void pictureGuardar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Identificacion = textIdentificacion.Text;
            persona.Nombre = textNombre.Text;
            persona.Apellidó = textApellido.Text;
            persona.Edad = int.Parse(textEdad.Text);
            persona.Telefono = textTelefono.Text;
            persona.Sexo = comboSexo.Text;
            persona.Tipo = comboTipo.Text;
            MessageBox.Show("Datos guardados correctamente");
            pictureContinuar.Enabled = true;
        }

    }
}
