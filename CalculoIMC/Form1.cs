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
            double v1 = 0;
            double v2 = 0;
            double resultado = 0;
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
            txtIMC.Text = resultado.ToString();
            if (resultado <= 18.5)
            {
                lblResultado.Text = ("Abaixo do peso").ToString();
                lblResultado.ForeColor = Color.Red;
            }
            else if (resultado >= 18.6 && resultado <= 24.90)
            {
                lblResultado.Text = ("Peso ideal, PARABÉNS!").ToString();
                lblResultado.ForeColor = Color.Green;
            }
            else if (resultado >= 25 && resultado <= 29.9)
            {
                lblResultado.Text = ("Levemente acima do peso").ToString();
                lblResultado.ForeColor = Color.OrangeRed;
            }
            else if (resultado >= 30 && resultado <= 34.9)
            {
                lblResultado.Text = ("Obesidade grau I").ToString();
                lblResultado.ForeColor = Color.Red;
            }
            else if (resultado >= 35 && resultado >= 39.9)
            {
                lblResultado.Text = ("Obesidade grau II").ToString();
                lblResultado.ForeColor = Color.Red;
            }
            else if (resultado >= 40)
            {             
                lblResultado.Text = ("Obesidade III (mórbida)").ToString();
                lblResultado.ForeColor = Color.Red;
            }
        }
    }
}