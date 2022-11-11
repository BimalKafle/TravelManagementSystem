using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Travel.CoreLayer.Entity
{
    public class Customer
    {
        public readonly  string StatusActive = "Active";

        public readonly string StatusDeactive = "Deactive";

        public virtual int Id { get; protected set; }
        public virtual string Name { get; protected set; }
        public virtual string Address { get; protected set; }
        public virtual string MailAddress { get; protected set; }
        public virtual string Status { get; protected set; }

        public Customer (string _name, string _address, string _mailAddress)
        {
            Name = _name;
            Address = _address;
            MailAddress = _mailAddress;
            Status = StatusActive;
        }

        protected Customer()
        {

        }

        public void Activate()
        {
            Status = StatusActive;
        }
        public void Deactivate()
        {
            Status = StatusDeactive;
        }
        
        public Boolean IsActive() 
        {
            return Status == StatusActive;
        }


    }
}
