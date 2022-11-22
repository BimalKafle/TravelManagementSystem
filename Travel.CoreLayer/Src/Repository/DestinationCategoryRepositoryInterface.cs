using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.CoreLayer.Entity;

namespace Travel.CoreLayer.Repository
{
    public interface DestinationCategoryRepositoryInterface
    {
        public Task Insert(DestinationCategory category);
        public Task Update(DestinationCategory category);
        public Task<DestinationCategory?> GetById(long Id);
        public Task<DestinationCategory?> GetByName(string name);
        public Task<IEnumerable<DestinationCategory>> GetAll();
    }
}
