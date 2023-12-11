namespace After
{
    public class Processor
    {
        readonly IAccountService _accountService;

        public Processor(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public Staff CreateNewStaff(IApplicant applicant)
        {
            return _accountService.Create(applicant);
        }
    }
}
