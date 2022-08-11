using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Terminal.Models.API.BackServer
{
    internal class PaymentAskByVisitCode
    {
        public (Serializable.PaymentAsk,bool) Api(string lang, string VisitCode)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add(nameof(Properties.Settings.Default.TerminalKey), Properties.Settings.Default.TerminalKey);
            client.DefaultRequestHeaders.Add(nameof(lang), lang);

            object RequestBody = new
            {
                VisitCode = Statics.PatientVisitCode
            };


            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(RequestBody)) ;
            HttpResponseMessage response = client.PostAsync(Properties.Settings.Default.BackServerURL + @"/Terminals/TerminalAskPaymentByVisitCode", stringContent).Result;

            if (response.IsSuccessStatusCode)
            {
                
                return (JsonConvert.DeserializeObject<Serializable.PaymentAsk>(response.Content.ReadAsStringAsync().Result),true);
                
            }
            else
            {
                return (new Serializable.PaymentAsk(), false);
            }
        }
    }
}
