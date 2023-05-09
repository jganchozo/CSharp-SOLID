using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After
{
    internal class AccountServiceNurse : IAccountService
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
