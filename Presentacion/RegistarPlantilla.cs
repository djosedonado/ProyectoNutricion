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
        List<Alimento> alimentos;
        public RegistarPlantilla()
        {
            serviceAlimentos = new serviceAlimento(CadenaConexion.ConnectionString);
            InitializeComponent();
            alimentos = new List<Alimento>();
            
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
            
        }

        private void comboBoxIngrediente_Click(object sender, EventArgs e)
        {
            MostrarAlimentos();
            
        }
    }
}
