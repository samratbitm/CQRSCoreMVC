using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleRepository;
using SampleRepository.Interface;

namespace SampleWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly UnitOfWork _UoW;

        public EmployeeController(IUnitOfWork uow)
        {
            this._UoW = uow as UnitOfWork;
        }
        
        public IActionResult index()
        {
            dynamic model = new ExpandoObject();
            model.Employee = this._UoW.EmpRepository.GetAllEmployeesByGender("Male");
            
            return null;
        }
    }
}