using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.ComponentModel.Design.Serialization;

namespace PizzaDelivery.Forms
{
    public partial class FormGrafic : Form
    {
        public FormGrafic()
        {
            InitializeComponent();
        }

        private void FormGrafic_Load(object sender, EventArgs e)
        {
            string filePath = "..\\..\\Comanda.txt";

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                chart1.Series.Clear();

                Series series = new Series("Vanzari");
                series.ChartType = SeriesChartType.Bar;

                foreach(string line in lines)
                {
                    string[] parts = line.Split('\t');

                    if(parts.Length == 3)
                    {
                        string stringValue = parts[1].Trim();
                        double numericValue = Convert.ToDouble(parts[2]);

                        series.Points.AddXY(stringValue, numericValue);
                    }
                }
                chart1.Series.Add(series);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
