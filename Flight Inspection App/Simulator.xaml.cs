using OxyPlot.Wpf;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;


namespace Flight_Inspection_App
{
    /// <summary>
    /// Interaction logic for Simulator.xaml
    /// </summary>
    public partial class Simulator : Page
    {
        readonly FGVM _vm;
        readonly ControlBarVM _cbvm;
        readonly FileComponentVM _fcvm;
        readonly FeaturesPanelVM _fpvm;
        readonly FeaturesGraphsVM _fegvm;
        readonly FlightInstrumentsVM _fivm;
        readonly JoystickVM _jvm;
        readonly AnomaliesListVM _alvm;
        readonly Annotation _fixedAnnotation;
        readonly MultiDimensionalModelVM _mdvm;
        public Simulator(FGVM vm)
        {
            InitializeComponent();
            _vm = vm;
            DataContext = vm;
            _cbvm = new ControlBarVM(_vm.GetModel());
            _fcvm = new FileComponentVM(_vm.GetModel());
            _fpvm = new FeaturesPanelVM(_vm.GetModel());
            _fegvm = new FeaturesGraphsVM(_vm.GetModel());
            _fivm = new FlightInstrumentsVM(_vm.GetModel());
            _jvm = new JoystickVM(_vm.GetModel());
            _alvm = new AnomaliesListVM(_vm.GetModel());
            _mdvm = new MultiDimensionalModelVM(_vm.GetModel());
            controlbar.DataContext = _cbvm;
            fileselector.DataContext = _fcvm;
            features.DataContext = _fpvm;
            _fpvm.IntrestingPropertyChanged += ChangeAnnoatation;
            featuregraphs.DataContext = _fegvm;
            flightinstruments.DataContext = _fivm;
            joystick.DataContext = _jvm;
            anomalies.DataContext = _alvm;

            _fixedAnnotation = featuregraphs.MyPlot.Annotations[0];
        }

        public void ChangeAnnoatation(object sender, PropertyChangedEventArgs e)
        {

            featuregraphs.MyPlot.ResetAllAxes();
            if (_fegvm.VM_Annotation != null)
            {

                featuregraphs.MyPlot.Annotations.Clear();
                featuregraphs.MyPlot.Annotations.Add(_fixedAnnotation);
                featuregraphs.MyPlot.Annotations.Add(_fegvm.VM_Annotation);
            }

        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Graph_Loaded(object sender, RoutedEventArgs e)
        {

        }
        public IViewModel getVm()
        {
            return _vm;
        }

        private void HeliWindow(object sender, RoutedEventArgs e)
        {
            HeliWindow hw = new(vm: _mdvm);
            hw.Show();
        }


        private void Joystick_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void ControlBar_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void ControlBar_Loaded_1(object sender, RoutedEventArgs e)
        {

        }

        private void ControlBar_Loaded_2(object sender, RoutedEventArgs e)
        {

        }

        private void ControlBar_Loaded_3(object sender, RoutedEventArgs e)
        {

        }

        private void FilesComponent_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void ControlBar_Loaded_4(object sender, RoutedEventArgs e)
        {

        }

        private void UserControl1_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Slider_ValueChanged()
        {

        }
    }
}
