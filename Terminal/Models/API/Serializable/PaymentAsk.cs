using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal.Models.API.Serializable
{
    public class PaymentAsk
    {
        public bool isExist { get; set; }
        public string visitDateTime { get; set; }
        public string visitCode { get; set; }
        public string visitor { get; set; }
        public string mustBePaidTotal { get; set; }
        public string PaidTotal { get; set; }
        public List< Service> services { get; set; }
        public List< Visitpayment> visitPayments { get; set; }
    }

    public class Service
    {
        public int departmentId { get; set; }
        public string serviceId { get; set; }
        public string serviceCode { get; set; }
        public string serviceName { get; set; }
        public string serviceFreeName { get; set; }
        public string servicePrice { get; set; }
        public string serviceQuantity { get; set; }
        public string serviceAmount { get; set; }
        public string serviceDiscount { get; set; }
        public string serviceStateOrder { get; set; }
        public string serviceToBePaid { get; set; }

        public string Name { get => Properties.Translations.Name; }
        public string Quantity { get => Properties.Translations.Quantity; }
        public string Price { get => Properties.Translations.Price; }
        public string Amount { get => Properties.Translations.Amount; }
        public string Discount { get => Properties.Translations.Discount; }
        public string StateOrder { get => Properties.Translations.StateOrder; }
        public string ToBePaid { get => Properties.Translations.ToBePaid; }
    }

    public class Visitpayment
    {
        public string payedDateTime { get; set; }
        public float payed { get; set; }
        public float prePayed { get; set; }
        public string prePayedPhoneNumber { get; set; }
    }

}
