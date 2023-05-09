using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After
{
    internal interface IAccountService
    {
        Staff Create(IApplicant applicant);
    }
}
