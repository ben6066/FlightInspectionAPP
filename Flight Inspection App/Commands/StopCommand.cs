using System;
using System.Windows.Input;

namespace Flight_Inspection_App.Commands
{
    public class StopCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private readonly Action _execute;
        public StopCommand(Action execute)
        {
            _execute = execute;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _execute.Invoke();
        }
    }
}
