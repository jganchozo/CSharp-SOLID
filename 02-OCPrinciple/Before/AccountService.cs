namespace Before
{
    public class AccountService
    {
        public Staff Create(Person person)
        {
            Staff newStaff = new()
            {
                FirstName = person.FirstName,
                LastName = person.LastName
            };

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
