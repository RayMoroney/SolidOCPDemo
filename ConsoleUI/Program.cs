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
            // This main method should only control program flow.

            List<IApplicant> applicants = EmployeeProcessor.GetAppliants();

            List<EmployeeModel> employees = EmployeeProcessor.EmployApplicants(applicants);

            EmployeeProcessor.DisplayEmployees(employees);

            Console.ReadLine();
        }
    }
}
