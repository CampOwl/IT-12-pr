using System;
using System.Collections.Generic;
using System.Linq;
using MathNet.Numerics.LinearAlgebra;

namespace it_lab_12
{
    static class LinearRegression
    {
        public static double CalculateS(int m)//S_k=x_0^k+x_1^k+⋯+x_n^k
        {
            double sum = 0;
            for (var i = 0; i < Form1.points.Count; i++)
            {
                if (Form1.points[i].Item1 == 0 && m == 0)
                    sum += 1;
                else
                    sum += Math.Pow(Form1.points[i].Item1, m);
            }
            return sum;
        }

        public static double CalculateB(int m)//b_k 〖=y_0 x〗_0^k+〖y_1 x〗_1^k+⋯+〖y_n x〗_n^k
        {
            double sum = 0;
            for (var i = 0; i < Form1.points.Count; i++)
            {
                if (Form1.points[i].Item1 == 0 && m == 0)
                    sum += Form1.points[i].Item2;
                else
                    sum += Math.Pow(Form1.points[i].Item1, m) * Form1.points[i].Item2;
            }
            return sum;
        }


        public static List<double> GetPolynomial(int order)
        {            
            var s = new double[order + 1, order + 1];//получение S для систем
            for (var i = 0; i < s.GetLength(0); i++)
                for (var j = 0; j < s.GetLength(1); j++)                
                    s[i, j] = CalculateS(i + j);
            
            var b = new double[order + 1];//получение b для систем
            for (var i = 0; i < b.Length; i++)
                b[i] = CalculateB(i);

            var system = Matrix<double>.Build.DenseOfArray(s);//система из s*a
            var vect = Vector<double>.Build.Dense(b);//коэфы b
            var a = system.Solve(vect).ToList();//коэфы a для полиномов

            for (var i = 0; i < a.Count; i++)
                a[i] = Math.Round(a[i], 3);

            return a;
        }

        public static double CalculatePolynomial(int order, int index)
        {   
            var a = GetPolynomial(order);
            double y = 0;
            for (var i = 0; i < a.Count; i++)
                y += a[i] * Math.Pow(Form1.points[index].Item1, i);
            return y;
        }

        public static double[] CalculateY(int order)
        {
            double[] y = new double[Form1.points.Count];
            for (var i = 0; i < y.Length; i++)
                y[i] = CalculatePolynomial(order, i);
            return y;
        }
    //public static double CalculatePolynomial_zoom(int order, int index)
    //{
    //  var a = GetPolynomial(order);
    //  double y = 0;
    //  for (var i = 0; i < a.Count; i++)
    //    y += a[i] * Math.Pow(Chart.X[index], i);
    //  return y;
    //}

    //public static double[] CalculateY_zoom(int order)
    //{
    //  double[] y = new double[Chart.X.Count];
    //  for (var i = 0; i < y.Length; i++)
    //    y[i] = CalculatePolynomial_zoom(order, i);
    //  return y;
    //}
  }
}
