using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After
{
    internal class AccountServiceDoctor : IAccountService
    {
        public Staff Create(IApplicant applicant)
        {
            Staff newStaff = new();
            newStaff.FirstName = applicant.FirstName;
            newStaff.LastName = applicant.LastName;
            newStaff.Email = $"{applicant.FirstName}.{applicant.LastName}@doctor.com".ToLower();

            return newStaff;
        }
    }
}
