using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.CoreLayer.Entity
{
    public class DestinationCategory
    {
        private readonly string StatusActive = "Active";
        private readonly string StatusDeactive = "Deactive";

        public DestinationCategory(string name, string status)
        {
           
            Name=name;
            Status=status;
        }

        protected DestinationCategory() { }

        public virtual int Id { get; protected set; }
        public virtual string Name { get; protected set; }
        public virtual string Status { get; protected set; }

        public void Activate() {
            Status=StatusActive;
        
        }

        public void Deactivate()
        {
            Status=StatusDeactive;
        }
    }
}
