using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Travel.CoreLayer.Entity
{
    public class Vehicle
    {
        List<Vehicle> vehicles = new Vehicle()
        {

        }
        public readonly string StatusAvailable = "Available";

        public readonly string StatusNotAvailable = "NotAvailable";
        public virtual int Id { get; protected set; }
        public virtual string Name { get; protected set; }
        public virtual string Number { get; protected set; }
        public virtual string Color { get; protected set; }
        public virtual string Status { get; protected set; }

        public virtual int VehicleTypeId { get; protected set; }

        public virtual VehicleType VehicleType { get; protected set; }


        public Vehicle(string _name, string _number, string _color, VehicleType vehicleType)
        {
            Name = _name;
            Number = _number;
            Color = _color;
            Status = StatusAvailable;
            VehicleType = vehicleType;
        }

        protected Vehicle ()
        {

        }
        public void Available()
        {
            Status = StatusAvailable;
        }
        public void NotAvailable()
        {
            Status = StatusNotAvailable;
        }
        public Boolean IsAvailable()
        {
            return Status == StatusAvailable;
        }
    }
}
