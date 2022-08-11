using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal.Models.Clients
{
    internal class ClientVariables
    {
        public ClientVariables()
        {
            Variables = new List<Serializable.ClientVariable>();
            Variables.Add(new Serializable.ClientVariable() { Type="WebSite",Value= "info@oncology.am" });
            Variables.Add(new Serializable.ClientVariable() { Type = "Mobile", Value = "office@oncology.am" });
            Variables.Add(new Serializable.ClientVariable() { Type = "Mobile", Value = "(+374) 10 20 50 50" });
        }
        public List<Serializable.ClientVariable> Variables { get; set; }
    }
}
