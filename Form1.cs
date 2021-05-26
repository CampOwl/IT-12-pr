using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace it_lab_12
{
    public partial class Form1 : Form
    {
        public static List<Tuple<double, double>> points = new List<Tuple<double, double>>();//двойной массив
        Chart C;

        public Form1()
        {
          InitializeComponent();
          Tables();
          double[] x = points.Select(_ => _.Item1).ToArray();
          double[] y = points.Select(_ => _.Item2).ToArray();
          double Xmin = x.Min();
          double Xmax = x.Max();
          double Ymin = y.Min();
          double Ymax = y.Max();
          double step_x = 0.2;
          double step_y = 1;
          ChartArea area = new ChartArea();
          area.Name = "myGraph";
          area.AxisX.Minimum = Xmin;
          area.AxisX.Maximum = Xmax;
          area.AxisX.MajorGrid.Interval = step_x;
          area.AxisY.Minimum = Ymin;
          area.AxisY.Maximum = Ymax;
          area.AxisY.MajorGrid.Interval = step_y;
          Equations.ChartAreas.Add(area);
    }

        private void resultButton_click(object sender, EventArgs e)
        {
          double[] x = points.Select(_ => _.Item1).ToArray();
          double[] y = points.Select(_ => _.Item2).ToArray();
          Series series_0 = new Series();
          series_0.ChartArea = "myGraph";
          series_0.ChartType = SeriesChartType.Point;
          series_0.MarkerSize = 10;
          series_0.LegendText = "Начальные точки";
          Equations.Series.Add(series_0);
          Legend legend = new Legend();
          Equations.Legends.Add(legend);
          Equations.Series[0].Points.DataBindXY(x, y);
    }
        private void Tables()
        {
          input_data.RowCount = 6;//создание и заполнение таблицы X,Y
          input_data.ColumnCount = 2;
          input_data.Rows[0].Cells[0].Value = 3.0;
          input_data.Rows[1].Cells[0].Value = 3.2;
          input_data.Rows[2].Cells[0].Value = 3.4;
          input_data.Rows[3].Cells[0].Value = 3.6;
          input_data.Rows[4].Cells[0].Value = 3.8;
          input_data.Rows[5].Cells[0].Value = 4.0;
          input_data.Rows[0].Cells[1].Value = 2.0;
          input_data.Rows[1].Cells[1].Value = 3.0;
          input_data.Rows[2].Cells[1].Value = 3.0;
          input_data.Rows[3].Cells[1].Value = 3.0;
          input_data.Rows[4].Cells[1].Value = 2.0;
          input_data.Rows[5].Cells[1].Value = 4.0;
          Equations.Series.Clear();//очищение графика
          Equations.ChartAreas.Clear();
          Equations.Legends.Clear();

          for (var i = 0; i < input_data.RowCount; i++)//заполнение массива точками
          {
            var x = Convert.ToDouble(input_data.Rows[i].Cells[0].Value);
            var y = Convert.ToDouble(input_data.Rows[i].Cells[1].Value);
            points.Add(new Tuple<double, double>(x, y));
          }

          Matrix_I.RowCount = 2;
          Matrix_I.ColumnCount = 3;
          Matrix_II.RowCount = 3;
          Matrix_II.ColumnCount = 4;
          coef_I.RowCount = 2;
          coef_I.Rows[0].Cells[0].Value = "a_0";
          coef_I.Rows[1].Cells[0].Value = "a_1";
          coef_I.ColumnCount = 2;
          coef_II.RowCount = 3;
          coef_II.ColumnCount = 2;
          coef_II.Rows[0].Cells[0].Value = "a_0";
          coef_II.Rows[1].Cells[0].Value = "a_1";
          coef_II.Rows[2].Cells[0].Value = "a_2";
    }

        private void button1_Click(object sender, EventArgs e)
        {
          for (int i = 0; i < 2; i++)
          {
            Matrix_I.Rows[i].Cells[2].Value = LinearRegression.CalculateB(i);
            for (int j = 0; j < 2; j++)
              Matrix_I.Rows[j].Cells[i].Value = LinearRegression.CalculateS(i + j);
          }

          coef_I.Rows[0].Cells[1].Value = LinearRegression.GetPolynomial(1)[0];
          coef_I.Rows[1].Cells[1].Value = LinearRegression.GetPolynomial(1)[1];
        }

        private void button2_Click(object sender, EventArgs e)
        {
          for (int i = 0; i < 3; i++)
          {
            Matrix_II.Rows[i].Cells[3].Value = LinearRegression.CalculateB(i);
            for (int j = 0; j < 3; j++)
              Matrix_II.Rows[j].Cells[i].Value = LinearRegression.CalculateS(i + j);
          }

          coef_II.Rows[0].Cells[1].Value = LinearRegression.GetPolynomial(2)[0];
          coef_II.Rows[1].Cells[1].Value = LinearRegression.GetPolynomial(2)[1];
          coef_II.Rows[2].Cells[1].Value = LinearRegression.GetPolynomial(2)[2];
        }

        private void button3_Click(object sender, EventArgs e)
        {
          double[] y_1 = LinearRegression.CalculateY(1);
          double[] x = points.Select(_ => _.Item1).ToArray();
          double[] y = points.Select(_ => _.Item2).ToArray();
          ChartArea area = new ChartArea();
          Series series_1 = new Series();
          series_1.ChartArea = "myGraph";
          series_1.ChartType = SeriesChartType.Spline;
          series_1.BorderWidth = 3;
          series_1.LegendText = "Полином I степени";
          Equations.Series.Add(series_1);
          Equations.Series[1].Points.DataBindXY(x, y_1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
          double[] y_2 = LinearRegression.CalculateY(2);
          double[] x = points.Select(_ => _.Item1).ToArray();
          double[] y = points.Select(_ => _.Item2).ToArray();
          Series series_2 = new Series();
          series_2.ChartArea = "myGraph";
          series_2.ChartType = SeriesChartType.Spline;
          series_2.BorderWidth = 3;
          series_2.LegendText = "Полином II степени";
          Equations.Series.Add(series_2);
          Equations.Series[2].Points.DataBindXY(x, y_2);
        }

    

    private void Form1_Load(object sender, EventArgs e)
    {

    }
  }
}
