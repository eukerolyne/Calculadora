using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class form_Caluladora : Form
    {
        public form_Caluladora()
        {
            InitializeComponent();
        }

        private void btn_Soma_Click(object sender, EventArgs e)
        {
            lbl_Resultado.Text = (Convert.ToDouble(txt_Num1.Text) + Convert.ToInt32(txt_Num2.Text)).ToString("N2");
            txt_Num1.Focus();
            txt_Num1.Clear();
            txt_Num2.Clear();
        }

        private void btn_Sub_Click(object sender, EventArgs e)
        {
            lbl_Resultado.Text = (Convert.ToDouble(txt_Num1.Text) - Convert.ToInt32(txt_Num2.Text)).ToString("N2");
            txt_Num1.Focus();
            txt_Num1.Clear();
            txt_Num2.Clear();
        }

        private void btn_Multi_Click(object sender, EventArgs e)
        {
            lbl_Resultado.Text = (Convert.ToDouble(txt_Num1.Text) * Convert.ToInt32(txt_Num2.Text)).ToString("N2");
            txt_Num1.Focus();
            txt_Num1.Clear();
            txt_Num2.Clear();
        }

        private void btn_Dividir_Click(object sender, EventArgs e)
        {
            lbl_Resultado.Text = (Convert.ToDouble(txt_Num1.Text) / Convert.ToDouble(txt_Num2.Text)).ToString("N2");
            txt_Num1.Focus();
            txt_Num1.Clear();
            txt_Num2.Clear();
        }
    }
}
