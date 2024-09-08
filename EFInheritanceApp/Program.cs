using EFInheritanceApp;

using(CompaniesDbContext context = new())
{
    DataInit(context);
}

void DataInit(CompaniesDbContext context)
{
    context.Database.EnsureDeleted();
    context.Database.EnsureCreated();

    

    Employee bob = new Employee() { Name = "Bobby", Salary = 50000 };
    Employee joe = new Employee() { Name = "Joseph", Salary = 80000 };
    Employee sam = new Employee() { Name = "Sammy", Salary = 60000 };

    Developer tim = new Developer() { Name = "Timmy", Salary = 100000, Language = "C++"  };
    Developer max = new Developer() { Name = "Maxim", Salary = 120000, Language = "C#" };

    Manager kim = new Manager() { Name = "Kimmy", Salary = 75000, Department = "Salary" };
    Manager pit = new Manager() { Name = "Pitty", Salary = 82000, Department = "Study" };

    context.Employees.AddRange(bob, joe, sam, tim, max, kim, pit);

    context.SaveChanges();

}
