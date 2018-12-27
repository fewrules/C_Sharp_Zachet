using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squares.DAL.Abstract
{
    interface IGenericRepository<T>
        where T : class
    {
        void Create(T item);
        T FindById(int id);
        List<T> Get();
        List<T> Get(Func<T, bool> predicate);
        void Remove(T item);
        void Update(T item);
    }
}
