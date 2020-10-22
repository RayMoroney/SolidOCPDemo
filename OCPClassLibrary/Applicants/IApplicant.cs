using OCPClassLibrary.AccountTypes;

namespace OCPClassLibrary.Applicants
{
    public interface IApplicant
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        IAccounts AccountProcessor { get; set; }
    }
}
