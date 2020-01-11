using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SampleRepository.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        Task Commit();
    }
}
