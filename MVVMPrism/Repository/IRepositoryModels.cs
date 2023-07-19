using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMPrism.Repository
{
    public interface IRepositoryModels<T>
    {
        List<T> GetAllData();
        T GetItem(int id);
        bool Insert(T item);
        bool Update(T item);
        bool Delete(T item);
        void Clear();

    }
}
