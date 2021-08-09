
using Flight_Inspection_App.Commands;

namespace Flight_Inspection_App
{
    class ControlBarVM : FGVM
    {
        public PauseCommand PauseTheFlight { get; private set; }
        public PlayCommand PlayTheFlight { get; private set; }
        public PlusCommand IncreaseTheSpeed { get; private set; }
        public MinusCommand DecreaseTheSpeed { get; private set; }
        public StopCommand StopTheFlight { get; private set; }
        public ControlBarVM(FGM m) : base(m)
        {
            PauseTheFlight = new PauseCommand(PauseThread);
            PlayTheFlight = new PlayCommand(ContinueRunning);
            IncreaseTheSpeed = new PlusCommand(IncreaseSpeed);
            DecreaseTheSpeed = new MinusCommand(DecreaseSpeed);
            StopTheFlight = new StopCommand(StopFlight);
        }

        public double VM_FlightTime
        {
            get
            {
                if (_fgm.FlightTime == null)
                {
                    return 1;
                }

                return double.Parse(_fgm.FlightTime);
            }
        }

        public string VM_CurrentFlightTime
        {
            get { return _fgm.CurrentFlightTime; }
            set
            {
                if (_fgm.CurrentFlightTime != value)
                {
                    _fgm.CurrentFlightTime = value;
                    base.OnPropertyChanged();
                }
            }
        }

        public int VM_CurrentLineIndex
        {
            get { return _fgm.CurrentLineIndex; }
            set
            {
                _fgm.CurrentLineIndex = value;
                OnPropertyChanged();
            }
        }
        public void IncreaseSpeed()
        {
            _fgm.IncreaseSpeed();
        }


        public void DecreaseSpeed()
        {
            _fgm.DecreaseSpeed();
        }
        public void PauseThread()
        {
            _fgm.PauseThread();
        }
        public void ContinueRunning()
        {
            _fgm.ContinueThread();
        }
        public void StopFlight()
        {
            _fgm.StopSimulatorThread();
        }


    }
}
