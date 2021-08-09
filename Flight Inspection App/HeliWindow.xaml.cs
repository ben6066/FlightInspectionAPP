using System.Windows;

namespace Flight_Inspection_App
{
    /// <summary>
    /// Interaction logic for HeliWindow.xaml
    /// </summary>
    public partial class HeliWindow : Window
    {
        readonly IViewModel _vm;
        public HeliWindow(IViewModel vm)
        {
            InitializeComponent();
            _vm = vm;
            DataContext = _vm;
        }
    }
}
