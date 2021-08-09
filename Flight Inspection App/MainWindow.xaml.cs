using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Navigation;

namespace Flight_Inspection_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : NavigationWindow, INotifyPropertyChanged
    {
        readonly HomePage _home;
        readonly FGVM _vm;

        public MainWindow()
        {
            InitializeComponent();
            _vm = new FGVM(new FGM(new Client()));
            DataContext = _vm;
            _home = new HomePage(_vm);
            Navigate(_home);

        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public HomePage GetHomePage()
        {
            return _home;
        }
    }
}
