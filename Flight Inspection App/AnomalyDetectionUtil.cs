using OxyPlot;
using System;
using System.Collections.Generic;



namespace Flight_Inspection_App
{
    static class AnomalyDetectionUtil
    {
        static double Avg(IList<double> x, int size)
        {
            double sum = 0;
            for (int i = 0; i < size; sum += x[i], i++)
            {
                ;
            }

            return sum / size;
        }

        // returns the variance of X and Y
        static double Var(IList<double> x, int size)
        {
            double av = Avg(x, size);
            double sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum += x[i] * x[i];
            }
            return sum / size - av * av;
        }

        // returns the covariance of X and Y
        static double Cov(IList<double> x, IList<double> y, int size)
        {
            double sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum += x[i] * y[i];
            }
            sum /= size;

            return sum - Avg(x, size) * Avg(y, size);
        }


        // returns the Pearson correlation coefficient of X and Y
        public static double Pearson(IList<double> x, IList<double> y, int size)
        {
            double s = Math.Sqrt(Var(x, size)) * Math.Sqrt(Var(y, size));
            if (s == 0)
            {
                return 0;
            }

            return Cov(x, y, size) / s;
        }

        // performs a linear regression and returns the line equation
        public static Line LinearReg(IList<DataPoint> points, int size)
        {
            List<double> x = new(), y = new();
            for (int i = 0; i < size; i++)
            {
                x.Add(points[i].X);
                y.Add(points[i].Y);
            }
            double a = Cov(x, y, size) / Var(x, size);
            double b = Avg(y, size) - a * (Avg(x, size));

            return new Line(a, b);
        }
    }

    public class Line
    {
        public double _a, _b;
        public Line()
        {
            _a = 0;
            _b = 0;

        }
        public Line(double a, double b)
        {
            _a = a;
            _b = b;

        }
        public double f(double x)
        {
            return _a * x + _b;
        }

    }
}


