using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Terminal.Models.API.BillValidator
{
    public class Commands
    {
        public  void Start()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add(nameof(Properties.Settings.Default.BillValidatorSecureKey), Properties.Settings.Default.BillValidatorSecureKey);
            HttpResponseMessage response = client.GetAsync(Properties.Settings.Default.BillValidatorServerIpAndPort+ "/validator/Start").Result; 
        }

        public void StopListening()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add(nameof(Properties.Settings.Default.BillValidatorSecureKey), Properties.Settings.Default.BillValidatorSecureKey);
            HttpResponseMessage response = client.GetAsync(Properties.Settings.Default.BillValidatorServerIpAndPort + "/validator/StopListening").Result;
        }

    }
}
