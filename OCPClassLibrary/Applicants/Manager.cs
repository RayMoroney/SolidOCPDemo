using OCPClassLibrary.AccountTypes;

namespace OCPClassLibrary.Applicants
{
    public class Manager : IApplicant
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccounts AccountProcessor { get; set; } = new ManagerAccounts();
    }
}
