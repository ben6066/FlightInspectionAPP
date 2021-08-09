using OxyPlot;
using OxyPlot.Wpf;
using System.Collections.Generic;

namespace DetectorLibary
{
    public interface IDetector
    {

        //learn the normal flight (in csv file).
        public void LearnNormal(string trainFile);
        //detect anomalies in the current flight file.
        public void Detect(string file);

        // return Annotation (OxyPlot.Wpf.Annotation) that matches the specific detector, of the given feature (take the feature by index in the csv file).
        public Annotation GetAnnotation(int index);

        // return List of DataPoints (OxyPlot.DataPoint), of the given feature and the feature which is most correlative with.
        public List<DataPoint> GetAnomaliesPoints(int index);


        // return list of KeyValuePair of Anomalies (key = the line with the anomaly, value = descrption {Name Start - End}.
        public List<KeyValuePair<int, string>> GetAnomaliesDescriptions();
    }
}