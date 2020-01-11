using Microsoft.EntityFrameworkCore;
using SampleData.Models;
using SampleRepository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleRepository
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {

        private readonly SampleDBContext _DbContext;
        private readonly DbSet<T> _DbSet;

        public GenericRepository(SampleDBContext context)
        {
            _DbContext = context;
            this._DbSet = this._DbContext.Set<T>();
        }

        public void Add(T entity)
        {
            this._DbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            this._DbSet.Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return this._DbSet.ToList();
        }

        public T GetbyID(int id)
        {
            return this._DbSet.Find(id);
        }

        public void Update(T entity)
        {
            this._DbSet.Attach(entity);
            this._DbContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
