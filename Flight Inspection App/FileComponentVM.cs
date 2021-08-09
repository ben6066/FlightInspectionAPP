using System.Collections.Generic;

namespace Flight_Inspection_App
{
    class FileComponentVM : FGVM
    {
        public FileComponentVM(FGM m) : base(m)
        {

        }

        public KeyValuePair<string, string> VM_FileCsv
        {
            get { return _fgm.ThisCsvFile; }
            set
            {
                if (_fgm.ThisCsvFile.Key != value.Key)
                {
                    _fgm.ThisCsvFile = value;
                    OnPropertyChanged();
                }
            }
        }
        public KeyValuePair<string, string> VM_FileDll
        {
            get { return _fgm.ThisDllFile; }
            set
            {
                if (_fgm.ThisDllFile.Key != value.Key)
                {
                    _fgm.ThisDllFile = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
