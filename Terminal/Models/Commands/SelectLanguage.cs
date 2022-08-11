using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Terminal.Models.Commands
{
    internal class SelectLanguage : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {

            Properties.Translations.Culture = new CultureInfo((string)parameter);
            Models.Statics.SelectedCulture = (string)parameter;

             ViewModels.MainPageViewModel.MustPropertyesChanging = true;
        }
    }
}
