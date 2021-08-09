namespace Flight_Inspection_App
{
    class MultiDimensionalModelVM : FGVM
    {
        public MultiDimensionalModelVM(FGM m) : base(m) { }
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
