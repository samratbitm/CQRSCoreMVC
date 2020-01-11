using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleRepository.Interface
{
    public interface IRepository<T> where T:class
    {
        IEnumerable<T> GetAll();

        T GetbyID(int id);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
