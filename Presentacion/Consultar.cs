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
            service = new serviceDeportista(CadenaConexion.ConnectionString);
            InitializeComponent();
            deportista = new List<Deportista>();
            //ConsultarDatos();
            MostrarDeportista();
        }

        private void ConsultarDatos()
        {
            ConsultarPersonaRespuesta respuesta = new ConsultarPersonaRespuesta();
            dgvConsultaDatosPersonales.DataSource = null;
            respuesta = service.ConsultarTodos();
            deportista = respuesta.Deportistas.ToList();
            dgvConsultaDatosPersonales.DataSource = deportista;
        }

        private void Llenartable(List<Deportista> deportistas)
        {
            dgvConsultaDatosPersonales.Rows.Clear();
            foreach (var item in deportista)
            {
                dgvConsultaDatosPersonales.Rows.Add(item.Identificacion,item.Nombre,item.Apellidó,item.Edad,item.Sexo,item.Telefono);
            }
            dgvConsultaDatosPersonales.Refresh();
        }

        private void MostrarDeportista()
        {
            ConsultarPersonaRespuesta respuesta = new ConsultarPersonaRespuesta();
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


        private void buttonBuscarDeportista_Click(object sender, EventArgs e)
        {
            if (TextboxIdentificacion.Text.Equals("") && textNombrePaciente.Text.Equals(""))
            {
                MessageBox.Show("Los Campos esta Vacios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewConsultarDeportista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
