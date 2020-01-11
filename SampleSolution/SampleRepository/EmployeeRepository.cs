using SampleData.Models;
using System.Collections.Generic;
using System.Linq;
using SampleRepository.Interface;

namespace SampleRepository
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        private readonly SampleDBContext _DbContext;

        public EmployeeRepository(SampleDBContext context) : base(context)
        {
            this._DbContext = context;
        }

        public IEnumerable<Employee> GetAllEmployeesByGender(string gender)
        {
            return from e in this._DbContext.Employee
                   where e.Gender.Equals(gender)
                   select e;
        }
    }
}
