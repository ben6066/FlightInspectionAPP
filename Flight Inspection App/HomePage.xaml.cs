using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace Flight_Inspection_App
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page, INotifyPropertyChanged
    {
        Simulator s;
        readonly FGVM _vm;
        public event PropertyChangedEventHandler PropertyChanged;

        public HomePage(FGVM vm)
        {
            DataContext = vm;
            InitializeComponent();
            _vm = vm;

        }


        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



        private void Start_Click(object sender, RoutedEventArgs e)
        {
            s = new Simulator(_vm);
            this.NavigationService.Navigate(s);
            //_vm.Start();
        }

        private void Connect_Click(object sender, RoutedEventArgs e)
        {
            _vm.Connect();


        }
        private void Disconnect_Click(object sender, RoutedEventArgs e)
        {
            _vm.Disconnect();
        }
    }
}
