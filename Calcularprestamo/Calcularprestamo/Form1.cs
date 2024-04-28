using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcularprestamo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void plazo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cuota_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double MontoPrestamo = double.Parse(prestamo.Text);
            double PlazoEnMeses = double.Parse(plazo.Text);
            double CuotaAnual = double.Parse(cuota.Text);
            double CuotaMensual = CuotaAnual / 100;
            double MontoMensual = (MontoPrestamo * CuotaMensual * Math.Pow((1 + CuotaMensual), PlazoEnMeses)) / ((Math.Pow((1 + CuotaMensual), PlazoEnMeses)) - 1);
            MessageBox.Show("La cuota mensual del prestamo calculado tiende a: " + CuotaMensual);
        }
    }
}
