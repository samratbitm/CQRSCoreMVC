using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SampleData.Models;
using SampleRepository.Interface;

namespace SampleRepository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SampleDBContext _DbContext;

        public EmployeeRepository EmpRepository { get; private set; }

        public UnitOfWork(SampleDBContext context)
        {
            this._DbContext = context;
            this.EmpRepository = new EmployeeRepository(this._DbContext);
        }

        public async Task Commit()
        {
           await this._DbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            this._DbContext.Dispose();
        }
    }
}
