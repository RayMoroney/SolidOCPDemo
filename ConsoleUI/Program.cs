using OCPClassLibrary.Applicants;
using OCPClassLibrary.Models;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IApplicant> applicants = new List<IApplicant>();

            Person person = (Person)ClassInstanceGenerator.CreatePerson();
            person.FirstName = "John";
            person.LastName = "Doe";
            applicants.Add(person);

            Manager manager = (Manager)ClassInstanceGenerator.CreateManager();
            manager.FirstName = "Jane";
            manager.LastName = "Doe";
            applicants.Add(manager);

            Executive executive = (Executive)ClassInstanceGenerator.CreateExecutive();
            executive.FirstName = "Tom";
            executive.LastName = "Thumb";
            applicants.Add(executive);

            List<EmployeeModel> employees = new List<EmployeeModel>();

            foreach (var employee in applicants)
            {
                employees.Add(employee.AccountProcessor.Create(person));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{ emp.FirstName } { emp.LastName }: { emp.EmailAddress } IsManager: { emp.IsManager } IsExecutive: { emp.IsExecutive }");
            }

            Console.ReadLine();
        }
    }
}
