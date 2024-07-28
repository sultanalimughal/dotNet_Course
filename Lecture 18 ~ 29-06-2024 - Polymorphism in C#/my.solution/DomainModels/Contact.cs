using DomainModels.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels
{
    public abstract class Contact : Object
    {
        //public Contact()
        //{
        //    CreatedDate = DateTime.Now;
        //}
        //public Contact(string _email)
        //    : this()
        //{
        //    Email = _email;
        //}
        //public Contact(string _email , string _name)
        //    : this(_email)
        //{
        //    Name = _name;
        //}
        public Contact(string _name , string _email , ContactTypes _contactType)
        {
            Name = _name;
            Email = _email;
            CreatedDate = DateTime.Now;
            contactType = _contactType;
        }

        //Variables 
        //Properties 
        //Access Modifires 
        //Geter 
        //Seter

        //public string Name { get; 
        //    private set; }
        private string name;

        public string Name
        {
            get { return name; }
            
            private set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("please provide Name of the Contact");   
                }
                name = value; 
            }
        }

        //public string Email { 
        //    get; 
        //    private set; }   
        private string email;

        public string Email
        {
            get { return email; }
            private set {
                if (string.IsNullOrEmpty(value))
                {
                    
                    throw new ArgumentNullException("please provide Email of the Contact");
                }
                email = value; 
            }
        }

        public string? Address { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedDate { get; private set; }
        public ContactTypes contactType { get; private set; }
    }
}
