using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Terminal.Views.UIComponents.CodeActivate
{
    internal class CodeActivateCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public async void Execute(object parameter)
        {
            await Task.Delay(10);
            MainWindow.MainWindowcontentBody.Content = new Views.Pages.CodeActivatePage.CodeActivatePage().CodeActivatePageGrid;
        }
    }
}
