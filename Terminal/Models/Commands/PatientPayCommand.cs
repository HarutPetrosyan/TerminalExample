using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Terminal.Models.Commands
{
    internal class PatientPayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public async void Execute(object parameter)
        {
            MainWindow.MainWindowcontentBody.Content = new Views.Pages.PatientClinicInfoPage.PatientClinicInfoPage().PatientClinicInfoGrid;
        }
    }
}
