using ScottPlot;
using ScottPlot.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = System.Drawing.Color;

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
        private void AggiornaGrafico()
        {
            if (formsPlot?.Plot == null) return;

            double domandaIntercetta = (double)numDomandaIntercetta.Value;
            double domandaCoeff = (double)numDomandaCoeff.Value;
            double offertaIntercetta = (double)numOffertaIntercetta.Value;
            double offertaCoeff = (double)numOffertaCoeff.Value;
            double offertaEsponente = (double)numOffertaEsponente.Value;

            var equilibrio = TrovaEquilibrio(domandaIntercetta, domandaCoeff,
                                           offertaIntercetta, offertaCoeff, offertaEsponente);

            int numeroPunti = 100;
            double[] quantita = new double[numeroPunti];
            double[] domanda = new double[numeroPunti];
            double[] offerta = new double[numeroPunti];

            double quantitaMax = Math.Max(10, equilibrio.Quantita * 2);
            for (int i = 0; i < numeroPunti; i++)
            {
                double q = quantitaMax * i / (numeroPunti - 1);
                quantita[i] = q;
                domanda[i] = domandaIntercetta + domandaCoeff * q;
                offerta[i] = offertaIntercetta + offertaCoeff * Math.Pow(q, offertaEsponente);
            }

            formsPlot.Plot.Clear();

          
            var scatterDomanda = formsPlot.Plot.Add.Scatter(quantita, domanda);
            scatterDomanda.Label = $"Domanda: d = {domandaIntercetta} + {domandaCoeff}·q";
            scatterDomanda.Color = Colors.Blue;  
            scatterDomanda.LineWidth = 3;

            var scatterOfferta = formsPlot.Plot.Add.Scatter(quantita, offerta);
            scatterOfferta.Label = $"Offerta: o = {offertaIntercetta} + {offertaCoeff}·q^{offertaEsponente}";
            scatterOfferta.Color = Colors.Red;   
            scatterOfferta.LineWidth = 3;

            if (equilibrio.Trovato)
            {
               
                var puntoEq = formsPlot.Plot.Add.Scatter(
                    new double[] { equilibrio.Quantita },
                    new double[] { equilibrio.Prezzo }
                );
                puntoEq.Label = $"Equilibrio (q={equilibrio.Quantita:F2}, p={equilibrio.Prezzo:F2})";
                puntoEq.Color = Colors.Green;  
                puntoEq.MarkerSize = 10;
                puntoEq.MarkerShape = MarkerShape.FilledCircle;
                puntoEq.LineWidth = 0;  

            
                var lineaVerticale = formsPlot.Plot.Add.VerticalLine(equilibrio.Quantita);
                lineaVerticale.Color = Colors.Green;
                lineaVerticale.LineWidth = 1;
                lineaVerticale.LinePattern = LinePattern.Dashed;  

                var lineaOrizzontale = formsPlot.Plot.Add.HorizontalLine(equilibrio.Prezzo);
                lineaOrizzontale.Color = Colors.Green;
                lineaOrizzontale.LineWidth = 1;
                lineaOrizzontale.LinePattern = LinePattern.Dashed; 
            }

          
            formsPlot.Plot.XLabel("Quantità (q)");
            formsPlot.Plot.YLabel("Prezzo (p)");
            formsPlot.Plot.ShowLegend(Alignment.UpperRight);

            formsPlot.Refresh();

            if (equilibrio.Trovato)
            {
                lblEquilibrio.Text = $"EQUILIBRIO TROVATO:\n" +
                                   $"Quantità: {equilibrio.Quantita:F2}\n" +
                                   $"Prezzo: {equilibrio.Prezzo:F2}";
                lblEquilibrio.ForeColor = System.Drawing.Color.DarkGreen;  
            }
            else
            {
                lblEquilibrio.Text = "EQUILIBRIO NON TROVATO\nnel range considerato";
                lblEquilibrio.ForeColor = System.Drawing.Color.Red;  
            }
        }


        

    }
}
