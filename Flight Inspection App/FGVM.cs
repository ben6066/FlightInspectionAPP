using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Flight_Inspection_App
{
    public class FGVM : IViewModel
    {
        protected readonly FGM _fgm;

        public FGVM(FGM fgm)
        {
            _fgm = fgm;
            _fgm.PropertyChanged += delegate (Object sender, PropertyChangedEventArgs e)
            {
                OnPropertyChanged("VM_" + e.PropertyName);
            };


        }
        public event PropertyChangedEventHandler PropertyChanged;


        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public FGM GetModel()
        {
            return _fgm;
        }

        public string VM_Ip
        {
            get { return _fgm.Ip; }
            set
            {
                if (_fgm.Ip != value)
                {
                    _fgm.Ip = value;
                    OnPropertyChanged();
                }
            }
        }
        public string VM_VideoSpeed
        {
            get { return _fgm.VideoSpeed; }
            set
            {
                if (_fgm.VideoSpeed != value)
                {
                    _fgm.VideoSpeed = value;
                    OnPropertyChanged();
                }
            }
        }


        public int VM_Port
        {
            get { return _fgm.Port; }
            set
            {
                if (_fgm.Port != value)
                {
                    _fgm.Port = value;
                    OnPropertyChanged();
                }
            }
        }

        public double VM_Throttle
        {
            get => _fgm.Throttle;
        }
        public double VM_Rudder
        {
            get => _fgm.Rudder;
        }


        public void Connect()
        {
            _fgm.Connect();
        }

        public void Disconnect()
        {
            _fgm.Disconnect();
        }

        public void Start()
        {
            _fgm.Start();
            _fgm.SetStatus(true);
        }


    }
}
