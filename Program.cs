using System;
using WiredBrainCoffee.StorageApp.Entities;
using WiredBrainCoffee.StorageApp.Repositories;






namespace WiredBrainCoffee.StorageApp
{
  class Program
    {

        static void Main(string[] args)
        {
            var employeesRepository = new GenericRepository<Employee>();
            AddEmployees(employeesRepository);
            GetEmployeeById(employeesRepository);

            var organizationRepository = new GenericRepository<Organization>();
            AddOrganization(organizationRepository);

            Console.ReadLine();
        }

        private static void GetEmployeeById(GenericRepository<Employee> employeesRepository)
        {
            var employee = employeesRepository.GetById(2);
            Console.WriteLine($"Employee with Id 2: {employee.FirstName}");
        }

        private static void AddEmployees(GenericRepository<Employee> employeesRepository)
        {
            employeesRepository.Add(new Employee { FirstName = "Julia" });
            employeesRepository.Add(new Employee { FirstName = "Anna" });
            employeesRepository.Add(new Employee { FirstName = "Thomas" });
            employeesRepository.Save();
        }

        private static void AddOrganization(GenericRepository<Organization> organizationRepository)
        {
            organizationRepository.Add(new Organization { Name = "Plurialsight" });
            organizationRepository.Add(new Organization { Name = "Globomantic" });
            organizationRepository.Save();
        }
    }
}

