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
    public partial class RegistarAlimentos : Form
    {
        public serviceAlimento serviceAlimento;
        List<Alimento> alimentos;
        
        public RegistarAlimentos()
        {
            serviceAlimento = new serviceAlimento(CadenaConexion.ConnectionString);
            InitializeComponent();
            alimentos = new List<Alimento>();
            ConsultarData();
        }

        private void ConsultarData()
        {
            ConsultarAlimentoRespuesta respuesta = new ConsultarAlimentoRespuesta();
            dgvAlimentos.DataSource = null;
            respuesta = serviceAlimento.consultarTodo();
            alimentos = respuesta.Alimentos.ToList();
            dgvAlimentos.DataSource = respuesta.Alimentos;
        }

        private Alimento MaperarIdAlimentos()
        {
            Alimento alimento = new Alimento();
            alimento.IdAlimentos = textIdAlimento.Text;
            alimento.NombreAlimento = textAlimento.Text;
            alimento.Calorias = decimal.Parse(textCalorias.Text);
            alimento.Carbohidratos = decimal.Parse(textCarbohidratos.Text);
            alimento.Proteinas = decimal.Parse(textProteinas.Text);
            alimento.Liquidos = decimal.Parse(textLiquidos.Text);
            return alimento;
        }

        private void botonGuardarAlimentos_Click(object sender, EventArgs e)
        {
            if(textAlimento.Text.Equals("") || textCalorias.Text.Equals("") || textCarbohidratos.Text.Equals("") || textLiquidos.Text.Equals("") || textProteinas.Text.Equals(""))
            {
                MessageBox.Show("Los Campos esta Vacios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Alimento alimento = MaperarIdAlimentos();
                string mensaje = serviceAlimento.Guardar(alimento);
                MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                ConsultarData();
                textAlimento.Text = "";
                textIdAlimento.Text = "";
                textCalorias.Text = "";
                textCarbohidratos.Text = "";
                textLiquidos.Text = "";
                textProteinas.Text = "";
            }
        }

        private void textCalorias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 58 && e.KeyChar <= 255) || (e.KeyChar==45 && e.KeyChar==47))
            {
                MessageBox.Show("Solo se permiten Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textCarbohidratos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 58 && e.KeyChar <= 255) || (e.KeyChar == 45 && e.KeyChar == 47))
            {
                MessageBox.Show("Solo se permiten Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textProteinas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 58 && e.KeyChar <= 255) || (e.KeyChar == 45 && e.KeyChar == 47))
            {
                MessageBox.Show("Solo se permiten Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textLiquidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 58 && e.KeyChar <= 255) || (e.KeyChar == 45 && e.KeyChar == 47))
            {
                MessageBox.Show("Solo se permiten Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textAlimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten Letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void dgvAlimentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textIdAlimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 58 && e.KeyChar <= 255) || (e.KeyChar == 45 && e.KeyChar == 47))
            {
                MessageBox.Show("Solo se permiten Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
