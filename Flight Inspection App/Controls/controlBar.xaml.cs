using System;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;

namespace Flight_Inspection_App.Controls
{
    /// <summary>
    /// Interaction logic for controlBar.xaml
    /// </summary>
    public partial class ControlBar : UserControl
    {
        private readonly bool mediaPlayerIsPlaying = false;

        public ControlBar()
        {

            InitializeComponent();
            DispatcherTimer timer = new()
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            timer.Start();
        }
        private void Open_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void Stop_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = mediaPlayerIsPlaying;
        }
    }

}
