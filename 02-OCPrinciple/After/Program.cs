// See https://aka.ms/new-console-template for more information


using After;

List<IApplicant> applicants = new()
{
    new Person{ FirstName = "Jose", LastName = "Ganchozo", Processor = new AccountService()},
    new Doctor{ FirstName = "Rodrigo", LastName = "Morales"},
    new Nurse{ FirstName = "Miguel", LastName = "Sandoval"},
};

List<Staff> staffs = new();

foreach (IApplicant staff in applicants)
    staffs.Add(staff.Processor.Create(staff));

foreach (Staff staff in staffs)
    Console.WriteLine($"Bienvenido {staff.FirstName}, {staff.LastName}, {staff.Email}");

Console.ReadLine();