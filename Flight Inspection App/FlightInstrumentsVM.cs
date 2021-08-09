namespace Flight_Inspection_App
{
    class FlightInstrumentsVM : FGVM
    {
        public FlightInstrumentsVM(FGM m) : base(m)
        {

        }


        public double VM_Altitude
        {
            get { return _fgm.Altitude; }
        }
        public double VM_AirSpeed
        {
            get { return _fgm.AirSpeed; }
        }
        public double VM_FlightDirection
        {
            get { return _fgm.FlightDirection; }
        }

        public double VM_YawDegrees
        {
            get { return _fgm.YawDegrees; }
        }
        public double VM_RollDegrees
        {
            get { return _fgm.RollDegrees; }
        }
        public double VM_PitchDegrees
        {
            get { return _fgm.PitchDegrees; }
        }
    }
}