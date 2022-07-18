using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoIMC
{
    public partial class FormIMC : Form
    {
        public FormIMC()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Variáveis para armazenar os valores do cálculo:
            double v1 = 0;
            double v2 = 0;
            double resultado = 0;
            // Verificação de campos "em branco":
            if (txtPeso.Text != "" && txtAltura.Text != "")
            {
                v1 = double.Parse(txtPeso.Text);
                v2 = double.Parse(txtAltura.Text);
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            if (v2 != 0)
            {
                resultado = (v1 / (v2 * v2));
            }
            // Aplicação de comando para definir casas decimais:
            txtIMC.Text = Math.Round(resultado, 2).ToString();
            // Calcular IMC e exibir as informações:
            if (resultado <= 18.5)
            {
                lblResultado.Text = ("Abaixo do peso");
                lblResultado.ForeColor = Color.Red;
            }
            else if (resultado >= 18.6 && resultado <= 24.90)
            {
                lblResultado.Text = ("Peso ideal, PARABÉNS!");
                lblResultado.ForeColor = Color.Green;
            }
            else if (resultado >= 25 && resultado <= 29.9)
            {
                lblResultado.Text = ("Levemente acima do peso");
                lblResultado.ForeColor = Color.OrangeRed;
            }
            else if (resultado >= 30 && resultado <= 34.9)
            {
                lblResultado.Text = ("Obesidade grau I");
                lblResultado.ForeColor = Color.Red;
            }
            else if (resultado >= 35 && resultado >= 39.9)
            {
                lblResultado.Text = ("Obesidade grau II");
                lblResultado.ForeColor = Color.Red;
            }
            else if (resultado >= 40)
            {             
                lblResultado.Text = ("Obesidade III (mórbida)");
                lblResultado.ForeColor = Color.Red;
            }
        }
    }
}