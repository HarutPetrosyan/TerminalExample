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
    internal class SelectKeyboardLanguage : ICommand
    {
        public static string SelectedLanguage = "";

        public static bool LanguageChangingStatement = false;

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            SelectedLanguage = (string) parameter;
            LanguageChangingStatement = true;
        }
    }
}
