using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Travel.CoreLayer.Entity
{
    public class VehicleType
    {
        public readonly string StatusActive = "Active";

        public readonly string StatusDeactive = "Deactive";
        public virtual int Id { get; protected set; }
        public virtual string Name { get; protected set; }
        public virtual string Status { get; protected set; }

        List<Vehicle> Vehicles = new List<Vehicle>();

        public VehicleType(string _name)
        {
            Name = _name;
        }
        public void Active()
        {
            Status = StatusActive;
        }

        public void Deactive()
        {
            Status = StatusDeactive;
        }

        public Boolean IsActive()
        {

        }
    }
}
