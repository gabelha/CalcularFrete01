using CalcularFrete.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularFrete.View
{
    public partial class TelaFrete : Form
    {
        Frete frete = new Frete();

        public TelaFrete()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            if (cbuf.Text == string.Empty || txtvalor.Text == string.Empty || txtcliente.Text == string.Empty)
            {
                MessageBox.Show("Alguns campos não foram preenchidos", "Atenção");
            }
            else
            {
                string uf = cbuf.Text;
                decimal v = Convert.ToDecimal(txtvalor.Text);
                decimal vfrete = frete.Calcular(uf, v);
                decimal total = vfrete + v;

                decimal uffrete = (vfrete / total);

                txtfrete.Text = uffrete.ToString("P1");

                lblResultado.Text = "Estado: " + uf + "\nValor do Produto: R$ " + v + "\nValor Frete: R$ " + vfrete +
                    "\nValor Total: R$ " + total.ToString("N2");
            }
        }
    }
}
