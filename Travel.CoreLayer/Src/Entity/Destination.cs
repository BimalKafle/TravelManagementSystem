using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.CoreLayer.Entity
{
    public class Destination
    {
        public virtual string Name { get; protected set; }
        public virtual string Address { get; protected set; }
        public virtual string  Speciality{ get; protected set; }
        public virtual int Rating { get; protected set; }

        public Destination(string name, string address, string speciality, int rating)
        {
            Name = name;
            Address = address;
            Speciality = speciality;
            Rating = rating;
        }
        protected Destination()
        {

        }

    }
}
