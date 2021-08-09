
using System.Collections.Generic;


namespace Flight_Inspection_App
{
    class AnomaliesListVM : FGVM
    {
        public AnomaliesListVM(FGM m) : base(m) { }

        public List<KeyValuePair<int, string>> VM_AnomaliesDescriptions { get { return _fgm.AnomaliesDescriptions; } }

        public KeyValuePair<int, string> VM_AnomalyDescription
        {
            get
            {
                return _fgm.AnomaliesDescription;
            }

            set
            {
                _fgm.AnomaliesDescription = value;
                OnPropertyChanged();
            }
        }
    }
}
