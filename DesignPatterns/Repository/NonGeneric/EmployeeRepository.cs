using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Repository.Domain;

namespace Repository.NonGeneric
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDbContext _context;
        public EmployeeRepository()
        {
            _context = new EmployeeDbContext();
        }
        public EmployeeRepository(EmployeeDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }
        public Employee GetById(int id)
        {
            return _context.Employees.Find(id);
        }
        public void Insert(Employee employee)
        {
            _context.Employees.Add(employee);
        }
        public void Update(Employee employee)
        {
            _context.Entry(employee).State = EntityState.Modified;
        }
        public void Delete(int id)
        {
            Employee employee = _context.Employees.Find(id);
            _context.Employees.Remove(employee);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }

}
