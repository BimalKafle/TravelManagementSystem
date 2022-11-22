using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.DataLayer.Src.Base
{
    public class BaseRepoClass<T>:BaseRepositoryInterface<T> where T:class
    {
        public Task<T> GetById(int id)
        {
            
        }

        public Task<T> Update(T t)
        {
            throw new NotImplementedException();
        }

        public Task<T> Delete(T t)
        {
            throw new NotImplementedException();
        }

        public T Create(T t)
        {
            throw new NotImplementedException();
        }

      
    }
}
