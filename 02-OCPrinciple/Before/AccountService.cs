using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Before
{
    internal class AccountService
    {
        public Staff Create(Person person)
        {
            Staff newStaff = new();
            newStaff.FirstName = person.FirstName;
            newStaff.LastName = person.LastName;

            switch (person.Role)
            {
                case Role.Doctor:
                    newStaff.Email = $"{person.FirstName}.{person.LastName}@doctor.com".ToLower();
                    break;
                case Role.Nurse:
                    newStaff.Email = $"{person.FirstName}.{person.LastName}@nurse.com".ToLower();
                    break;
            }

            newStaff.Role = person.Role;

            return newStaff;
        }
    }
}
