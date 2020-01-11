using SampleData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleRepository.Interface
{
    interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployeesByGender(string gender);
    }
}
