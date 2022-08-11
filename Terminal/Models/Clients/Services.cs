using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Terminal.Models.Clients
{
    public class Services
    {
        public Services( string lang)
        {
            _lang = lang;
        }
        private string _lang;

        public Serializable.Services Get()
        {
            if (File.Exists(Environment.CurrentDirectory+ @"\TerminalLocal\DepartmentsServices\Services."+_lang+".json"))
            {
              return  JsonConvert.DeserializeObject<Models.Clients.Serializable.Services>(File.ReadAllText(Environment.CurrentDirectory + @"\TerminalLocal\DepartmentsServices\Services." + _lang + ".json"));
            }
            else
            {
                return new Serializable.Services();
            }
        }
    }
}
