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
    public partial class RecomendacionNutricional : Form
    {
        public serviceDeportista service;
        public List<Deportista> deportistas;
        public RecomendacionNutricional()
        {
            service = new serviceDeportista(CadenaConexion.ConnectionString);
            InitializeComponent();
            deportistas = new List<Deportista>();

        }

        private void botonGuardarRecomendacion_Click(object sender, EventArgs e)
        {
            if(textIdentificacionRecomendacion.Text.Equals("") || TextRecomendacionNutricional.Text.Equals("") || TextRecomendacionAlimentario.Text.Equals("") || comboBoxDieta.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Los campos estan Vacios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                Dieta dieta = MapearRecomendacion();
                string mensaje = service.GuardarDieta(dieta);
                MessageBox.Show(mensaje, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textIdentificacionRecomendacion.Text = "";
                textNombrePaciente.Text = "";
                TextRecomendacionAlimentario.Text = "";
                TextRecomendacionNutricional.Text = "";
            }
        }

        private Dieta MapearRecomendacion()
        {
            Dieta dieta = new Dieta();
            dieta.identificacion = textIdentificacionRecomendacion.Text;
            dieta.RecomendacionAlimentaria = TextRecomendacionAlimentario.Text;
            dieta.RecomendacionNutriccional = TextRecomendacionNutricional.Text;
            dieta.DiasAplicados = ListasDiasSemana.Text;
            return dieta;

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
                MostrarDatosPorIdentificacion();
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

        private void textPesoActual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255) || (e.KeyChar == 47))
            {
                MessageBox.Show("Solo se permiten Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void MostrarDatosPorIdentificacion()
        {
            ConsultarDeportistaRespuesta respuesta = new ConsultarDeportistaRespuesta();
            string identificacion = textIdentificacionRecomendacion.Text;
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


        private void llenartabla(List<Deportista> deportistas)
        {

            foreach (var item in deportistas)
            {
                textNombrePaciente.Text = $"{item.Nombre}  {item.Apellidó}";
            }

        }

    }
}
