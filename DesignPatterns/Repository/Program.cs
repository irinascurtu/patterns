using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Repository.Domain;
using Repository.NonGeneric;

namespace Repository
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var context = new EmployeeDbContext())
            {
                //var emp = new Employee()
                //{
                //    Name = "Gigi Muschi"
                //};
                //context.Database.Migrate();
                //context.Employees.Add(emp);
                //context.SaveChanges();

                var ss = context.Employees.ToList();
                //show this, and then switch to repository
            }
            Console.WriteLine("Hello World!");
        }
    }
}
