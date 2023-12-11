namespace After
{
    public class AccountService : IAccountService
    {
        public Staff Create(IApplicant applicant)
        {
            Staff newStaff = new()
            {
                FirstName = applicant.FirstName,
                LastName = applicant.LastName,
                Email = $"{applicant.FirstName}.{applicant.LastName}@staff.com".ToLower()
            };

            return newStaff;
        }
    }
}
