using System;
using System.Collections.Generic;
using System.Text;

namespace MVVMPractice.Connections
{
    public interface IUnitOfWork
    {
        public IRepositories Repositories { get; }
    }
}
