using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.CoreLayer.DTO.Customer
{
    public class CustomerUpdateDTO : CustomerInsertDTO
    {
        public int Id { get; set; }
        public CustomerUpdateDTO(int _id, string _name, string _address, string _mailaddress) : base( _name, _address, _mailaddress)
        {
            Id = _id;
        }
    }
}
