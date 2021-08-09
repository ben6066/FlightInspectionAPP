using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Flight_Inspection_App
{
    class FeaturesPanelVM : FGVM
    {
        public FeaturesPanelVM(FGM m) : base(m)
        {

        }
        public event PropertyChangedEventHandler IntrestingPropertyChanged;
        protected void OnIntrestingPropertyChanged([CallerMemberName] string propertyName = null)
        {
            IntrestingPropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public List<Feature> VM_FeaturesNames { get { return _fgm.Features; } }

        public Feature VM_IntresingFeature
        {
            get
            {
                return _fgm.IntresingFeature;
            }
            set
            {
                if (_fgm.IntresingFeature != value)
                {
                    _fgm.IntresingFeature = value;
                    OnIntrestingPropertyChanged();

                    OnPropertyChanged();
                }
            }
        }
    }
}
