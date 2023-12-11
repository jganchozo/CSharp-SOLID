namespace After
{
    public class AccountDoctor : IAccountService
    {
        public Staff Create(IApplicant applicant)
        {
            Staff newStaff = new()
            {
                FirstName = applicant.FirstName,
                LastName = applicant.LastName,
                Email = $"{applicant.FirstName}.{applicant.LastName}@doctor.com".ToLower()
            };

            return newStaff;
        }
    }
}
