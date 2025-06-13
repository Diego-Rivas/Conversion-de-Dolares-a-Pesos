using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversion_de_dolares_a_pesos_mexicanos
{
    public partial class Form1 : Form
    {
        double cantDolares, pesos;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCantidad.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            cantDolares = double.Parse(txtCantidad.Text);
            if (cantDolares > 0)
            {
                pesos = cantDolares * 18;
               lblRespuesta.Text = pesos.ToString("N2");
            }
            else
            {
                lblRespuesta.Text = "Ingrese numeros positivos";
            }
        }
    }
}
