using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After
{
    internal class Doctor : IApplicant
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccountService Processor { get; set; } = new AccountServiceDoctor();
    }
}
