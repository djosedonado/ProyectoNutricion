using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace Presentacion
{
    public partial class FormEditarDeportistas : Form
    {

        public List<Deportista> deportistas;
        public serviceDeportista service;
        private string id;
        public FormEditarDeportistas(string id)
        {
            
            service = new serviceDeportista();
            InitializeComponent();
            deportistas = new List<Deportista>();
            this.id = id;
            MostrarDatosPorIdentificacion();
        }
        private void llenartabla(List<Deportista> deportistas)
        {

            foreach (var item in deportistas)
            {
                textIdentificacion.Text = item.Identificacion.ToString();
                textNombre.Text = item.Nombre;
                textApellido.Text = item.Apellidó;
                textBoxCorreo.Text = item.Correo;
                textBoxDeporte.Text = item.Deporte;
                textBoxAlturaRegistar.Text = item.Altura.ToString();
                textTelefono.Text = item.Telefono;
                textBoxPesoRegistar.Text = item.Peso.ToString();
                
            }

        }
        private void MostrarDatosPorIdentificacion()
        {
            ConsultarDeportistaRespuesta respuesta = new ConsultarDeportistaRespuesta();
            string identificacion = this.id;
            respuesta = service.consultarPorIdentificacion(identificacion);
            deportistas = respuesta.Deportistas.ToList();
            if (!respuesta.Error)
            {
                llenartabla(deportistas);
            }
            else
            {
                MessageBox.Show("Error al consultar");
            }

        }

        public Deportista MapearDeportista()
        {
            Deportista deportista = new Deportista();
            deportista.TipoIdentificacion = comboBoxTipoIdentidad.Text;
            deportista.Identificacion = textIdentificacion.Text;
            deportista.Nombre = textNombre.Text.ToUpper();
            deportista.Apellidó = textApellido.Text.ToUpper();
            deportista.Fecha_Nacimiento = dateTimeEdad.Value;
            deportista.Sexo = comboSexo.Text;
            deportista.Telefono = textTelefono.Text;
            deportista.Correo = textBoxCorreo.Text;
            deportista.Peso = double.Parse(textBoxPesoRegistar.Text);
            deportista.Altura = double.Parse(textBoxAlturaRegistar.Text);
            deportista.Deporte = textBoxDeporte.Text.ToUpper();
            deportista.TermogenesisActividadFisica = comboBoxTipoEntrenamiento.Text;
            deportista.FechaEgreso = DateTime.Now;
            return deportista;
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void BotonGuardarRegistro_Click(object sender, EventArgs e)
        {
            
        }

        private void FormEditarDeportistas_Load(object sender, EventArgs e)
        {

        }

        private void BotonGuardarRegistro_Click_1(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("Está seguro de Modificar la información", "Mensaje de modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                Deportista deportista = MapearDeportista();
                string mensaje = service.Modificar(deportista,this.id);
                MessageBox.Show(mensaje, "Mensaje de Modificación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void textIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionNumerica(e);
        }

        private void textNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionLetras(e);
        }

        private void ValidacionLetras(KeyPressEventArgs e)
        {
            if ((e.KeyChar > 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten Letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void ValidacionNumerica(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionLetras(e);
        }

        private void textTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionNumerica(e);
        }

        private void ValidarNumerosDecimal(KeyPressEventArgs e)
        {
            
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 58 && e.KeyChar <= 255) || (e.KeyChar <= 47 && e.KeyChar >= 45))
            {
                MessageBox.Show("Solo se permiten Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            Console.WriteLine();
        }

        private void textBoxPesoRegistar_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumerosDecimal(e);
            
            Ragexp(@"^([0-9]{8})$",textBoxPesoRegistar,pictureBoxPeso);
        }

        private void textBoxAlturaRegistar_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumerosDecimal(e);
        }

        private void textBoxDeporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionLetras(e);
        }
        public void Ragexp(string re,TextBox tb,PictureBox pv)
        {
            Regex rager = new Regex(re);
            Console.WriteLine(rager.IsMatch(tb.Text));
            if (rager.IsMatch(tb.Text))
            {
                //pv.Image = Properties.Resources;

            }
            else
            {
                pv.Image = Properties.Resources.boton_cerrar;
            }
        }
    }
}
