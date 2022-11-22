using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.DataLayer.Src.Base
{
    public interface BaseRepositoryInterface<T> where T : class
    {
        public  T GetById(int Id);
        public T Update(T t);
        public T Delete(T t);
        public T Create(T t);
    }
    
}
