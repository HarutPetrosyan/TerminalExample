using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Terminal.Models.Cryptography;
using System.IO;
using Newtonsoft.Json;

namespace Terminal.Models.API.BackServer
{
    public class Departments
    {
        public Departments(string lang)
        {
            Api(lang);
        }
       

        private void Api(string lang )
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add(nameof( Properties.Settings.Default.TerminalKey), Properties.Settings.Default.TerminalKey);
            client.DefaultRequestHeaders.Add(nameof(lang), lang);
            HttpResponseMessage response =  client.GetAsync(Properties.Settings.Default.BackServerURL+ @"/Terminals/Departments").Result;
            
            if (response.IsSuccessStatusCode)
            {
                lock (Statics.Departments)
                {
                    var LoadedDepartments = JsonConvert.DeserializeObject<Models.Clients.Serializable.Departments>(response.Content.ReadAsStringAsync().Result);
                    LoadedDepartments.lang = lang;
                    Statics.Departments.Add(LoadedDepartments);
                }
            }
        }
    }
}
