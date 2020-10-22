using OCPClassLibrary.Applicants;
using OCPClassLibrary.Models;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    public static class EmployeeProcessor
    {
        public static List<IApplicant> GetAppliants()
        {
            List<IApplicant> output = new List<IApplicant>();

            Person person = (Person)ClassInstanceGenerator.CreatePerson();
            person.FirstName = "John";
            person.LastName = "Doe";
            output.Add(person);

            Manager manager = (Manager)ClassInstanceGenerator.CreateManager();
            manager.FirstName = "Jane";
            manager.LastName = "Doe";
            output.Add(manager);

            Executive executive = (Executive)ClassInstanceGenerator.CreateExecutive();
            executive.FirstName = "Tom";
            executive.LastName = "Thumb";
            output.Add(executive);

            return output;
        }

        public static List<EmployeeModel> EmployApplicants(List<IApplicant> applicants)
        {
            List<EmployeeModel> output = new List<EmployeeModel>();

            foreach (var employee in applicants)
            {
                output.Add(employee.AccountProcessor.Create(employee));
            }

            return output;
        }

        public static void DisplayEmployees(List<EmployeeModel> employees)
        {
            foreach (var emp in employees)
            {
                Console.WriteLine($"{ emp.FirstName } { emp.LastName }: { emp.EmailAddress } IsManager: { emp.IsManager } IsExecutive: { emp.IsExecutive }");
            }
        }
    }
}
