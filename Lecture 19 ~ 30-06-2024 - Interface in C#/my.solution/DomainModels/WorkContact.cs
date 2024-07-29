using DomainModels.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels
{
    public abstract class WorkContact : Contact
    {
        public WorkContact(string _name, string _email , string designation , WorkContactTypes _workContactType) : base(_name, _email , ContactTypes.Work)
        {
            Designation = designation;
            WorkContactType = _workContactType;
        }

        public string Designation { get; private set; }
        public WorkContactTypes  WorkContactType { get; set; }

    }
}
