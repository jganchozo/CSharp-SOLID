namespace After
{
    public class AccountNurse : IAccountService
    {
        public Staff Create(IApplicant applicant)
        {
            Staff newStaff = new()
            {
                FirstName = applicant.FirstName,
                LastName = applicant.LastName,
                Email = $"{applicant.FirstName}.{applicant.LastName}@nurse.com".ToLower()
            };

            return newStaff;
        }
    }
}
