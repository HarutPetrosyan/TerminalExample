using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Terminal.Models.Cryptography;
using System.IO;

namespace Terminal.Models.API.BackServer
{
    public class Services
    {
        public Services(string lang)
        {
            Api(lang);
        }
       

        private void Api(string lang )
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add(nameof( Properties.Settings.Default.TerminalKey), Properties.Settings.Default.TerminalKey);
            client.DefaultRequestHeaders.Add(nameof(lang), lang);
            HttpResponseMessage response =  client.GetAsync(Properties.Settings.Default.BackServerURL+ @"/Terminals/Services").Result;
            
            if (response.IsSuccessStatusCode)
            {
                if (!Directory.Exists(Environment.CurrentDirectory + @"\TerminalLocal\DepartmentsServices\"))
                {
                    Directory.CreateDirectory(Environment.CurrentDirectory + @"\TerminalLocal\DepartmentsServices\");
                }
                File.WriteAllText(Environment.CurrentDirectory+ @"\TerminalLocal\DepartmentsServices\Services." + lang+".json", response.Content.ReadAsStringAsync().Result);



            }
        }
    }
}
