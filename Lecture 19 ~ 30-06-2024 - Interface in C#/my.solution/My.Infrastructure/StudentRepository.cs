using DomainModels.AbstractionUserCase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.Infrastructure
{
    public class StudentRepository
    {
        public void StudentUAT()
        {
            var Student = new Student("Alan");
            Console.WriteLine(Student);

            Student.AddNumbers(2, 2 , 4);
        }
        public void TestStudentNotification()
        {


            INotification adminNotification = new Admin();
            adminNotification.SendResultViewSms();

            INotification studentNotificaiton = new Student("mark");
            studentNotificaiton.SendResultViewSms();
            
        }
    }
}
