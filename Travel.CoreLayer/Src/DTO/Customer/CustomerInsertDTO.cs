using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.CoreLayer.DTO.Customer
{
    public class CustomerInsertDTO
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string MailAddress { get; set; }

        public CustomerInsertDTO(string _name, string _address, string _mailaddress)
        {
            Name = _name;
            Address = _address;
            MailAddress = _mailaddress;
        }
    }
}
