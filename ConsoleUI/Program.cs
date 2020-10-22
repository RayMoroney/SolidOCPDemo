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
            List<IApplicant> applicants = new List<IApplicant>
            {
                new Person { FirstName = "John", LastName = "Doe" },
                new Manager { FirstName = "Jane", LastName = "Doe" },
                new Executive { FirstName = "Tom", LastName = "Thumb" }
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();

            foreach (var person in applicants)
            {
                employees.Add(person.AccountProcessor.Create(person));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{ emp.FirstName } { emp.LastName }: { emp.EmailAddress } IsManager: { emp.IsManager } IsExecutive: { emp.IsExecutive }");
            }

            Console.ReadLine();
        }
    }
}
