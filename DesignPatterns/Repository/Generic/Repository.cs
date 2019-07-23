using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Generic
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public void Create(T entity)
        {
            //Write your logic here to persist the entity
        }

        public void Delete(T entity)
        {
            //Write your logic here to delete an entity
        }

        public T GetById(int id)
        {
            //Write your logic here to retrieve an entity by Id
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            //Write your logic here to update an entity
        }
    }
}
