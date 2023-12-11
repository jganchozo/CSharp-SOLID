namespace After
{
    public class Person : IApplicant
    {
        public Person(string firstName, string lastName, IAccountService processor)
        {
            FirstName = firstName;
            LastName = lastName;
            Processor = processor;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccountService Processor { get; set; }
    }
}
