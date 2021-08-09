using OxyPlot;
using System;
using System.Collections.Generic;

namespace Flight_Inspection_App
{

    public class Feature
    {
        public string Name { get; set; }
        private readonly List<double> _Values = new();
        private readonly List<DataPoint> _Points = new();
        private readonly List<DataPoint> _CorrelationPoints = new();


        public Feature MostCorrelativeFeature
        {
            get; set;
        }
        private Line _lineReg;
        public Line LineReg
        {
            get => _lineReg;
            set
            {
                if (value != _lineReg)
                {
                    _lineReg = value;
                    Slope = (float)_lineReg._a;
                    Intercept = (float)_lineReg._b;
                }


            }
        }

        public void CalcLineRegresion()
        {
            LineReg = AnomalyDetectionUtil.LinearReg(CorrelationPoints, CorrelationPoints.Count);
        }
        public List<double> Values
        {
            get { return _Values; }
        }
        public void AddValue(double x)
        {
            Values.Add(x);
            if (x > MaxValue)
            {
                MaxValue = x;
            }

            if (x < MinValue)
            {
                MinValue = x;
            }
        }
        public double MaxValue
        {
            get; set;
        }
        public double MinValue
        {
            get; set;
        }
        public void AddPoint(int line, string value)
        {
            double x = line / 10;
            double y = Double.Parse(value);
            Points.Add(new DataPoint(x, y));
            AddValue(Double.Parse(value));
        }
        public IList<DataPoint> Points
        {
            get => _Points;
        }
        public List<DataPoint> CorrelationPoints
        {
            get => _CorrelationPoints;
        }
        public void CalcCorrelationPoints()
        {
            for (int i = 0; i < Values.Count; ++i)
            {
                AddCorrelationPoint(Values[i], MostCorrelativeFeature.Values[i]);
            }
        }
        public void AddCorrelationPoint(double x, double y)
        {
            CorrelationPoints.Add(new(x, y));
        }
        public float Slope
        {
            get; set;
        }
        public float Intercept
        {
            get; set;
        }
        public int Index
        {
            get; set;
        }

    }

}
