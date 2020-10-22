using OCPClassLibrary.Applicants;
using OCPClassLibrary.Models;

namespace OCPClassLibrary.AccountTypes
{
    public class Accounts : IAccounts
    {
        public EmployeeModel Create(IApplicant person)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{ person.FirstName.Substring(0, 1) }{person.LastName}@acme.com";

            return output;
        }
    }
}
