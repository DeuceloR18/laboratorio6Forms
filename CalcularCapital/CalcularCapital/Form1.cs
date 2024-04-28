using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularCapital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RESULTADO_Click(object sender, EventArgs e)
        {
            double MontoInicial = double.Parse(monto.Text);
            double Interes = double.Parse(intereses.Text);
            double Inversion = double.Parse(inversion.Text);
            double Capital_final = MontoInicial * (1 + Interes  / 100 * Inversion);

            MessageBox.Show("El capital final es: " + Capital_final);












        }

  
         
    }
}
