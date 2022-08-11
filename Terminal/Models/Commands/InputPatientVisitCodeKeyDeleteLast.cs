using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Terminal.Models.Commands
{
    public class InputPatientVisitCodeKeyDeleteLast : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            try
            {
                Statics.PatientVisitCode = Statics.PatientVisitCode.Substring(0, Statics.PatientVisitCode.Length - 1);
            }
            catch { }
        }
    }
}
