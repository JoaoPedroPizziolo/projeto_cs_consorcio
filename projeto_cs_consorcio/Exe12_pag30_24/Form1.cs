using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe12_pag30_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btncalcule_Click(object sender, EventArgs e)
        {
            double montante, montante_final, capital, novo_valor, parcelas, juros;

            capital = double.Parse(txtvalor.Text);

            if (rdbA.Checked)
            {
                montante = capital * Math.Pow((1 + 0.018), 100);
                juros = montante - capital;
                parcelas = capital * 0.018;

                MessageBox.Show("seu juros sera de: " + juros.ToString("C") + "O valor total sera de: " + montante.ToString("C") + "o valor de cada parcela sera: " + parcelas.ToString("C");
            }
            else if (rdbB.Checked)
            {
                montante = capital * Math.Pow((1 + 0.025), 100);
                juros = montante - capital;
                parcelas = capital * 0.025;

                MessageBox.Show("seu juros sera de: " + juros.ToString("C") + "O valor total sera de: " + montante.ToString("C") + "o valor de cada parcela sera: " + parcelas.ToString("C");
            }
            else if (rdbC.Checked)
            {
                montante = capital * Math.Pow((1 + 0.035), 100);
                juros = montante - capital;
                parcelas = capital * 0.035;

                MessageBox.Show("seu juros sera de: " + juros.ToString("C") + "O valor total sera de: " + montante.ToString("C") + "o valor de cada parcela sera: " + parcelas.ToString("C");
            }
        }
    }
}
