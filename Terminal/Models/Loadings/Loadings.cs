using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal.Models.Loadings
{
    internal class Loadings
    {
        public Loadings()
        {
            LoadDepartments();
            LoadServices();
        }

        public async void LoadDepartments()
        {
            foreach (string lang in Properties.Settings.Default.KeyboardLanguages.Split(','))
            {
                await Task.Factory.StartNew(() => {

                    new API.BackServer.Departments(lang);
                });
            }
            await Task.Delay(10000);
            LoadDepartments();
        }
        public async void LoadServices()
        {
            foreach (string lang in Properties.Settings.Default.KeyboardLanguages.Split(','))
            {
                await Task.Factory.StartNew(() => {

                    new API.BackServer.Services(lang);
                });
            }
            await Task.Delay(10000);
            LoadServices();
        }
    }
}
