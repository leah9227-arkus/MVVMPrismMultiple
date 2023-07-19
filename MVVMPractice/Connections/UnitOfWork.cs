using System;
using System.Collections.Generic;
using System.Text;

namespace MVVMPractice.Connections
{
    public class UnitOfWork : IUnitOfWork
    {
        public IRepositories Repositories { get; }

        public UnitOfWork()
        {
            Repositories = new Repositories();
        }
    }
}
