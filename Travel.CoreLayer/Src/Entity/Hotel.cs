using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.CoreLayer.Entity
{

    public class Hotel
    {
        private readonly string StatusOpen = "Open";
        public readonly string StatusClosed = "Closed";
        public virtual string Name { get; protected set; }
        public virtual string Location { get; protected set; }
        public virtual int Id { get; protected set; }
        public virtual string Status{get; protected set;}
        public Hotel(string _name, string _location)
        {
            Name = _name;
            Location = _location;
        }
        private Hotel() { }
        public void Open()
        {
            Status = StatusOpen;
        }
        public void Closed()
        {
            Status = StatusClosed;
        }
        public Boolean IsOpen()
        {
            return Status == StatusOpen;
        }
    }
}
