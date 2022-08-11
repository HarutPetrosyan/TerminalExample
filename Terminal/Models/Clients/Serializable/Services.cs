using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal.Models.Clients.Serializable
{

    public class Services
    {
        public List<Service> servicesList { get; set; }
    }

    public class Service
    {
        public string serviceId { get; set; }
        public int departmentId { get; set; }
        public object serviceCode { get; set; }
        public object serviceName { get; set; }
        public object servicePrice { get; set; }
    }

}
