using OCPClassLibrary.Applicants;

namespace ConsoleUI
{
    public static class ClassInstanceGenerator
    {
        public static IApplicant CreatePerson()
        {
            return new Person();
        }

        public static IApplicant CreateManager()
        {
            return new Manager();
        }

        public static IApplicant CreateExecutive()
        {
            return new Executive();
        }
    }
}
