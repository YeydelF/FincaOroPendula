using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos
{
    public class dtValidacionBox
    {
        int x = 0;
        public void ValidarTexto(int size, Label label7, KeyPressEventArgs e)
        {
            x = Convert.ToInt16(label7.Text);
            if (label7.Text == Convert.ToString(size) && e.KeyChar == (char)Keys.Back)
            {
                e.Handled = true;

            }
            else if (label7.Text == "0" && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;

            }

            else if (e.KeyChar == (char)Keys.Back)
            {
                x++;
                label7.Text = Convert.ToString(x);
            }
            else
            {
                x--;
                label7.Text = Convert.ToString(x);
            }
        }
        public void ValidacionSoloNumero(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public void ValidacionSoloLetra(KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
