using LibraryEllipticIntegrals20dec2023;
using OxyPlot;
using OxyPlot.Series;

namespace WinFormsEllipticIntegrals20dec2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Text = "Elliptic integrals";

            comboBox1.Items.AddRange(new string[] {
                "Elliptic integral of the first kind: K(k)",
                "Derivative of K(k)",
                "Elliptic integral of the second kind: E(k)",
                "Derivative of E(k)" });
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LineSeries lineSeries = new LineSeries();

            double x_minimum = 0;
            double x_maximum = 0.999;

            const int N = 1000; // aantal punten in grafiek.

            EllipticIntegralCalculator20dec2023 calculator = new EllipticIntegralCalculator20dec2023();
            EllipticIntegralK_20dec2023 ellipticIntegralK_20Dec2023 = new EllipticIntegralK_20dec2023(calculator);
            EllipticIntegralE_20dec2023 ellipticIntegralE_20Dec2023 = new EllipticIntegralE_20dec2023(calculator);

            for (int k = 0; k <= N; k++)
            {
                double x = (x_maximum - x_minimum) * ((double)k / N) + x_minimum;
                double y = 0;

                if (comboBox1.SelectedIndex == 0)
                {
                    y = ellipticIntegralK_20Dec2023.Function(x);
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    y = ellipticIntegralK_20Dec2023.Derivative(x);
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    y = ellipticIntegralE_20Dec2023.Function(x);
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    y = ellipticIntegralE_20Dec2023.Derivative(x);
                }

                lineSeries.Points.Add(new DataPoint(x, y));
            }

            PlotModel myPlotModel = new PlotModel();
            myPlotModel.Series.Add(lineSeries);
            this.plotView1.Model = myPlotModel;
        }
    }
}