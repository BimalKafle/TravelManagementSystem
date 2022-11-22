using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.CoreLayer.Exception
{
    public class DestinationCategoryNotFoundException:SystemException
    {
        public DestinationCategoryNotFoundException(string? message = "Destination category not found") : base(message)
        {
        }
    }
}
