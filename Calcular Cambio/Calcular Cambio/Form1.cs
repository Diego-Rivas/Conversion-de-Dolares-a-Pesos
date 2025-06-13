using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcular_Cambio
{
    public partial class Form1 : Form
    {
        double cantDi, costoArt, cambio;

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCostArt.Clear();
            txtEntrega.Clear();
            txtResultado.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            cantDi = double.Parse(txtEntrega.Text);
            costoArt = double.Parse(txtCostArt.Text);
            if (cantDi > 0 && costoArt > 0)
            {
                if (cantDi < costoArt)
                {
                    txtResultado.Text = "El dinero es insuficiente";
                }
                else
                {
                    cambio = cantDi - costoArt;
                    txtResultado.Text = cambio.ToString("N2");
                }
            }
            else {
                txtResultado.Text = "Ingrese numeros positivos";
            }
        }
    }
}
