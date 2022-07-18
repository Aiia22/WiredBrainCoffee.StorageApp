using System;
using WiredBrainCoffee.StorageApp.Entities;
using WiredBrainCoffee.StorageApp.Repositories;






namespace WiredBrainCoffee.StorageApp
{
    class Program
    {

        static void Main(string[] args)
        {
            var employeesRepository = new ListRepository<Employee>();
            AddEmployees(employeesRepository);
            GetEmployeeById(employeesRepository);

            var organizationRepository = new ListRepository<Organization>();
            AddOrganization(organizationRepository);

            Console.ReadLine();
        }

        private static void GetEmployeeById(ListRepository<Employee> employeesRepository)
        {
            var employee = employeesRepository.GetById(2);
            Console.WriteLine($"Employee with Id 2: {employee.FirstName}");
        }

        private static void AddEmployees(ListRepository<Employee> employeesRepository)
        {
            employeesRepository.Add(new Employee { FirstName = "Julia" });
            employeesRepository.Add(new Employee { FirstName = "Anna" });
            employeesRepository.Add(new Employee { FirstName = "Thomas" });
            employeesRepository.Save();
        }

        private static void AddOrganization(ListRepository<Organization> organizationRepository)
        {
            organizationRepository.Add(new Organization { Name = "Plurialsight" });
            organizationRepository.Add(new Organization { Name = "Globomantic" });
            organizationRepository.Save();
        }
    }
}

/* - Implement a generic class:
 * Ineherit from a generic class 
 * use multiple type parameters
 * -Add generic type constraints
 * use a concrete class(EntityBase)
 * work with class and struct constraints
 * call constructor with new() constraint
 * -Use the defautl Keyword */