using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels.AbstractionUserCase
{
    public class Admin : INotification
    {
        bool INotification.SendResultViewSms()
        {
            Console.WriteLine("Admin Approved result");
            return false;
        }
    }
}
