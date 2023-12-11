// See https://aka.ms/new-console-template for more information

using Before;

List<Person> persons = new()
{
    new Person{ FirstName = "Jose", LastName = "Ganchozo"},
    new Person{ FirstName = "Rodrigo", LastName = "Morales", Role = Role.Nurse},
    new Person{ FirstName = "Miguel", LastName = "Sandoval"},
};

List<Staff> staffs = new();

foreach (Person staff in persons)
    staffs.Add(new AccountService().Create(staff));

foreach (Staff staff in staffs)
    Console.WriteLine($"Bienvenido {staff.FirstName}, {staff.LastName}, {staff.Email}, Es doctor: {(staff.Role == Role.Doctor ? "SI" : "NO")}, Es enfermera: {(staff.Role == Role.Nurse ? "SI" : "NO")}");

Console.ReadLine();