using System.ComponentModel;

namespace Flight_Inspection_App
{
    interface IModel : INotifyPropertyChanged
    {
        void Connect();
        void Disconnect();
        void Start();
    }
}
