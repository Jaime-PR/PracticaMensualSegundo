using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaMensualSegundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculo = null;

            int horas = int.Parse(txtHoras.Text);

            //if

            //else if

            //else if


            if (vehiculo == null)
            {
                double total = vehiculo.Calcular();

                lblTarifa.Text = "Total a pagar: $" + total.ToString("0.00");
            }

        }
    }
}
