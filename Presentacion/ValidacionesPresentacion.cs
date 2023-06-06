using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public class ValidacionesPresentacion
    {
        public bool ValidacionEmail(string comprobarEmail)
        {
            string emailForm;
            emailForm = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.IsMatch(comprobarEmail, emailForm))
            {
                if (Regex.Replace(comprobarEmail, emailForm, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }

        //validacion de rango
        public void RangoCampos(TextBox textBox,string text,Label label,bool continuar)
        {
            
            if (textBox.Text != text && textBox.Text != "")
            {
                continuar = false;
                if (textBox.Text.Length < 6)
                {
                    label.Visible = true;
                    label.ForeColor = Color.Red;
                    label.Text = text+ " Rango mino 6";
                    continuar = true;
                }
                else
                {
                   label.Visible = false;
                }
            }
        }

        //Validaciones por keyPress
        public void validacion(KeyPressEventArgs e, int tipo,Panel panelAviso,Label labelError)
        {
            if (tipo == 1)
            {
                //solo permite numeros
                if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
                {
                    panelAviso.Visible = true;
                    labelError.Text = "ERROR SOLO SE PERMITE NUMEROS";
                    e.Handled = true;
                    return;
                }
            }
            if (tipo == 2)
            {
                //tipo 2 solo permite letras
                if ((e.KeyChar > 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
                {
                    panelAviso.Visible = true;
                    labelError.Text = "ERROR SOLO SE PERMITE LETRAS";
                    e.Handled = true;
                    return;
                }
            }
            if (tipo == 3)
            {
                //decimales para tomar las comas 
                if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 58 && e.KeyChar <= 255) || (e.KeyChar <= 47 && e.KeyChar >= 45))
                {
                    panelAviso.Visible = true;
                    labelError.Text = "Solo se permiten Numeros";
                    e.Handled = true;
                    return;
                }
            }


        }
    }
}
