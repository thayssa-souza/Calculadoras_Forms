using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_forms
{
    public partial class Frm_Calc_Geral : Form
    {
        public Frm_Calc_Geral()
        {
            InitializeComponent();
        }

        private void textBox_number_TextChanged(object sender, EventArgs e)
        {
        }

        private void Frm_Calc_Geral_Load(object sender, EventArgs e)
        {
            textBox_number.Text = string.Empty;
            textBox_number.Focus();
        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            textBox_number.Text += "0";
        }

        private void btn_um_Click(object sender, EventArgs e)
        {
            textBox_number.Text += "1";
        }

        private void btn_dois_Click(object sender, EventArgs e)
        {
            textBox_number.Text += "2";
        }

        private void btn_tres_Click(object sender, EventArgs e)
        {
            textBox_number.Text += "3";
        }

        private void btn_quatro_Click(object sender, EventArgs e)
        {
            textBox_number.Text += "4";
        }

        private void btn_cinco_Click(object sender, EventArgs e)
        {
            textBox_number.Text += "5";
        }

        private void btn_seis_Click(object sender, EventArgs e)
        {
            textBox_number.Text += "6";
        }

        private void btn_sete_Click(object sender, EventArgs e)
        {
            textBox_number.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            textBox_number.Text += "8";
        }

        private void btn_nove_Click(object sender, EventArgs e)
        {
            textBox_number.Text += "9";
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            textBox_number.Text = string.Empty;
        }

        private void btn_soma_Click(object sender, EventArgs e)
        {
            textBox_number.Text += "+";
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            textBox_number.Text += "-";
        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            textBox_number.Text += "*";
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            textBox_number.Text += "/";
        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            DataTable Calc = new DataTable();
            var result = Calc.Compute(textBox_number.Text, "");
            textBox_number.Text = Convert.ToString(result);
        }
    }
}
