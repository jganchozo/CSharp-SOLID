using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After
{
    internal interface IApplicant
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        IAccountService Prossesor { get; set; }
    }
}
