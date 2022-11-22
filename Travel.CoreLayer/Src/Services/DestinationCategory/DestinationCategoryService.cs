using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Travel.CoreLayer.DTO.DestinationCategoryDto;
using Travel.CoreLayer.Exception;
using Travel.CoreLayer.Helper;
using Travel.CoreLayer.Repository;

namespace Travel.CoreLayer.Services.DestinationCategory
{
    public class DestinationCategoryService:DestinationCategoryServiceInterface
    {
        private readonly DestinationCategoryRepositoryInterface DestinationCategoryRepository;
        public DestinationCategoryService(DestinationCategoryRepositoryInterface _destinationCategoryRepository) {
        DestinationCategoryRepository =_destinationCategoryRepository;
        }

        public async Task Activate(long Id)
        {
            using TransactionScope scope = TransactionScopeHelper.GetInstance();
            var vehicleCategory = await DestinationCategoryRepository.GetById(Id).ConfigureAwait(false) ?? throw new DestinationCategoryNotFoundException();
            vehicleCategory.Activate();
            scope.Complete();
        }

        public Task Create(DestinationCategoryInsertDto dto)
        {
            throw new NotImplementedException();
        }

        public async Task Deactivate(long Id)
        {
            using TransactionScope scope = TransactionScopeHelper.GetInstance();
            var destinationCategory = await DestinationCategoryRepository.GetById(Id).ConfigureAwait(false) ?? throw new VehicleCategoryNotFoundException();
        
            destinationCategory.Deactivate();
            scope.Complete();
        }

        public Task Update(DestinationCategoryUpdateDto dto)
        {
            throw new NotImplementedException();
        }

       
    }
}
