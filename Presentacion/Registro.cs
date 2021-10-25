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
            new PresentacionPrincipal().Show();
            Hide();
        }

        private void abrirFormatoHija(object FormatoHija)
        {

            if (ContenedorPrincipal.Controls.Count > 0)
                ContenedorPrincipal.Controls.RemoveAt(0);

            Form formatohija = FormatoHija as Form;
            formatohija.TopLevel = false;
            formatohija.Dock = DockStyle.Fill;
            ContenedorPrincipal.Controls.Add(formatohija);
            ContenedorPrincipal.Tag = formatohija;
            formatohija.Show();
            PanelRegistro.Visible = false;
            
        }
        private void pictureContinuar_Click(object sender, EventArgs e)
        {
            abrirFormatoHija(new DeportistaGUI());
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
            //persona.Edad = int.Parse(textEdad.Text);
            persona.Telefono = textTelefono.Text;
            persona.Sexo = comboSexo.Text;
            MessageBox.Show("Datos guardados correctamente");
            pictureContinuar.Enabled = true;
        }

    }
}
