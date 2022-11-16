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
        public virtual int Id { get; protected set; }
        public virtual string Name { get; protected set; }
        List<Vehicle> Vehicles = new List<Vehicle>();

        public VehicleType(string _name, string _number, string _color)
        {
            Name = _name;
            Number = _number;
            Color = _color;
        }
    }
}
