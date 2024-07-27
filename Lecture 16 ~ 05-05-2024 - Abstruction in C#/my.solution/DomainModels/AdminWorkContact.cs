using DomainModels.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels
{
    public class AdminWorkContact : WorkContact
    {
        public AdminWorkContact(string _name, string _email, string designation) : base(_name, _email, designation , WorkContactTypes.Admin)
        {
        }
    }
}
