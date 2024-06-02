using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels
{
    public class WorkContact : Contact
    {
        public WorkContact(string _name, string _email , string designation) : base(_name, _email)
        {
            Designation = designation;
        }

        public string Designation { get; private set; }
    }
}
