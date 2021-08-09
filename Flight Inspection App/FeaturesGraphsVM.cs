using OxyPlot;
using OxyPlot.Wpf;
using System.Collections.Generic;

namespace Flight_Inspection_App
{
    class FeaturesGraphsVM : FGVM
    {




        public FeaturesGraphsVM(FGM m) : base(m)
        {


        }

        public string VM_DetectorState
        {
            get => _fgm.DetectorState;
        }

        public int VM_PbValue
        {
            get => _fgm.PbValue;
        }
        public double VM_MostCorreltiveFeatureMaxValue
        {
            get => _fgm.MostCorreltiveFeatureMaxValue;
        }

        public double VM_MostCorreltiveFeatureMinValue
        {
            get => _fgm.MostCorreltiveFeatureMinValue;
        }
        public double VM_FeatureMinValue
        {
            get => _fgm.FeatureMinValue;
        }
        public double VM_FeatureMaxValue
        {
            get => _fgm.FeatureMaxValue;
        }

        public float VM_Slope
        {
            get => _fgm.Slope;
        }
        public float VM_Intercept
        {
            get => _fgm.Intercept;
        }

        public List<DataPoint> VM_CorrelationPoints
        {
            get => _fgm.CorrelationPoints;
        }


        public List<DataPoint> VM_AnomalyPoints
        {
            get => _fgm.AnomalyPoints;
        }
        public List<DataPoint> VM_lastCorrelationPoints
        {
            get => _fgm.lastCorrelationPoints;
        }

        public Annotation VM_Annotation
        {
            get => _fgm.Annotation;

        }


        public KeyValuePair<string, string> VM_FileDll
        {
            get { return _fgm.ThisDllFile; }

        }

        public string VM_FeatureTitle
        {
            get
            {
                return _fgm.FeatureTitle;
            }
        }

        public string VM_MostCorreltiveFeatureTitle
        {
            get
            {
                return _fgm.MostCorreltiveFeatureTitle;
            }
        }

        public IList<DataPoint> VM_FeaturePoints
        {
            get
            {
                return _fgm.FeaturePoints;
            }
        }

        public IList<DataPoint> VM_MostCorreltiveFeaturePoints
        {
            get
            {
                return _fgm.MostCorreltiveFeaturePoints;
            }
        }

    }
}
