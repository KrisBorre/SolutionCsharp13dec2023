using OxyPlot;
using OxyPlot.Series;
using LibraryBesselFunction13dec2023;

namespace WinFormsBesselFunction20dec2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Text = "Bessel function";

            var myPlotModel = new PlotModel { Title = "Bessel function" };

            BesselFunctionJ0_13dec2023 j0 = new BesselFunctionJ0_13dec2023();

            const double minimum = -5;
            const double maximum = 15;
            const int AANTAL = 1000;

            var lineSeries = new LineSeries();
            lineSeries.MarkerType = MarkerType.Circle;

            for (int i = 1; i <= AANTAL; i++)
            {
                double x = (i / (double)AANTAL) * (maximum - minimum) + minimum;

                lineSeries.Points.Add(new DataPoint(x, j0.Function(x)));
            }
            myPlotModel.Series.Add(lineSeries);

            this.plotView1.Model = myPlotModel;
        }
    }
}