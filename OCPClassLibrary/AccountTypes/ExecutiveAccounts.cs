using OCPClassLibrary.Applicants;
using OCPClassLibrary.Models;

namespace OCPClassLibrary.AccountTypes
{
    public class ExecutiveAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicant person)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{ person.FirstName }.{person.LastName}@acmecorp.com";

            output.IsManager = true;
            output.IsExecutive = true;

            return output;
        }
    }
}
