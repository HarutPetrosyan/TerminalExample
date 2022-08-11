using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal.Models
{
    public class Statics
    {
        public static string PatientVisitCode = "";

        public static string[] Languages = Properties.Settings.Default.KeyboardLanguages.Split(',');

        public static string SelectedCulture = "am";


        public static List<Models.Clients.Serializable.Departments> Departments = new List<Models.Clients.Serializable.Departments>();

        public static List<Models.Clients.Serializable.Service> SelectedServices;

        public static API.Serializable.PaymentAsk PaymentAsk = new API.Serializable.PaymentAsk();

        public static float MustPaymentSumm = 0;

        public static string PatientPhoneNumber = "";
        

    }
}
