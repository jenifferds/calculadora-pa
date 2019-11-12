using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        double valor1, valor2, R;
        char operacao;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void numero1_Click(object sender, EventArgs e)
        {
            label1.Text += 1;
            label2.Text += 1;
        }

        private void numero2_Click(object sender, EventArgs e)
        {
            label1.Text += 2;
            label2.Text += 2;

        }

        private void numero3_Click(object sender, EventArgs e)
        {
            label1.Text += 3;
            label2.Text += 3;
        }

        private void numero4_Click(object sender, EventArgs e)
        {
            label1.Text += 4;
            label2.Text += 4;
        }

        private void numero5_Click(object sender, EventArgs e)
        {
            label1.Text += 5;
            label2.Text += 5;
        }

        private void numero6_Click(object sender, EventArgs e)
        {
            label1.Text += 6;
            label2.Text += 6;
        }

        private void numero7_Click(object sender, EventArgs e)
        {
            label1.Text += 7;
            label2.Text += 7;
        }

        private void numero8_Click(object sender, EventArgs e)
        {
            label1.Text += 8;
            label2.Text += 8;
        }

        private void igual_Click(object sender, EventArgs e)
        {
            valor2 = double.Parse(label2.Text);
            switch (operacao)
            {
                case '+':
                    R = valor1 + valor2;
                    break;
                case '-':
                    R = valor1 - valor2;
                    break;
                case '*':
                    R = valor1 * valor2;
                    break;
                case '/':
                    if (valor2 != 0)
                    {
                        R = valor1 / valor2;
                    }
                    else
                    {
                        MessageBox.Show("invalido");
                    }
                    break;
            }

            label2.Text = R.ToString();
        }

        private void mais_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(label2.Text);
            label1.Text += "+";
            operacao = '+';
            label2.Clear();
        }

        private void menos_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(label2.Text);
            label1.Text += "-";
            operacao = '-';
            label2.Clear();
        }

        private void multiplicacao_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(label2.Text);
            label1.Text += "*";
            operacao = '*';
            label2.Clear();
        }

        private void divisao_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(label2.Text);
            label1.Text += "/";
            operacao = '/';
            label2.Clear();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
                label2.Text = label2.Text.Substring(0, label2.Text.Length - 1);
            }
            catch
            {


            }
        }

        private void numero9_Click(object sender, EventArgs e)
        {
            label1.Text += 9;
            label2.Text += 9;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            label1.Text += 0;
            label2.Text += 0;
        }
    }
}
