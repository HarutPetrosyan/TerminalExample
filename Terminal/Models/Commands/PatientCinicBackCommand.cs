using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Terminal.Models.Commands
{
    internal class PatientCinicBackCommand:ICommand
    {
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            MainWindow.MainWindowcontentBody.Content = new Views.Pages.CodeActivatePage.CodeActivatePage().Content;
        }

        public event EventHandler CanExecuteChanged;
    }
}
