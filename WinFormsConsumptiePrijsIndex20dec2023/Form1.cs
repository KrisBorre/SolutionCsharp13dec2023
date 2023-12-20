using OxyPlot.Series;
using OxyPlot;
using System;

namespace WinFormsConsumptiePrijsIndex20dec2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // https://statbel.fgov.be/nl/open-data/consumptieprijsindex-en-gezondheidsindex
            Text = "Consumptie Prijs Index";

            // jaar maand Consumptieprijsindex 
            // jaar maand Index_zonder_energetische_producten 
            // jaar maand Index_zonder_petroleum_producten 
            // jaar maand inflatie 
            // jaar maand gezondheidsindex 

            comboBox1.Items.AddRange(new string[] {
            "Consumptieprijsindex",
            "Index zonder energetische producten",
            "Index zonder petroleum producten",
            "Gezondheidsindex"});

            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlotModel model = new PlotModel();
            LineSeries series2 = new LineSeries();

            StreamReader streamReader = new StreamReader(@"..\..\..\CPI_All_base_years.txt");

            const char delimiter = '|';

            string header = streamReader.ReadLine();
            string[] headerValues = header.Split(delimiter);

            foreach (string s in headerValues)
            {
                Console.Write(s + "\t");
            }
            Console.WriteLine();

            List<ConsumptieRecord20dec2023> lijst = new List<ConsumptieRecord20dec2023>();

            while (!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine();
                string[] values = line.Split(delimiter);

                if (values.Length != 10) Console.WriteLine("Vervelende record!");

                ConsumptieRecord20dec2023 record = new ConsumptieRecord20dec2023();
                int j = 0;
                record.StringJaar = values[j++];
                record.StringMaand = values[j++];
                record.StringConsumptieprijsindex = values[j++];
                record.String_Index_zonder_energetische_producten = values[j++];
                record.String_Index_zonder_petroleum_producten = values[j++];
                record.StringWeging = values[j++];
                record.StringInflatie = values[j++];
                record.StringGezondheidsindex = values[j++];
                record.String_Afgevlakte_gezondheidsindex = values[j++];
                record.StringBasisjaar = values[j++];

                lijst.Add(record);
            }

            streamReader.Close();
            streamReader.Dispose();

            string strBasisjaar = "2004"; // "1953";
            int startJaar = 1920;

            if (comboBox1.SelectedIndex == 0)
            {
                // jaar maand Consumptieprijsindex (alle data)
                foreach (ConsumptieRecord20dec2023 record in lijst)
                {
                    if (record.StringBasisjaar == strBasisjaar && record.Jaar >= startJaar)
                    {
                        series2.Points.Add(new DataPoint(record.Jaar + record.Maand / 12.0, record.Consumptieprijsindex));
                    }
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                // jaar maand Index_zonder_energetische_producten (vanaf 2006)
                foreach (ConsumptieRecord20dec2023 record in lijst)
                {
                    if (record.StringBasisjaar == strBasisjaar && record.Jaar >= Math.Max(2006, startJaar) && record.String_Index_zonder_energetische_producten != ".")
                    {
                        series2.Points.Add(new DataPoint(record.Jaar + record.Maand / 12.0, record.Index_zonder_energetische_producten));
                    }
                }
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                // jaar maand Index_zonder_petroleum_producten (vanaf 1997)
                foreach (ConsumptieRecord20dec2023 record in lijst)
                {
                    if (record.StringBasisjaar == strBasisjaar && record.Jaar >= Math.Max(1997, startJaar) && record.String_Index_zonder_petroleum_producten != ".")
                    {
                        series2.Points.Add(new DataPoint(record.Jaar + record.Maand / 12.0, record.Index_zonder_petroleum_producten));
                    }
                }
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                // jaar maand gezondheidsindex (vanaf 1994)
                foreach (ConsumptieRecord20dec2023 record in lijst)
                {
                    if (record.StringBasisjaar == strBasisjaar && record.Jaar >= Math.Max(1994, startJaar) && record.StringGezondheidsindex != ".")
                    {
                        series2.Points.Add(new DataPoint(record.Jaar + record.Maand / 12.0, record.Gezondheidsindex));
                    }
                }
            }

            model.Series.Add(series2);
            this.plotView1.Model = model;
        }
    }
}