using IntroEntityFramework.Models;

Console.WriteLine("Hello, World!");

SystemContext context = new SystemContext();

context.Database.EnsureCreated();

/* Computer c1 = new Computer (1, "2GB", "i3");
context.Add(c1);
context.SaveChanges(); */

/* Computer c2 = new Computer (2, "5GB", "i5");
context.Add(c2);
context.SaveChanges();

Computer c3 = new Computer (3, "7GB", "i7");
context.Add(c3);
context.SaveChanges(); */

//exibir todos
IEnumerable<Computer> computers = context.Computers.ToList();
foreach (var item in computers)
{
    Console.WriteLine($"{item.Id}, {item.Ram}, {item.Processor}");
}

//buscar por id
Computer encontrado = context.Computers.Find(2);
Console.WriteLine($"{encontrado.Id}, {encontrado.Ram}, {encontrado.Processor}");

//update na tabela
encontrado.Ram="10gb";
encontrado.Processor="intel";
context.Computers.Update(encontrado);
context.SaveChanges();

//remover da tabela
context.Computers.Remove(encontrado);
context.SaveChanges();