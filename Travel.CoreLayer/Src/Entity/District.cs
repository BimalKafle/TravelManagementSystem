using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Travel.CoreLayer.Entity
{
    public class District
    {
        public readonly string StatusActive = "Active";
        public readonly string StatusDeactive = "Deacticve";
        public virtual string Name { get; protected set; }
        public virtual int Id { get; protected set; }
        public virtual string Status { get; protected set; }

        public District(string _name)
        {
            this.Name = _name;
        }

        protected District()
        {

        }
        public void Activate()
        {
            Status = StatusActive;
        }
        public void DeActivate()
        {
            Status = StatusDeactive;
        }

        List<Destination> Destinations = new List<Destination>();
    }
}
