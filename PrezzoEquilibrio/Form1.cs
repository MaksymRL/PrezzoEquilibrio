using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrezzoEquilibrio
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private (bool Trovato, double Quantita, double Prezzo) TrovaEquilibrio( double dInt, double dCoeff, double oInt, double oCoeff, double oExp)
        {
           
            for (double q = 0; q <= 20; q += 0.001)
            {
                double domanda = dInt + dCoeff * q;
                double offerta = oInt + oCoeff * Math.Pow(q, oExp);

               
                if (Math.Abs(domanda - offerta) < 0.5)
                {
                    return (true, q, domanda);
                }
            }
            return (false, 0, 0);
        }

    }
}
