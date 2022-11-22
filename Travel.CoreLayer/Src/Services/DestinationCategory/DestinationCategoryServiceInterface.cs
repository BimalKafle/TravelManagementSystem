using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.CoreLayer.DTO.DestinationCategoryDto;

namespace Travel.CoreLayer.Services.DestinationCategory
{
    public interface DestinationCategoryServiceInterface
    {
        public Task Create(DestinationCategoryInsertDto dto);
        public Task Update(DestinationCategoryUpdateDto dto);

        public Task Activate(long Id);
        public Task Deactivate(long Id);
    }
}
