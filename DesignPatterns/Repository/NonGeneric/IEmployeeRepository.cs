using System;
using System.Collections.Generic;
using System.Text;
using Repository.Domain;

namespace Repository.NonGeneric
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        Employee GetById(int id);
        void Insert(Employee employee);
        void Update(Employee employee);
        void Delete(int id);
        void Save();
    }
}
