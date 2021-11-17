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
        public ServiceDeportista ServiceDeportista;
        List<Deportista> deportistas;

        public Consultar()
        {
            ServiceDeportista = new ServiceDeportista(CadenaConexion.ConnectionString);
            InitializeComponent();
            deportistas = new List<Deportista>();
            ConsultarData();
        }

        public void ConsultarData()
        {
            ConsultarDeportistaRespuesta respuesta = new ConsultarDeportistaRespuesta();
            dataGridViewConsultarDeportista.DataSource = null;
            respuesta = ServiceDeportista.ConsultarTodo();
            deportistas = respuesta.Deportistas.ToList();
            dataGridViewConsultarDeportista.DataSource = respuesta.Deportistas;
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
