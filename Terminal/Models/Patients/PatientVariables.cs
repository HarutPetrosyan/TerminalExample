using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal.Models.Patients
{
    internal class PatientVariables
    {
        public PatientVariables()
        {
            Variables = new List<Serializable.PatientVariable>();
            Variables.Add(new Serializable.PatientVariable() { ID = 0, AllName= "Karen Chaxoyan", ResearchCode = "654714", ResearchName = "MexviKcac" });
            Variables.Add(new Serializable.PatientVariable() { ID = 1,AllName= "Karen Chaxoyan", ResearchCode = "341714", ResearchName = "KretiKcac" });
            Variables.Add(new Serializable.PatientVariable() { ID = 2, AllName="Karen Chaxoyan" , ResearchCode = "875714", ResearchName = "OdziKcac" });
            Variables.Add(new Serializable.PatientVariable() { ID = 3,AllName= "Karen Chaxoyan", ResearchCode = "425714", ResearchName = "AryanAnaliz" });
            Variables.Add(new Serializable.PatientVariable() { ID = 4,AllName= "Karen Chaxoyan", ResearchCode = "547714", ResearchName = "MeziAnaliz" });
        }
        public List<Serializable.PatientVariable> Variables { get; set; }
        
    }
}
