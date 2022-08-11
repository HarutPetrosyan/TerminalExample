using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Terminal.Models.Commands
{
    internal class PatientPhoneNumberDeleteLast : ICommand
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
                Statics.PatientPhoneNumber =
                    Statics.PatientPhoneNumber.Substring(0, Statics.PatientPhoneNumber.Length - 1);
            }
            catch
            {
              
            }

           
        }
    }
}
