using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Presentacion
{
    public partial class PresentacionPrincipal : Form
    {
        public PresentacionPrincipal()
        {
            InitializeComponent();
            abrirFormatoHija(new Home());
        }

        private void botonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void botonMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            botonMaximizar.Visible = false;
            botonRestaurar.Visible = true;
        }

        private void botonRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            botonRestaurar.Visible = false;
            botonMaximizar.Visible = true;
        }

        private void botonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelCabeza_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void abrirFormatoHija(object FormatoHija)
        {
            if (PanelContenedor.Controls.Count > 0)
                PanelContenedor.Controls.RemoveAt(0);

            Form formatohija = FormatoHija as Form;
            formatohija.TopLevel = false;
            formatohija.Dock = DockStyle.Fill;
            PanelContenedor.Controls.Add(formatohija);
            PanelContenedor.Tag = formatohija;
            formatohija.Show();
            
        }

        private void botonRegistarPaciente_Click(object sender, EventArgs e)
        {
            abrirFormatoHija(new Registro());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirFormatoHija(new Consultar());
        }

        private void LogoHome_Click(object sender, EventArgs e)
        {
            abrirFormatoHija(new Home());
        }

        private void botonConsultaBasal_Click(object sender, EventArgs e)
        {
            abrirFormatoHija(new TasaMetablistica());
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            botonRecomendacionNutricional.Visible = true;
            botonConsultaBasal.Visible = true;
        }
    }
}
