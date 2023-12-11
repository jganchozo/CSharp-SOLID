namespace After
{
    public class Doctor : IApplicant
    {
        public Doctor(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccountService Processor { get; set; } = new AccountDoctor();
    }
}
