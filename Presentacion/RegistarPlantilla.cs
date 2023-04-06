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
    public partial class RegistarPlantilla : Form
    {
        serviceAlimento serviceAlimentos;
        ServicePlantilla servicePlantilla;
        List<Alimento> alimentos;
        List<Plantilla> plantillas;
        public RegistarPlantilla()
        {
            serviceAlimentos = new serviceAlimento(CadenaConexion.ConnectionString);
            servicePlantilla = new ServicePlantilla(CadenaConexion.ConnectionString);
            InitializeComponent();
            alimentos = new List<Alimento>();
            plantillas = new List<Plantilla>();
            MostrarTodos();
        }

        private void LlenarDataGriv(List<Plantilla> plantillas)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in plantillas)
            {
                dataGridView1.Rows.Add(item.NombrePlantilla,item.idAlimento,item.Categoria,item.Porcion);
            }
            dataGridView1.Refresh();
        }

        private void MostrarTodos()
        {
            ConsultarRespuestaPlantilla respuesta = new ConsultarRespuestaPlantilla();
            dataGridView1.DataSource = null;
            respuesta = servicePlantilla.Consultar();
            plantillas = respuesta.Plantillas.ToList();
            if (!respuesta.Error)
            {
                LlenarDataGriv(plantillas);
            }
            else
            {
                MessageBox.Show("Error al consular");
            }
        }

        private void LlenarCombobox(List<Alimento> alimentos)
        {
            
            comboBoxIngrediente.Items.Clear();
            foreach (var item in alimentos)
            {
                comboBoxIngrediente.Items.Add(item.NombreAlimento);
            }
            comboBoxIngrediente.Refresh();
        }

        private void MostrarAlimentos()
        {
            ConsultarAlimentoRespuesta respuesta = new ConsultarAlimentoRespuesta();
            comboBoxIngrediente.DataSource = null;
            respuesta = serviceAlimentos.consultarTodo();
            alimentos = respuesta.Alimentos.ToList();
            if (!respuesta.Error)
            {
                LlenarCombobox(alimentos);
                
            }
            else
            {
                MessageBox.Show(respuesta.Mensaje,"Alerta",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }


        private void comboBoxIngrediente_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConsultarAlimentoRespuesta respuesta = serviceAlimentos.FiltrarPorNombre(comboBoxIngrediente.Text);
            List<Alimento> alimentos = respuesta.Alimentos.ToList();
            foreach(var item in alimentos)
            {
                labelTotalCalorias.Text = item.Calorias.ToString();
                labelTotalCarbohidratos.Text = item.Carbohidratos.ToString();
                labelTotalProteinas.Text = item.Proteinas.ToString();
                labelTotalLiquidos.Text = item.Liquidos.ToString();
                comboBoxIngrediente.ValueMember = item.IdAlimentos.ToString();
            }
        }

        private void comboBoxIngrediente_Click(object sender, EventArgs e)
        {
            MostrarAlimentos();
            
        }

        private Plantilla MapearDatosPlantillas()
        {
            Plantilla plantilla = new Plantilla();
            plantilla.NombrePlantilla = textNombrePlantilla.Text;
            plantilla.Porcion = int.Parse(textBoxPorcion.Text);
            plantilla.Categoria = comboBoxCategoria.Text;
            plantilla.idAlimento = comboBoxIngrediente.ValueMember;
            Console.WriteLine(comboBoxIngrediente.ValueMember);
            return plantilla;
        }

        private void botonAgregarListado_Click(object sender, EventArgs e)
        {
            if (textNombrePlantilla.Equals("") || textBoxPorcion.Equals("") || comboBoxCategoria.Equals(-1) || comboBoxIngrediente.Equals(-1))
            {
                MessageBox.Show("Los campos estan Vacios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Plantilla plantilla = MapearDatosPlantillas();
                string Mensaje = servicePlantilla.Guardar(plantilla);
                MessageBox.Show(Mensaje, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
