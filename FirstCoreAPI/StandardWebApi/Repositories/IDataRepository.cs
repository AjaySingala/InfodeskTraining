using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardWebApi.Repositories
{
    public interface IDataRepository<T>
    {
        List<T> Get();
        T Get(int id);
        int Create(T entity);
        void Update(int id, T entity);
        void Delete(int id);
    }
}
