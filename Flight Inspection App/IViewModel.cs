using System.ComponentModel;

namespace Flight_Inspection_App
{

    public interface IViewModel : INotifyPropertyChanged
    {

        public void Connect();
        public void Disconnect();
        public void Start();

    }
}
