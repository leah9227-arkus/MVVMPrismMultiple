using MVVMPractice.Connections.Repos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVMPractice.Connections
{
    public interface IRepositories
    {
        public IBeerRepository BeerRepository { get; }
    }
}
