using OCPClassLibrary.Applicants;
using OCPClassLibrary.Models;

namespace OCPClassLibrary.AccountTypes
{
    public interface IAccounts
    {
        EmployeeModel Create(IApplicant person);
    }
}
