 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolideportivoAdmin_Proj.Clases
{
    class ClsValidarCampos
    {
        public static void Letras(KeyPressEventArgs v){
            if (Char.IsLetter(v.KeyChar)){
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar)){
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar)){
                v.Handled = false;
            }
            else{
                v.Handled = true;
            }
        }

        public static void Numeros(KeyPressEventArgs v){
            if (Char.IsDigit(v.KeyChar)){
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar)){
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar)){
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
            }
        }
    }
}
