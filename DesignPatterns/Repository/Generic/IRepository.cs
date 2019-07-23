using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Generic
{
    public interface IRepository<T> where T : class
    {
        T GetById(int id);

        void Create(T entity);

        void Delete(T entity);

        void Update(T entity);
    }
}
