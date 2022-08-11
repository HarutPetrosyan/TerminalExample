using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Terminal.Models.Commands
{
    public  class CapsLock : ICommand
    {
        public static bool CapsLockStatement;
        public static bool CapsLockCondition = false;

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (CapsLockStatement)
            {
                CapsLockStatement = false;
            }
            else
            {
                CapsLockStatement = true;
            }
            CapsLockCondition = true;

            
        }
    }
}
