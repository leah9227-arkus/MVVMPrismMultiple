using MVVMPractice.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVMPractice.Connections.Repos
{
    public interface IBeerRepository
    {
        public Beer GetBeer();
        public Beer GetRandomBeer();
    }
}
