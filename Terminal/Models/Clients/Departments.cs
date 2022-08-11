using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Terminal.Models.Clients
{
    public class Departments
    {
        public Departments( string lang)
        {
            _lang = lang;
        }
        private string _lang;

        public Serializable.Departments Get()
        {

            Serializable.Departments departments = new Serializable.Departments();
            foreach (Serializable.Departments _departmentsStatic in Models.Statics.Departments)
            {
                if (_departmentsStatic.lang == _lang)
                {
                    departments = _departmentsStatic;
                }
            }

            return departments;
        }
    }
}
