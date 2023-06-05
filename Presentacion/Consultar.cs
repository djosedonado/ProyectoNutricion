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
    public partial class Consultar : Form
    {
        serviceDeportista service;
        List<Deportista> deportista;
        public Consultar()
        {
            service = new serviceDeportista();
            InitializeComponent();
            deportista = new List<Deportista>();
            MostrarDeportista();
        }

        private void Llenartable(List<Deportista> deportista)
        {
            dgvConsultaDatosPersonales.Rows.Clear();
            foreach (var item in deportista)
            {
                dgvConsultaDatosPersonales.Rows.Add(item.Identificacion);
            }
            dgvConsultaDatosPersonales.Refresh();
        }

        private void MostrarDeportista()
        {
            ConsultarDeportistaRespuesta respuesta = new ConsultarDeportistaRespuesta();
            dgvConsultaDatosPersonales.DataSource = null;
            respuesta = service.ConsultarTodos();
            deportista = respuesta.Deportistas.ToList();
            if (!respuesta.Error)
            {
                Llenartable(deportista);
            }
            else
            {
                MessageBox.Show("Error al consular");
            }
        }

        private void TextboxIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void MostrarDeportistaPorIdentificacion()
        {
            ConsultarDeportistaRespuesta respuesta = new ConsultarDeportistaRespuesta();
            dgvConsultaDatosPersonales.DataSource = null;
            string identificacion = TextboxIdentificacion.Text;
            respuesta = service.consultarPorIdentificacion(identificacion);
            deportista = respuesta.Deportistas.ToList();
            if (!respuesta.Error)
            {
                Llenartable(deportista);
            }
            else
            {
                MessageBox.Show("Error al consular");
            }
        }

        private void MostrarDeportistaPorNombre()
        {
            
            dgvConsultaDatosPersonales.DataSource = null;
            string nombre = textNombrePaciente.Text;
            ConsultarDeportista respuesta = new ConsultarDeportista(nombre);
            respuesta = service.BuscarPorNombreService(nombre);
            deportista = respuesta.Deportistas.ToList();
            if (!respuesta.Error)
            {
                Llenartable(deportista);
            }
            else
            {
                MessageBox.Show("Error al consular");
            }
        }

        private void buttonBuscarDeportista_Click(object sender, EventArgs e)
        {
            if (TextboxIdentificacion.Text.Equals(""))
            {
                MessageBox.Show("El campo de identificacion esta Vacio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MostrarDeportista();
            }
            else
            {
                MostrarDeportistaPorIdentificacion();
            }
            /*
            ConsultarPersonaRespuesta respuesta = new ConsultarPersonaRespuesta();
            dgvConsultaDatosPersonales.DataSource = null;
            respuesta = service.consultarPorIdentificacion(TextboxIdentificacion.Text);
            deportista = respuesta.Deportistas.ToList();
            dgvConsultaDatosPersonales.DataSource = deportista;
            */
        }

        private void dataGridViewConsultarDeportista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textNombrePaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            MostrarDeportistaPorNombre();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TextboxIdentificacion.Text.Equals(""))
            {
                MessageBox.Show("El campo de identificacion esta Vacio", "Mensaje de Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                new FormEditarDeportistas(TextboxIdentificacion.Text).Show();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("Está seguro de Eliminar la información", "Mensaje de Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                string mensaje = service.Eliminar(TextboxIdentificacion.Text);
                MessageBox.Show(mensaje, "Mensaje de Modificación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            MostrarDeportista();
        }
    }
}
