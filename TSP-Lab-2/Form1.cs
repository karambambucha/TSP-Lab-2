using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TSP_Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chart1.Titles.Add("Диаграмма потока");
            Axis ax = new Axis();
            ax.Title = "Время t";
            chart1.ChartAreas[0].AxisX = ax;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            try
            {
                double MathExpectance = decimal.ToDouble(MathExpectanceNumeric.Value);
                double StandardDeviance = decimal.ToDouble(StandardDevianceNumeric.Value);
                double Time = decimal.ToDouble(TimeNumeric.Value);
                if(MathExpectance == StandardDeviance)
                    throw new Exception("Мат. ожидание равно среднеквадратическому отклонению!");
                var ThreadIntensity = 1.0 / MathExpectance;
                var k = Math.Round((1.0 / Math.Pow(StandardDeviance, 2) / Math.Pow(ThreadIntensity, 2)), 0, MidpointRounding.AwayFromZero);
                var PuassonIntensity = Math.Round(ThreadIntensity * k, 0, MidpointRounding.AwayFromZero);
                if(k <= 1)
                    throw new Exception("Порядок потока Эрланга вышло <= 1!");
                double t = 0;
                double n = 0;
                double NumLamps = 0;
                double NumFails = 0;
                var LampFailsX = new List<double>();
                var LampFailsY = new List<double>();
                while (true)
                { 
                    double r = rnd.NextDouble();
                    double T = Math.Abs(-1.0 / PuassonIntensity * Math.Log(r));
                    t += T;
                    n++;
                    if(t<Time)
                    {
                        NumLamps++;
                        if (n == k)
                        {
                            LampFailsX.Add(t);
                            LampFailsY.Add(0);
                            NumFails++;
                            n = 0;
                        }
                    }
                    else
                        break;

                }
                Series failSeries = new Series("Лампы, вышедшие из строя");
                failSeries.Points.DataBindXY(LampFailsX, LampFailsY);
                failSeries.ChartType = SeriesChartType.Point;

                chart1.Series.Clear();
                chart1.Series.Add(failSeries);
                chart1.ChartAreas[0].AxisX.Minimum = 0;
                chart1.ChartAreas[0].AxisX.Maximum = Time;
                chart1.Series[0].Color = Color.Red;
                chart1.Series[0].MarkerSize = 5;
               
                label4.Text = $"Всего ламп: {NumLamps}\nВышедших из строя: {NumFails}\nПоток Эрланга {k}-го порядка\nИнтенсивность порождающего потока: {PuassonIntensity}\nИнтенсивность самого потока: {ThreadIntensity}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
