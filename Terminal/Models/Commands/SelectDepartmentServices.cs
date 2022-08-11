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
    internal class SelectDepartmentServices : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {

           Statics.SelectedServices = new List<Clients.Serializable.Service>();
           Clients.Serializable.Services services = new Clients.Services(Statics.SelectedCulture).Get();
            foreach (Models.Clients.Serializable.Service service in services.servicesList)
            {
                if (service.departmentId == (int) parameter)
                {
                    Statics.SelectedServices.Add(service);
                }
            }
        }
    }
}
